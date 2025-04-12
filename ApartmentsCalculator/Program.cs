using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentsCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = 30;
            int M = 10;
            int X = 10000;

            int result = CalculateRevenue(N, M, X);
            Console.WriteLine($"Общая выручка: {result}");
            Console.ReadKey();
        }

        public static int CalculateRevenue(int N, int M, int X)
        {
            int totalRevenue = 0;
            int currentPrice = X;

            for (int i = 1; i <= N; i++)
            {
                totalRevenue += currentPrice;

                if (i % M == 0)
                {
                    currentPrice += 1000;
                }
            }

            return totalRevenue;
        }


    }
}

