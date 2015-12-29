using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace City
{
    
    class AStar
    {
        private Graph _graph;
        private int _startVertex;
        private int _finishVertex;
        private int _columnCount;
        private int _koeff;
        private Location[] _locations;
        private int[] _wage;
        private int[] _prev;
        private List<int> _opened;
        private int[] _heightDiff;
        private bool[] _visited;

        struct Node
        {
            public double heuristics;
            public int vertexNumber;
            public Node(double heuristics, int vertexNumber)
            {
                this.heuristics = heuristics;
                this.vertexNumber = vertexNumber;
            }
        }

        public List<int> findPath(Graph graph, Location[] locations, int startVertex, int finishVertex, int columnCount, int koeff)
        {
            _opened = new List<int>();
            _graph = graph;
            _startVertex = startVertex;
            _finishVertex = finishVertex;
            _columnCount = columnCount;
            _locations = locations;
            _koeff = koeff;

            init();
            List<Node> queue= new List<Node >();
            queue.Add(new Node(heuristics(_startVertex, _finishVertex), _startVertex));
            while ( !(queue.Count == 0) )
            {
                queue.Sort( (node1, node2) => node1.heuristics.CompareTo(node2.heuristics) );
                Node node = queue[0];
                _opened.Add(node.vertexNumber);
                if (node.vertexNumber == _finishVertex)
                {
                    break;
                }
                queue.RemoveAt(0);
                OutgoingEdgesIterator iter = new OutgoingEdgesIterator(_graph, node.vertexNumber);
                for (Edge edge = iter.begin(); !iter.end(); edge = iter.next())
                {
                    if (notVisited(edge.destination)){
                        int srcValue = _locations[edge.source].value;
                        int destValue = _locations[edge.destination].value;
                        int heightDiff;
                        if (srcValue > destValue)
                        {
                            heightDiff = -(destValue - srcValue) / 2;
                        }
                        else
                        {
                            heightDiff = destValue - srcValue;
                        }
                        _visited[edge.destination] = true;
                        _heightDiff[edge.destination] = _heightDiff[node.vertexNumber] + heightDiff;
                        _wage[edge.destination] = _wage[node.vertexNumber] + heightDiff + _koeff * edge.weight;
                        _prev[edge.destination] = node.vertexNumber;
                        queue.Add(new Node(heuristics(edge.destination, finishVertex), edge.destination));
                    }
                }
            }

            return result();
        }

        private void init() 
        {
            _visited = new bool[_graph.vertexCount()];
            for (int i = 0; i < _visited.Length; i++)
            {
                _visited[i] = false;
            }
            _visited[_startVertex] = true;

            _heightDiff = new int[_graph.vertexCount()];
            for (int i = 0; i < _heightDiff.Length; i++)
            {
                _heightDiff[i] = 0;
            }

            _wage = new int[_graph.vertexCount()];
            for (int i = 0; i < _wage.Length; i++)
            {
                _wage[i] = -1;
            }
            _wage[_startVertex] = 0;

            _prev = new int[_graph.vertexCount()];
            for (int i = 0; i < _prev.Length; i++)
            {
                _prev[i] = -1;
            }
            _prev[_startVertex] = _startVertex;
        }

        private double evaluate(int src, int dest)
        {
            int srcRow = src / _columnCount;
            int srcCol = src % _columnCount;
            int destRow = dest / _columnCount;
            int destCol = dest % _columnCount;

            return Math.Abs(srcRow - destRow) + Math.Abs(srcCol - destCol);
        }

        private bool notVisited(int vertex)
        {
            return !_visited[vertex];
        }

        private double heuristics(int src, int dest)
        {
            return _wage[src] + _koeff * evaluate(src, dest);
        }

        private List<int> result()
        {
            List<int> result = new List<int>();
            if (_wage[_finishVertex] >= 0)
            {
                int currentVertex = _finishVertex;
                while (_prev[currentVertex] != _startVertex)
                {
                    currentVertex = _prev[currentVertex];
                    result.Add(currentVertex);
                }
            }

            return result;
        }

        public List<int> opened()
        {         

            return _opened;
        }

        public int totalWeight()
        {
            return _wage[_finishVertex];
        }
        public int totalHeightDiff()
        {
            return _heightDiff[_finishVertex];
        }

    }
}
