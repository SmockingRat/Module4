using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A");
            string A = Console.ReadLine();
            Console.WriteLine("Введите В");
            string B = Console.ReadLine();
            var Result = A != B;
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
