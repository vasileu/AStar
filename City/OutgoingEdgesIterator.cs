using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class OutgoingEdgesIterator
    {
        private Graph G;
        private int vertex;
        private int i;

        public OutgoingEdgesIterator(Graph G, int vertex)
        {
            this.G = G;
            this.vertex = vertex;
            i = -1;
        }

        public Edge begin()
        {
            i = -1;
            return next();
        }

        public Edge next()
        {
            for (i++; i < G.vertexCount(); i++)
            {
                if (G.edgeWeight(vertex, i) >= 0)
                {
                    return new Edge(vertex, i,  G.edgeWeight(vertex, i));
                }
            }
            // возвращается некорректное ребро, но при этом функция end() == true
            return new Edge();
        }

        public bool end()
        {
            return i >= G.vertexCount();
        }

    }
}
