using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arr = new int[] {12, 33, 54, -34, -6, 6, -45, -65, -1, 0, -55 };

            int Accum = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < 0)
                {
                    Accum += 1;
                }
            }

            Console.WriteLine(Accum);

            Console.ReadKey();
        }
    }
}
