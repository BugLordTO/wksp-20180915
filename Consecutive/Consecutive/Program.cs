using System;
using System.Linq;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Input: ");
                var input = int.Parse(Console.ReadLine());

                var engine = new ConsecutiveEngine();
                var results = engine.Process(input);

                if (results.Count() > 0) Console.WriteLine(results.Select(x => x.ToString()).Aggregate((x, y) => $"{x},{y}"));
                else Console.WriteLine("No answer.");
            }
        }
    }
}
