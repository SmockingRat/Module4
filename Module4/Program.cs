using System;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
			string[] favcolor = new string[6];

            for(int i=0; i<favcolor.Length; i++ )
            {
                Console.WriteLine("Введите свой любимый цвет {0}", i+1);
                favcolor[i] = Console.ReadLine();
            }

            foreach (var color in favcolor)
            {
                switch(color)
                {

                    case "cyan":
                        Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is cyan");
                        break;

                    case "green":
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is green");
                        break;

                    case "red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is red");
                        break;

                    case "yellow":
                        Console.BackgroundColor = ConsoleColor.Yellow;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is yellow");
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        Console.WriteLine("Your color is white");

                        break;
                
                
                }
            }

			Console.ReadKey();
        }
    }
}
