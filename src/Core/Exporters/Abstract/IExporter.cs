﻿// <copyright file="IExporter.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// </copyright>

namespace Core.Exporters.Abstract
{
    using System.Collections.Concurrent;
    using System.Threading.Tasks;
    using Prometheus;

    /// <summary>
    /// Interface of the basic behavior of the exporters.
    /// </summary>
    public interface IExporter
    {
        /// <summary>
        /// Gets the Prometheus Collectors of the implementing class.
        /// </summary>
        ConcurrentDictionary<string, Collector> Collectors { get; }

        /// <summary>
        /// Exporting metrics of the implementing component.
        /// </summary>
        /// <returns>The relevant Task.</returns>
        Task ExportMetricsAsync();
    }
}
