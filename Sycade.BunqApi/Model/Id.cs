﻿using Newtonsoft.Json;

namespace Sycade.BunqApi.Model
{
    public class Id : IBunqEntity
    {
        [JsonProperty("id")]
        public int Value { get; set; }
    }
}
