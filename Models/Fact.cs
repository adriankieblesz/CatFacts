using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetwiseTest.Models
{
    public class Fact
    {
        [JsonPropertyName("fact")]
        public string Message { get; set; }
        [JsonPropertyName("length")]
        public int Length { get; set; }
    }
}
