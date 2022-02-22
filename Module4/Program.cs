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
            for(int i = YourName.Length - 1; i >= 0; i--)
            {
                Console.Write(YourName[i] + " ");
                
            }
            Console.WriteLine();


			Console.ReadKey();
        }
    }
}
