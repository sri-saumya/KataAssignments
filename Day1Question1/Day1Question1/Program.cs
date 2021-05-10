using System;

namespace Day1Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NbrOfLaps(4, 6));
            Console.WriteLine(NbrOfLaps(5, 5));
            Console.WriteLine(NbrOfLaps(5, 3));

        }
        public static Tuple<int, int> NbrOfLaps(int n1, int n2)
        {
            int max = (n1 > n2) ? n1 : n2;
            int i, lcm = 1;
            for (i = max; ; i += max)
            {
                if (i % n1 == 0 && i % n2 == 0)
                {
                    lcm = i;
                    break;
                }
            }
            int bob = lcm / n1;
            int charles = lcm / n2;
            return new Tuple<int, int>(bob, charles);
        }
    }
}

