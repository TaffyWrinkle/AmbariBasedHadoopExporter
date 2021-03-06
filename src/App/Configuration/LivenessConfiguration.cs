﻿// <copyright file="LivenessConfiguration.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// </copyright>

namespace App.Configuration
{
    using System.ComponentModel.DataAnnotations;
    using Core.Configurations;

    public class LivenessConfiguration : BaseValidatableConfiguration
    {
        /// <summary>
        /// Gets or sets the sampling period of the pods liveness.
        /// </summary>
        [Required]
        [Range(0, int.MaxValue)]
        public int SamplingPeriodInSeconds { get; set; }

        /// <summary>
        /// Gets or sets the liveness file path that Kubernetes will access to validate the pod's health.
        /// </summary>
        public string LivenessFilePath { get; set; }
    }
}
