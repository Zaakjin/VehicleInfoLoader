﻿// ReSharper disable InconsistentNaming
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VehicleInfoLoader.data
{
    public sealed class LiveryCollection
    {
        public int amount { get; internal set; }

        [JsonProperty] 
        internal Dictionary<int, Livery> list;
    }
}