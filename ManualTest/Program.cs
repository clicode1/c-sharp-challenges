// See https://aka.ms/new-console-template for more information

using BIT.Algorithms.Challenges;
using BIT.Patterns.Singleton;
using CliCode.Challenge.Solutions.Arrays;
using ManualTest;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Starting Manual Test");
        Console.WriteLine("__________________________________________________________");

        FactoryRun.CreditCardTest();

        Console.WriteLine("__________________________________________________________");

        //      var paginate = LRU.PaginateExample(4, 10, new int[] { 1, 2, 3, 2, 5, 3, 4, 5, 8, 9});

        //      var str = "";
        //      foreach(var n in paginate.Item2)
        //{
        //          str += n.ToString() + ", ";
        //      }

        //      Console.WriteLine($"paginated faults: {paginate.Item1}. State: {str}");

        SolutionExample1_A.Main();

        Console.WriteLine("__________________________________________________________");
        Console.WriteLine("Ending Manual Test");

        Console.ReadLine();
    }
}