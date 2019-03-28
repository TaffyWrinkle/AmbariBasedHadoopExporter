﻿// <copyright file="Runtime.cs" company="Microsoft">
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
// </copyright>

namespace Core.Models.AmbariResponseEntities.YarnResourceManager
{
    using Newtonsoft.Json;

    public class Runtime
    {
        [JsonProperty(PropertyName = "StartTime")]
        public long StartTime { get; set; }
    }
}
