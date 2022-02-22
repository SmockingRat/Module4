using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите своё имя");

            string YourName = Console.ReadLine();

            Console.WriteLine("Ваше имя по символам");
            foreach(var ch in YourName)
            {
                Console.Write(ch + " ");
                
            }
            Console.WriteLine();

            Console.WriteLine("Последняя буква вашего имени \n{0}", YourName[YourName.Length - 1 ]);

			Console.ReadKey();
        }
    }
}
