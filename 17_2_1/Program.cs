﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double origAmount = 0.63;
            double toChange = origAmount;
            double remainAmount = 0.0;
            int[] coins = new int[4];
            MakeChange(origAmount, remainAmount, coins);
            Console.WriteLine("The best way to change " + toChange + " cents is: ");
            ShowChange(coins);

            Console.ReadKey();
        }

        static void MakeChange(double origAmount, double remainAmount, int[] coins)
        {
            if (origAmount % 0.25 < origAmount)
            {
                coins[3] = (int)(origAmount / 0.25);
                remainAmount = origAmount % 0.25;
                origAmount = remainAmount;
            }

            if (origAmount % 0.1 < origAmount)
            {
                coins[2] = (int)(origAmount / 0.1);
                remainAmount = origAmount % 0.1;
                origAmount = remainAmount;
            }

            if (origAmount % 0.05 < origAmount)
            {
                coins[1] = (int)(origAmount / 0.05);
                remainAmount = origAmount % 0.05;
                origAmount = remainAmount;
            }

            if (origAmount % 0.01 < origAmount)
            {
                coins[0] = (int)(origAmount / 0.01);
                remainAmount = origAmount % 0.01;
            }
        }

        static void ShowChange(int[] arr)
        {
            if (arr[3] > 0)
                Console.WriteLine("Number of quarters: " + arr[3]);
            if (arr[2] > 0)
                Console.WriteLine("Number of quarters: " + arr[2]);
            if (arr[1] > 0)
                Console.WriteLine("Number of quarters: " + arr[1]);
            if (arr[0] > 0)
                Console.WriteLine("Number of quarters: " + arr[0]);
        }
    }
}
