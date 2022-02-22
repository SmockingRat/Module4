using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arr = new int[] {800, 1, 34, 45, 55, 4, 56, 7, 3, 99, 312};

        
            int Accum = 0;

            for(int i = 0; i < Arr.Length; i++)
            {
                for(int j = 0; j < Arr.Length - 1; j++)
                {
                    if (Arr[j] > Arr[j+1])
                    {
                        Accum = Arr[j+1];
                        Arr[j+1] = Arr[j];
                        Arr[j] = Accum;
                    }
                }
            }

            foreach(int Num in Arr)
            {
                Console.Write(Num + " ");
            }

            Console.ReadKey();
        }
    }
}
