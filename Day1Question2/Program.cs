using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1Question2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 18 }, new int[] { 4, 5 }, new int[] { 12, 60 }});
            SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 15, 7 }, new int[] { 4, 5 }, new int[] { 19, 60 } });
            SumDifferencesBetweenProductsAndLCMs(new int[][] { new int[] { 20, 50 }, new int[] { 10, 10 }, new int[] { 50, 20 } });
        }


        //Function for Calculating LCM
        public static int LCMOfTwoNumbers(int n1, int n2)
        {
            int max = (n1 > n2) ? n1 : n2;
            int i, lcm = 1;
            for (i = max; ; i += max)
            {
                if (i % n1 == 0 && i % n2 == 0)
                {
                    lcm = i;
                    return lcm;
                }
            }
        }

        public static int SumDifferencesBetweenProductsAndLCMs(int[][] pairs)
        {
            int p = pairs.Length;
            int pp = pairs[0].Length;

            var arrProduct = new List<int>();
            var arrLCM = new List<int>();

            for (int i = 0; i < p; i++)
            {
                int pairProduct = 1;
                int pairLCM = 1;
                int[] L = new int[2];
                for (int j = 0; j < pp ; j++)
                {
                    
                    pairProduct *= (pairs[i][j]);
                    L[j] = pairs[i][j];
                    
                }

                int num1 = L[0];
                int num2 = L[1];
                pairLCM= LCMOfTwoNumbers(num1,num2);
                arrLCM.Add(pairLCM);
                arrProduct.Add(pairProduct);
                Console.WriteLine("\n");
  
            }
            //arrLCM.ForEach(i => Console.WriteLine(i.ToString()));
            //arrProduct.ForEach(i => Console.WriteLine(i.ToString()));

            int summation = 0;
            for(int c = 0; c < p; c++)
            {
                summation += (arrProduct[c] - arrLCM[c]);
            }
            Console.WriteLine(summation);
            return summation;
        }
    }

}

