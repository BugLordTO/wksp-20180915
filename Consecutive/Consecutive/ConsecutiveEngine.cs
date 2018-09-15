using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consecutive
{
    public class ConsecutiveEngine
    {
        public int[] Process(int expectedSum)
        {
            var members = Enumerable.Empty<int>().ToList();
            var hasAnswer = false;
            for (int i = 2; i < expectedSum; i++)
            {
                var start = (expectedSum + 1) / i;
                for (int j = 1; j <= start; j++)
                {
                    members = Enumerable.Range(j, i).ToList();
                    var sum = members.Sum();
                    if (sum == expectedSum)
                    {
                        hasAnswer = true;
                        break;
                    }
                    else if (sum > expectedSum)
                        break;
                }
                if (hasAnswer) break;
            }
            if (hasAnswer) return members.ToArray();
            return new int[0];
        }
    }
}
