// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace Microsoft.AspNetCore.Blazor.Services
{
    [LinkerPreserve] // DI service
    internal class WebAssemblyLoggerFactory : ILoggerFactory
    {
        public void AddProvider(ILoggerProvider provider)
        {
            // No-op
        }

        public ILogger CreateLogger(string categoryName)
            => new WebAssemblyConsoleLogger<object>();

        public void Dispose()
        {
            // No-op
        }
    }
}