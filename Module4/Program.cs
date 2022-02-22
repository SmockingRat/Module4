using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] DArr = {{1,4,3,54,55,5},{23,55,5,5,66,45},{34,55,5,3,2,4} };

            for(int i =0; i < DArr.GetUpperBound(1)+1; i++)
            {
                for(int j = 0; j < DArr.GetUpperBound(0)+1; j++)
                {
                    Console.Write(DArr[j,i] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("Кол-во строк");
            Console.WriteLine(DArr.GetUpperBound(0)+1+" ");
            Console.WriteLine("Кол-во колонок");
            Console.WriteLine(DArr.GetUpperBound(1)+1+" ");
            Console.ReadKey();
        }
    }
}
