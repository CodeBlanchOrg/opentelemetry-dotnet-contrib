// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

using System.Diagnostics;
using System.Diagnostics.Metrics;
using OpenTelemetry.Internal;
using OpenTelemetry.Trace;

namespace OpenTelemetry.Instrumentation.ConfluentKafka;

internal static class ConfluentKafkaCommon
{
    internal static readonly string InstrumentationName = typeof(ConfluentKafkaCommon).Assembly.GetName().Name!;
    internal static readonly string InstrumentationVersion = typeof(ConfluentKafkaCommon).Assembly.GetPackageVersion();
    internal static readonly ActivitySource ActivitySource = new(InstrumentationName, InstrumentationVersion);
    internal static readonly Meter Meter = new(InstrumentationName, InstrumentationVersion);
    internal static readonly Counter<long> ReceiveMessagesCounter = Meter.CreateCounter<long>(SemanticConventions.MetricMessagingReceiveMessages);
    internal static readonly Histogram<double> ReceiveDurationHistogram = Meter.CreateHistogram<double>(SemanticConventions.MetricMessagingReceiveDuration);
    internal static readonly Counter<long> PublishMessagesCounter = Meter.CreateCounter<long>(SemanticConventions.MetricMessagingPublishMessages);
    internal static readonly Histogram<double> PublishDurationHistogram = Meter.CreateHistogram<double>(SemanticConventions.MetricMessagingPublishDuration);
}
