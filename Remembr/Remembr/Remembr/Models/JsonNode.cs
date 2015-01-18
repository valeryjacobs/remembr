using System;
using System.Collections.Generic;
using System.Text;

namespace Remembr.Models
{
    public class JsonNode
    {
          public JsonNode()
        {
            c = new List<JsonNode>();
            cid = "0";
        }

        public string id { get; set; }
        public string n { get; set; }
        public string d { get; set; }
        public string cid { get; set; }
        public List<JsonNode> c { get; set; }
    }
}
