﻿using Newtonsoft.Json;

namespace Sycade.BunqApi.Model
{
    public class ServerPublicKey : IBunqEntity
    {
        [JsonProperty("server_public_key")]
        public string Value { get; set; }

        internal ServerPublicKey() { }

        public ServerPublicKey(string value)
        {
            Value = value;
        }
    }
}
