using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Edge
    {
        public int source { get; set; }
        public int destination { get; set; }
        public int weight { get; set; }

        public Edge(int sourceVertex, int destVertex, int edgeWeight)
        {
            source = sourceVertex;
            destination = destVertex;
            weight = edgeWeight;
        }

        public Edge() : this(0, 0, 0)
        {
        }

    }
}
