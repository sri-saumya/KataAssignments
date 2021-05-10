using System;
using System.Collections.Generic;
using System.Linq;

namespace Day1Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            FrequencyControl(new int[] { 20, 37, 20, 21 }, 1);
            FrequencyControl(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);
        }
        

        public static int[] FrequencyControl(int[] arr, int x)
        {
            var ans = new List<int>();
            foreach(var item in arr)
            {
                if(ans.Count(i => i== item) < x)
                {
                    ans.Add(item);
                }
                
            }
            ans.ForEach(i => Console.WriteLine(i.ToString()));
            return ans.ToArray();
        }
    }
}
