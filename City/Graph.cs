using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    class Graph
    {
        private int _vertexCount;
        private int _edgeCount;
        private int[ , ] _edges;
        private bool _isDirected;

        public Graph(int vertexCount, bool isDirected)
        {
            _isDirected = isDirected;
            _vertexCount = vertexCount;
            _edgeCount = 0;
            _edges = new int[vertexCount, vertexCount];
            for (int i = 0; i < vertexCount; i++)
            {
                for (int j = 0; j < vertexCount; j++)
                {
                    _edges[i, j] = -1;
                }
            }
        }

        public void insertEdge(Edge edge)
        {
            int src = edge.source;
            int dest = edge.destination;
            if (_edges[src, dest] < 0)
            {
                _edgeCount++;
            }
            _edges[src, dest] = edge.weight;
            if (!_isDirected)
            {
                _edges[dest, src] = edge.weight;
            }
        }

        public int edgeCount()
        {
            return _edgeCount;
        }

        public int vertexCount()
        {
            return _vertexCount;
        }

        public bool isDirectedGraph()
        {
            return _isDirected;
        }

        public int edgeWeight(int source, int dest)
        {
            return _edges[source, dest];
        }

        public void removeEdge(int src, int dest)
        {
            if (_edges[src, dest] != -1)
            {
                _edgeCount--;
            }
            _edges[src, dest] = -1;
            if (!_isDirected)
            {
                _edges[dest, src] = -1;
            }
        }

    }
}
