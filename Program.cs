using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1, 2, 5, 7, 19, 6, 1, 33 };

            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("[{0}] ", a[i]);
            }
            
            Console.ReadKey();
        }
    }
}
