using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Remembr.Models
{
    public class MindMap
    {
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "content")]
        public string Content { get; set; }
    }
}
