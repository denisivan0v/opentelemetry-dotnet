// <copyright file="AppBuilderExtensions.cs" company="OpenTelemetry Authors">
// Copyright The OpenTelemetry Authors
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>

using Owin;

namespace OpenTelemetry
{
    /// <summary>
    /// Provides extension methods for the <see cref="IAppBuilder"/> class.
    /// </summary>
    public static class AppBuilderExtensions
    {
        /// <summary>Adds a component to the OWIN pipeline for instrumenting incoming request with System.Diagnostics.Activity and notifying listeners with DiagnosticsSource.</summary>
        /// <param name="appBuilder">The application builder.</param>
        /// <returns>The application builder instance.</returns>
        public static IAppBuilder UseOpenTelemetry(this IAppBuilder appBuilder)
            => appBuilder.Use<DiagnosticsMiddleware>();
    }
}