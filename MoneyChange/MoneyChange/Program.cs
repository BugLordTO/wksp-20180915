using System;
using System.Linq;

namespace MoneyChange
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Change: ");
            var change = double.Parse(Console.ReadLine());

            var engine = new MoneyChangeEngine();
            var results = engine.Calculate2(change);

            if (results[0] >= 0) Console.WriteLine($"thousand = {results[0]}");
            if (results[1] >= 0) Console.WriteLine($"fiveHundred = {results[2]}");
            if (results[2] >= 0) Console.WriteLine($"hundred = {results[3]}");
            if (results[3] >= 0) Console.WriteLine($"fifty = {results[4]}");
            if (results[4] >= 0) Console.WriteLine($"twenty = {results[5]}");
            if (results[5] >= 0) Console.WriteLine($"ten = {results[6]}");
            if (results[6] >= 0) Console.WriteLine($"five = {results[7]}");
            if (results[7] >= 0) Console.WriteLine($"bath = {results[8]}");
        }
    }
}
