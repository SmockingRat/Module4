using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 432;
            int B = 434;
            double X = 3.4444;
            double Y = 3.5;
            var Result = (A < B) || (X > Y);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
    }
}
