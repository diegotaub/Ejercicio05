using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo c;
            do
            {
                c = Console.ReadKey();
            } while (c.Modifiers != ConsoleModifiers.Control || c.Key.ToString().ToUpper() != "F");
        }
    }
}
