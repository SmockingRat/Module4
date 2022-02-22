using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] Arr = { { 12, 33, 54, -34, -6, 6, -45, -65, -1, 0, -55 }, {34, -65, -45, 34, -44, 2, -5, 6, -3, 7, 4 } };

            int Accum = 0;

            for (int j = 0; j < Arr.GetUpperBound(0)+1; j++)
            {
                for (int i = 0; i < Arr.GetUpperBound(1) + 1; i++)
                {
                    if (Arr[j, i] > 0)
                    {
                        Accum += 1;
                    }
                }
            }
            Console.WriteLine(Accum);

            Console.ReadKey();
        }
    }
}
