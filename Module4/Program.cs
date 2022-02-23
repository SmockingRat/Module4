using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            var anketa = (Name: "George", Age: 19, Pet: "Dog and Cat" );

            Console.WriteLine(anketa.Name);
            Console.WriteLine(anketa.Age);
            Console.WriteLine(anketa.Pet);

            Console.ReadKey();
        }
    }
}
