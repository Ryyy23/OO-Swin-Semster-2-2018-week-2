using System;
using System.Collections.Generic;
using System.Linq;

namespace fibprime
{
    class Program
    {
        

        public static void Main()
        {

            List<int> PrimeFib = new List<int>();
            int n = 0;
            while (n <= 8)
            {
                for (int i = 0; i < 1000000; i++)
                    if (IsPrime(i) && IsFibonacci(i))
                    {
                        PrimeFib.Add(i);
                        Console.WriteLine(i);
                        n++;
                        
                    }




                bool IsPrime(int x)
                {
                    if (x <= 1) return false;

                    for (int i = 2; i <= x / 2; i++)
                    {
                        if ((x % i) == 0)
                        {
                            return false;
                        }
                    }

                    return true;
                }

                bool IsFibonacci(int x)
                {
                    if (x == 1) return true;
                    int first = 1;
                    int second = 1;
                    int third = 2;

                    while (third <= x)
                    {
                        if (third == x) return true;
                        first = second;
                        second = third;
                        third = first + second;
                    }

                    return false;
                }
            }

                int sum = PrimeFib.Sum();
            Console.WriteLine("sum of FibPrime:" + sum);



        }
    }
}
