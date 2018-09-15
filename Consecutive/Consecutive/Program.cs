using System;

namespace Consecutive
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = int.Parse(Console.ReadLine());
            if (sum % 2 == 0)
            {

            }
            else
            {
                var start = (int)Math.Ceiling(sum / 2.0);
                for (int i = start - 1; i >= 0; i--)
                {

                }
            }
        }
    }
}
