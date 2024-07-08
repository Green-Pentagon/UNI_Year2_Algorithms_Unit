using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define a graph with ID of nodes as 'char'
            Graph<char> myGraph = new Graph<char>();

            // add nodes in the graph
            myGraph.AddNode('A');
            myGraph.AddNode('B');
            myGraph.AddNode('C');
            myGraph.AddNode('D');
            myGraph.AddNode('E');

            // add connections between the nodes. these are direct edges
            myGraph.AddEdge('A', 'B');
            myGraph.AddEdge('A', 'C');
            myGraph.AddEdge('B', 'C');
            myGraph.AddEdge('D', 'A');
            myGraph.AddEdge('D', 'E');

            myGraph.AddEdge('A', 'E');

            Console.WriteLine("Is myGraph empty? Answer: {0}", myGraph.IsEmpty());


            // is there an edge from 'A' to 'B' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
                myGraph.GetNodeByID('A').ID, myGraph.GetNodeByID('B').ID,
                myGraph.GetNodeByID('A').AdjList.Contains('B'));


            // is there an edge from 'B' to 'A' ?

            Console.WriteLine("Is there an edge from {0} to {1}? {2}",
                myGraph.GetNodeByID('B').ID, myGraph.GetNodeByID('A').ID,
                myGraph.GetNodeByID('B').AdjList.Contains('A'));


            Console.WriteLine("Is node {0} adjacent from node {1} ? Answer: {2}",
                 myGraph.GetNodeByID('B').ID,
                 myGraph.GetNodeByID('C').ID,
                 myGraph.IsAdjacent(myGraph.GetNodeByID('C'), myGraph.GetNodeByID('B')));

            Console.WriteLine("Is node {0} adjacent from node {1} ? Answer: {2}",
                 myGraph.GetNodeByID('E').ID,
                 myGraph.GetNodeByID('D').ID,
                 myGraph.IsAdjacent(myGraph.GetNodeByID('D'), myGraph.GetNodeByID('E')));

            myGraph.GetNodeByID('A').AddEdge(myGraph.GetNodeByID('A'));//rare case scenario where the harder way of counting edges in the graph (not using an incrementing variable) works.

            Console.WriteLine("Number of Nodes: " + myGraph.NumNodes() + "\nNumber of Edges: " + myGraph.NumEdges());

            myGraph.Outgoing(2);
            myGraph.Ingoing(2);

            myGraph.LargestOutGoing();
            myGraph.LargestInGoing();

            Console.ReadKey();

        }
    }
}
