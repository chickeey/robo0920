using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo0920
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Milyen szép név az hogy {nev}");
            Console.WriteLine("Szeretsz programozni?");
            var valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("Akkor mi nagyon jó barátok leszünk :)");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Szevasz :c");
            }
            Console.WriteLine("Tessék 100 csillag c: <3");
            for (int i = 0; i < 100; i++)
            {
                Console.SetCursorPosition(rnd.Next(Console.WindowWidth), rnd.Next(Console.WindowHeight));
                Console.ForegroundColor = (ConsoleColor)rnd.Next(1, 16);
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}
