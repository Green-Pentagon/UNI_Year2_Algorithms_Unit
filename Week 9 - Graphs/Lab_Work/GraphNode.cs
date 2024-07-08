using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    internal class GraphNode<T> where T : IComparable
    {
        T id;
        LinkedList<T> adjList;
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public GraphNode(T id) { 
            this.id = id;
            adjList = new LinkedList<T>();
        }
        public T ID { get { return id; } }
        public LinkedList<T> AdjList { get {  return adjList; } }
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public void AddEdge(GraphNode<T> graphNode)
        {
            adjList.AddLast(graphNode.ID);
        }
    }
}
