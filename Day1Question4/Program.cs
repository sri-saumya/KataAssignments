using System;
using System.Collections.Generic;
using System.Linq;
namespace Day1Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> i = new List<int> { 1, 4, 4, 4, 0, 4, 3, 3, 1 };
            List<int> o = new List<int> { 1, 12, 0, 4, 6, 1 };
            SumConsecutives(i);
            SumConsecutives(o);
        }

        public static List<int> SumConsecutives(List<int> s)
        {
            var arrAfterSum = new List<int>(); 
            int[] arr = s.ToArray();

            int sum = 0;
            int k = 0;
            for (int i = 0; i < arr.Length-1; i++)
            {
                if (k < arr.Length -1)
                {
                    sum = arr[k];
                    if (arr[k] == arr[k + 1])
                    {
                        sum += arr[k + 1];
                        k = k + 1;
                    }
                    
                }
                
                arrAfterSum.Add(sum);
            }
            arrAfterSum.ForEach(i => Console.WriteLine(i.ToString()));
            return arrAfterSum;
        }

    }
}
