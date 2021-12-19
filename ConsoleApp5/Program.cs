using System;
using System.Collections.Generic;
using ConsoleApp5.DynamicProgramming;
using ConsoleApp5.Graphs;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var node1 = new GraphSearch.Node(5);
            //var node2 = new GraphSearch.Node(4);
            //var node3 = new GraphSearch.Node(10);

            //var node4 = new GraphSearch.Node(3, new List<GraphSearch.Node> {node2});
            //var node5 = new GraphSearch.Node(9, new List<GraphSearch.Node> { node3 });
            //var node6 = new GraphSearch.Node(7, new List<GraphSearch.Node> { node5 });
            //var node7 = new GraphSearch.Node(1, new List<GraphSearch.Node> { node1, node4, node6 });

            //var graphSearch = new GraphSearch();
            //graphSearch.BreadthFirst(node7);

            //var fib = new Fibonacci();
            //Console.WriteLine(fib.GetFib(20));

            //var traveler = new GridTraveler();
            //Console.WriteLine(traveler.CalculatePaths(10, 10));

            //var canSum = new CanSum();
            //Console.WriteLine(canSum.IsSumPossible(20, new int[] {3, 3}));

            var canConstruct = new CanConstruct();

            Console.WriteLine(canConstruct.CanConstruct2("ababab", new string[]{"ba"}));

            Console.ReadLine();
        }
    }
}
