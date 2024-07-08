//OPTIMISE THE PROGRAM TO USE A DICTIONARY INSTEAD OF TWO LINKED LISTS, FOR USE IN THE ASSESSED EXERCISES!
//good luck with it if you decide to refactor the code.

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
        LinkedList<float> weightList;
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public GraphNode(T id)
        {
            this.id = id;
            adjList = new LinkedList<T>();
            weightList = new LinkedList<float>();
        }
        public T ID { get { return id; } }
        public LinkedList<T> AdjList { get { return adjList; } }
        public LinkedList<float> WeightList { get { return weightList; } }
        //=-=-=-=-=-=-=-=-=-=-==-=-=-=-=-=-=-=-=
        public void AddEdge(GraphNode<T> graphNode)
        {
            adjList.AddLast(graphNode.ID);
            weightList.AddLast(1.0f);//default weight value
        }
        public void AddEdge(GraphNode<T> graphNode, float weight)
        {
            adjList.AddLast(graphNode.ID);
            weightList.AddLast(weight);
        }
    }
}