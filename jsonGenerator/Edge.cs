using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonGenerator
{
    public class Edge
    {
        public string id { get; set; }
        public string source { get; set; }
        public string target { get; set; }
        public string type { get; set; }

        public Edge() { }

        public Edge(string id, string source, string target)
        {
            this.id = id;
            this.source = source;
            this.target = target;
            this.type = "arrow";
        }

    }
}
