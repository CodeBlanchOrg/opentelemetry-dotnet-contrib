// Copyright The OpenTelemetry Authors
// SPDX-License-Identifier: Apache-2.0

// <auto-generated>This file has been auto generated from scripts/templates/SemanticConventionsAttributes.cs.j2</auto-generated>

#pragma warning disable CS1570 // XML comment has badly formed XML

using System;

namespace OpenTelemetry.SemanticConventions;

/// <summary>
/// Constants for semantic attribute names outlined by the OpenTelemetry specifications.
/// </summary>
public static class AspnetcoreAttributes
{
    /// <summary>
    /// ASP.NET Core exception middleware handling result.
    /// </summary>
    public const string AttributeAspnetcoreDiagnosticsExceptionResult = "aspnetcore.diagnostics.exception.result";

    /// <summary>
    /// Full type name of the <a href="https://learn.microsoft.com/dotnet/api/microsoft.aspnetcore.diagnostics.iexceptionhandler"><c>IExceptionHandler</c></a> implementation that handled the exception.
    /// </summary>
    public const string AttributeAspnetcoreDiagnosticsHandlerType = "aspnetcore.diagnostics.handler.type";

    /// <summary>
    /// Rate limiting policy name.
    /// </summary>
    public const string AttributeAspnetcoreRateLimitingPolicy = "aspnetcore.rate_limiting.policy";

    /// <summary>
    /// Rate-limiting result, shows whether the lease was acquired or contains a rejection reason.
    /// </summary>
    public const string AttributeAspnetcoreRateLimitingResult = "aspnetcore.rate_limiting.result";

    /// <summary>
    /// Flag indicating if request was handled by the application pipeline.
    /// </summary>
    public const string AttributeAspnetcoreRequestIsUnhandled = "aspnetcore.request.is_unhandled";

    /// <summary>
    /// A value that indicates whether the matched route is a fallback route.
    /// </summary>
    public const string AttributeAspnetcoreRoutingIsFallback = "aspnetcore.routing.is_fallback";

    /// <summary>
    /// Match result - success or failure.
    /// </summary>
    public const string AttributeAspnetcoreRoutingMatchStatus = "aspnetcore.routing.match_status";

    /// <summary>
    /// ASP.NET Core exception middleware handling result.
    /// </summary>
    public static class AspnetcoreDiagnosticsExceptionResultValues
    {
        /// <summary>
        /// Exception was handled by the exception handling middleware.
        /// </summary>
        public const string Handled = "handled";

        /// <summary>
        /// Exception was not handled by the exception handling middleware.
        /// </summary>
        public const string Unhandled = "unhandled";

        /// <summary>
        /// Exception handling was skipped because the response had started.
        /// </summary>
        public const string Skipped = "skipped";

        /// <summary>
        /// Exception handling didn't run because the request was aborted.
        /// </summary>
        public const string Aborted = "aborted";
    }

    /// <summary>
    /// Rate-limiting result, shows whether the lease was acquired or contains a rejection reason.
    /// </summary>
    public static class AspnetcoreRateLimitingResultValues
    {
        /// <summary>
        /// Lease was acquired.
        /// </summary>
        public const string Acquired = "acquired";

        /// <summary>
        /// Lease request was rejected by the endpoint limiter.
        /// </summary>
        public const string EndpointLimiter = "endpoint_limiter";

        /// <summary>
        /// Lease request was rejected by the global limiter.
        /// </summary>
        public const string GlobalLimiter = "global_limiter";

        /// <summary>
        /// Lease request was canceled.
        /// </summary>
        public const string RequestCanceled = "request_canceled";
    }

    /// <summary>
    /// Match result - success or failure.
    /// </summary>
    public static class AspnetcoreRoutingMatchStatusValues
    {
        /// <summary>
        /// Match succeeded.
        /// </summary>
        public const string Success = "success";

        /// <summary>
        /// Match failed.
        /// </summary>
        public const string Failure = "failure";
    }
}