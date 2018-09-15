using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyChange
{
    public class MoneyChangeEngine
    {
        public double Calculate1(double input, double change)
        {
            return input - change;
        }

        public int[] Calculate2(double change)
        {
            var results = new int[8];
            var remain = change;

            if (remain >= 1000)
            {
                results[0] = (int)(remain / 1000);
                remain -= results[0] * 1000;
            }

            if (remain >= 500)
            {
                results[1] = (int)(remain / 500);
                remain -= results[1] * 500;
            }

            if (remain >= 100)
            {
                results[2] = (int)(remain / 100);
                remain -= results[2] * 100;
            }

            if (remain >= 50)
            {
                results[3] = (int)(remain / 50);
                remain -= results[3] * 50;
            }

            if (remain >= 20)
            {
                results[4] = (int)(remain / 20);
                remain -= results[4] * 20;
            }

            if (remain >= 10)
            {
                results[5] = (int)(remain / 10);
                remain -= results[5] * 10;
            }

            if (remain >= 5)
            {
                results[6] = (int)(remain / 5);
                remain -= results[6] * 5;
            }

            results[7] = (int)remain;

            return results;
        }
    }
}
