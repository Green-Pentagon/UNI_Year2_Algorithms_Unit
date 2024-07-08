using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_Work
{
    internal class Graph<T> where T : IComparable
    {
        LinkedList<GraphNode<T>> nodes;
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public Graph() { nodes = new LinkedList<GraphNode<T>>(); }
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public bool IsEmpty()
        {
            return nodes.Count == 0;
        }
        
        public void AddNode(T id)
        {
            nodes.AddLast(new GraphNode<T>(id));
        }

        public bool Contains(T id)
        {
            foreach(GraphNode<T> node in nodes)
            {
                if (node.ID.CompareTo(id) == 0) return true;
            }
            return false;
        }

        public GraphNode<T> GetNodeByID(T id)
        {
            foreach(GraphNode<T> node in nodes)
            {
                if (node.ID.CompareTo(id) == 0)
                {
                    return node;
                }
            }
            return null;
        }
        public void AddEdge(T from, T to)
        {
            GraphNode<T> n1 = GetNodeByID(from);
            GraphNode<T> n2 = GetNodeByID(to);


            if (n1 != null & n2 != null)
            {
                n1.AddEdge(n2);
            }
            else
                Console.WriteLine("Node/s not found in the graph. Cannot add the edge");

        }
        public bool IsAdjacent(GraphNode<T> from, GraphNode<T> to)
        {
            //does the 'from' node have an edge connection stored with the ID matching the 'to' node 
            foreach (GraphNode<T> n in nodes)
            {
                if(n.ID.CompareTo(from.ID) == 0)
                {
                    return from.AdjList.Contains(to.ID);
                }
            }

            return false;
        }

        public int NumNodes()
        {
            int counter = 0;
            foreach(GraphNode<T> node in nodes)
            {
                counter++;
            }
            return counter;
        }
        public int NumEdges()
        {
            //less efficienct (O(n) vs O(1)) than having a variable that increments every time a connection is added, but doesn't overlook the scenario where someone adds a connection directly to a node using the public getter function)
            int counter = 0;
            foreach(GraphNode<T> node in nodes)
            {
                counter += node.AdjList.Count;
            }
            return counter;
        }

        public List<T> Outgoing(int k)
            //returns a list of node IDs, which have k number of outgoing connections from themselves
        {
            List<T> list = new List<T>();
            foreach(GraphNode<T> node in nodes)
            {
                if (node.AdjList.Count == k)
                {
                    list.Add(node.ID);
                }
            }
            return list;
        }

        public List<T> Ingoing(int k)
        {
            //returns a list of node IDs, which have a k number of connections going into them from the nodes in the graph (itself included)
            List<T> list = new List<T>();
            Dictionary<T,int> dict = new Dictionary<T, int>();
            
            //populate the dictionary with default values
            foreach (GraphNode<T> node in nodes)
            {
                dict.Add(node.ID, 0);
            }

            //add the number of incoming connections for each node in the graph.
            foreach (GraphNode<T> node in nodes)
            {
                foreach(T t in node.AdjList)
                {
                    dict[t] += 1;
                }
                
            }
            
            //see if any incoming connections in the dictionary are equal to k.
            foreach(GraphNode<T> node in nodes)
            {
                if (dict[node.ID] == k)
                {
                    list.Add(node.ID);
                }
            }

            return list;
        }

        public List<T> LargestOutGoing()
        {
            List<T> list = new List<T>();
            int largest = 0;

            foreach(GraphNode<T> node in nodes)
            {
                if (largest < node.AdjList.Count())
                {
                    largest = node.AdjList.Count();
                }
            }

            foreach (GraphNode<T> node in nodes)
            {
                if (node.AdjList.Count == largest)
                {
                    list.Add(node.ID);
                }
            }
            return list;
        }

        public List<T> LargestInGoing()
        {
            List<T> list = new List<T>();
            Dictionary<T, int> dict = new Dictionary<T, int>();
            int largest = 0;

            //add the number of incoming connections for each node in the graph.
            foreach (GraphNode<T> node in nodes)
            {
                dict.Add(node.ID, 0);
            }

            //add the number of incoming connections for each node in the graph.
            foreach (GraphNode<T> node in nodes)
            {
                foreach (T t in node.AdjList)
                {
                    dict[t] += 1;
                }

            }

            //find the largest value of ingoing connections within the dictionary.
            foreach(GraphNode<T> node in nodes)
            {
                if(largest < dict[node.ID])
                {
                    largest = dict[node.ID];
                }
            }

            //add all nodes which match the largest number of ingoing connections.
            foreach (GraphNode<T> node in nodes)
            {
                if (dict[node.ID] == largest)
                {
                    list.Add(node.ID);
                }
            }

            return list;
        }
    }
}
