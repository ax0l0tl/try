﻿using System;
using Newtonsoft.Json;

namespace Microsoft.DotNet.Try.Protocol
{
    public class RequestDescriptorProperty
    {
        [JsonProperty("name")]
        public string Name { get; }
        [JsonProperty("value")]
        public object Value { get; }

        public RequestDescriptorProperty(string name, object value = null)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Value cannot be null or whitespace.", nameof(name));
            Name = name;
            Value = value;
        }
    }
}