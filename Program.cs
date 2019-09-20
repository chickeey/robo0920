using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace robo0920
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia, hogy hívnak?");
            var nev = Console.ReadLine();
            Console.WriteLine($"Milyen szép név az hogy {nev}");
            Console.WriteLine("Szeretsz programozni?");
            var valasz = Console.ReadLine();
            if (valasz.ToLower() == "igen")
            {
                Console.WriteLine("akkor mi nagyon jó barátok leszünk :)");
            }
            else
            {
                Console.WriteLine(":(");
                Console.WriteLine("Szevasz :c");
            }
            Console.ReadKey();
        }
    }
}
