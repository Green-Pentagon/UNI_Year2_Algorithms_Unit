using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Work
{
    internal class Program
    {
        static void TestGraph()
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
            myGraph.AddEdge('A', 'B', 1.0f);
            myGraph.AddEdge('A', 'C', 0.34f);
            myGraph.AddEdge('B', 'C', 0.62f);
            myGraph.AddEdge('D', 'A', 2.1f);
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


            Console.WriteLine("Is node {0} adjacent from node {1}? Answer: {2}",
                 myGraph.GetNodeByID('B').ID,
                 myGraph.GetNodeByID('C').ID,
                 myGraph.IsAdjacent(myGraph.GetNodeByID('C'), myGraph.GetNodeByID('B')));

            Console.WriteLine("Is node {0} adjacent from node {1}? Answer: {2}",
                 myGraph.GetNodeByID('E').ID,
                 myGraph.GetNodeByID('D').ID,
                 myGraph.IsAdjacent(myGraph.GetNodeByID('D'), myGraph.GetNodeByID('E')));

            //rare case scenario where the harder way of counting edges in the graph (not using an incrementing variable) works.
            myGraph.GetNodeByID('A').AddEdge(myGraph.GetNodeByID('A'));

            Console.WriteLine("Number of Nodes: " + myGraph.NumNodes() + "\nNumber of Edges: " + myGraph.NumEdges());

            myGraph.Outgoing(2);
            myGraph.Ingoing(2);

            myGraph.LargestOutGoing();
            myGraph.LargestInGoing();

            Console.WriteLine("\n=-=-=-=-=-=\n\nThe Average connectivity is: " + myGraph.AvgConnectivity());
            Console.WriteLine("Degree of Centrality of node {0} is equal to {1}",
                myGraph.GetNodeByID('A').ID,
                myGraph.DegreeCentrality('A'));

            Console.WriteLine("Degree of Centrality of node {0} is equal to {1}",
                myGraph.GetNodeByID('B').ID,
                myGraph.DegreeCentrality('B'));

            Console.WriteLine("\nDegree Centralities of all nodes in the Graph:\n---\n" + myGraph.DegreeCentralities() + "---");


            Console.WriteLine("Lowest Edge from node {0} connects to {1}",
                myGraph.GetNodeByID('D').ID,
                myGraph.LowestEdge('D'));

            Console.WriteLine("Lowest Edge from node {0} connects to {1}",
                myGraph.GetNodeByID('C').ID,
                myGraph.LowestEdge('C'));

            Console.Write("List of node IDs with ingoing edges into node {0}: |", myGraph.GetNodeByID('A').ID);
            List<char> templist = myGraph.Ingoing('A');
            foreach(char c in templist)
            {
                Console.Write(c + "|");
            }
            Console.WriteLine();
            Console.WriteLine("Sum of all edge weights in the graph: " + myGraph.SumWeight());

            Console.WriteLine("REMOVING NODE D");
            myGraph.RemoveNode('D');

            Console.WriteLine("ATTEMPTING 2ND REMOVE OF NODE D");
            myGraph.RemoveNode('D');

            Console.Write("List of node IDs with ingoing edges into node {0}: |", myGraph.GetNodeByID('A').ID);
            templist = myGraph.Ingoing('A');
            foreach (char c in templist)
            {
                Console.Write(c + "|");
            }
            Console.WriteLine();
            Console.WriteLine("\nDegree Centralities of all nodes in the Graph:\n---\n" + myGraph.DegreeCentralities() + "---");

            Console.WriteLine("Sum of all edge weights in the graph: " + myGraph.SumWeight());

        }



        static void Week10Ex6()
        {
            Graph<string> myGraph = new Graph<string>();

            string[] airports = { "WAL" , "MAN", "JFK", "LON", "LAX", "HOU", "PAR" , "NAP", "TOK", "SYD", "DAK", "CAP", "PAN", "RIO" };
            foreach(string airport in airports)
            {
                myGraph.AddNode(airport);
            }

            //Adding Edges
            myGraph.AddEdge("MAN", "JFK", 130.0f);
            myGraph.AddEdge("MAN", "LON", 100.0f);
            
            myGraph.AddEdge("JFK", "LAX", 75.0f);
            myGraph.AddEdge("JFK", "HOU", 50.0f);

            myGraph.AddEdge("LON", "PAR", 70.0f);
            myGraph.AddEdge("LON", "NAP", 150.0f);

            myGraph.AddEdge("PAR", "NAP", 50.0f);
            myGraph.AddEdge("PAR", "TOK", 200.0f);

            myGraph.AddEdge("NAP", "SYD", 175.0f);
            myGraph.AddEdge("NAP", "DAK", 120.0f);

            myGraph.AddEdge("WAL", "MAN", 50.0f);
            myGraph.AddEdge("TOK", "LAX", 150.0f);
            myGraph.AddEdge("DAK", "CAP", 100.0f);
            myGraph.AddEdge("HOU", "PAN", 35.0f);
            myGraph.AddEdge("PAN", "RIO", 200.0f);

            //Tasks
            Console.WriteLine("\n\n--Exercise 6 for week 10--");

            Console.WriteLine("Number of nodes: " + myGraph.NumNodes() + "\nNumber of Edges: " + myGraph.NumEdges());
            Console.WriteLine("Average number of connections in network:" + myGraph.AvgConnectivity());
            
            //Most in-going and out-going connections
            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
            List<string> temp = myGraph.LargestInGoing();
            Console.Write("Most inter-connected airport:\nMost in-going connections = |");
            foreach (string item in temp)
            {
                Console.Write(item + "|");
            }

            temp.Clear();
            temp = myGraph.LargestOutGoing();
            Console.Write("\nMost out-going connections = |");
            foreach (string item in temp)
            {
                Console.Write(item + "|");
            }
            Console.WriteLine();
            //=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

            List<string> cheapest = new List<string>();
            float lowestPrice = -1.0f;
            float? tempWeight = null;

            //figure out the lowest weight
            foreach(string airport in airports)
            {
                tempWeight = myGraph.LowestEdgeWeight(airport);
                if (tempWeight.HasValue)
                {
                    if (lowestPrice == -1.0f || lowestPrice > tempWeight)
                    {
                        lowestPrice = (float)tempWeight;
                    }
                }
                
            }

            //figure out which airport has the lowest weight (there can be more than one!)
            foreach (string airport in airports)
            {
                if (myGraph.LowestEdgeWeight(airport) == lowestPrice)
                {
                    cheapest.Add(airport);
                }
            }
            Console.Write("Airport(s) offering the cheapest flight of £" + lowestPrice + " = |");
            foreach(string airport in cheapest)
            {
                Console.Write(airport + "|");
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            TestGraph();
            //Week10Ex6();


            Console.ReadKey();
        }
    }
}
