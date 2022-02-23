using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            (int Age, string Name, string Pet) Anketa;

            Console.WriteLine("Введите ваше имя");
            Anketa.Name = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            Anketa.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Какие у вас есть питомцы?");
            Anketa.Pet = Console.ReadLine();

            Console.WriteLine("Ваше имя {0}", Anketa.Name);
            Console.WriteLine("Ваш возраст {0}", Anketa.Age);
            Console.WriteLine("Ваши питомцы {0}", Anketa.Pet);

            Console.ReadKey();
        }
    }
}
