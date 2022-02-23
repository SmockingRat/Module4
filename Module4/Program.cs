using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {

            (double Age, string Name, string Type, int NameCount) Pet;

            Console.WriteLine("Введите имя питомца");
            Pet.Name = Console.ReadLine();

            Console.WriteLine("Введите возраст питомца");
            Pet.Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Каким животным является ваш питомец");
            Pet.Type = Console.ReadLine();

            Pet.NameCount = 0;

            for (int i = 0; i < Pet.Name.Length; i++)
            {
                Pet.NameCount++;
            }

            Console.WriteLine("Имя питомца {0}", Pet.Name);
            Console.WriteLine("Возраст питомца {0}", Pet.Age);
            Console.WriteLine("Ваш питомец {0}", Pet.Type);
            Console.WriteLine("Длина имени вашего питомца {0}", Pet.NameCount);



            Console.ReadKey();
        }
    }
}
