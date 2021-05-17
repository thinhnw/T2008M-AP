using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n;
            try
            {
                Console.Write("n = ");
                n = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            int f0 = 0;
            int f1 = 1;
            
            for (;;)
            {
                if (f0 + f1 >= n) break;
                f1 += f0;
                f0 = f1 - f0;
            }
            
            Console.WriteLine(f1);
        }

        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i <= n / 2; ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}