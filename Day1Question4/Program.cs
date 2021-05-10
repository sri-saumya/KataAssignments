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
            SumConsecutives(i);
        
        }

        public static List<int> SumConsecutives(List<int> s)
        {
            var arrAfterSum = new List<int>(); 
            int[] ListToArray = s.ToArray();

            for (int i = 0; i < ListToArray.Length; i++)
            {
                int count = 0;
                int sum = ListToArray[i];
                
                for (int j = i + 1; j < ListToArray.Length; j++)
                {
                    if (ListToArray[j] == ListToArray[i])
                    {
                        sum += ListToArray[j];
                        count = count + 1;
                    }
                    else
                    {
                        break;
                    }
                }
                arrAfterSum.Add(sum);
                i =i + count;
            }
       
            //arrAfterSum.ForEach(i => Console.WriteLine(i.ToString()));
            return arrAfterSum;
        }

    }
}
