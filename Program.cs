using System;

namespace gcd
{
    class Program
    {
        private static int gcd(int a, int b, int m)
        {
            if (a % m == 0 && b % m == 0)
                return m;
            else
                return gcd(a, b, m - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter two number:");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int m = Math.Min(n1, n2);
            int result = gcd(n1, n2, m);
            Console.WriteLine("greatest common divisor of {0} , {1} = {2}",n1,n2,result);



            Console.ReadKey();
        }

    }
}
