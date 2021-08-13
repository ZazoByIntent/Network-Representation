using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonGenerator
{
    public class Node
    {
        public string id { get; set; }
        public string label { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int size { get; set; }

        public int connectionInCount = 0;
        public int connectionOutCount = 0;
        public bool center = false;
        public bool placed = false;
        public int nodesPlaced = 0;

        public Node() { }
        public Node(string id, string label, int x, int y, int size)
        {
            this.id = id;
            this.label = label;
            this.x = x;
            this.y = y;
            this.size = size;
        }



    }
}
