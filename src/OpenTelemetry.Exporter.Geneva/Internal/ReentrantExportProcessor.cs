// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

namespace OpenTelemetry.Exporter.Geneva;

// This export processor exports without synchronization.
// Once OpenTelemetry .NET officially support this,
// we can get rid of this class.
// This is currently only used in ETW export, where we know
// that the underlying system is safe under concurrent calls.
internal class ReentrantExportProcessor<T> : BaseExportProcessor<T>
    where T : class
{
    [ThreadStatic]
    private static T[]? threadStorage;

    public ReentrantExportProcessor(BaseExporter<T> exporter)
        : base(exporter)
    {
    }

    protected override void OnExport(T data)
    {
        var storage = threadStorage ??= new T[1];

        storage[0] = data;

        this.exporter.Export(new Batch<T>(storage, 1));
    }
}
