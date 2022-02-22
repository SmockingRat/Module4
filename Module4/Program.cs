using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arr = new int[] {800, 1, 34, 45, 55, 4, 56, 7, 3, 99, 312};

        
            int Accum=0;
            

            for(int i = 0; i < Arr.Length; i++)
            {
                
                Accum += Arr[i];
            }

            Console.WriteLine(Accum);

            Console.ReadKey();
        }
    }
}
