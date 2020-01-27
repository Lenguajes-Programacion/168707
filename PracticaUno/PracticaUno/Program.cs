using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaUno
{
    class Program
    {
        static string nombre = "Vianney";
        static void Main(string[] args)
        {
            if (args[0].Length > 0 && args[0] == nombre)
            {


                Console.WriteLine($"Hello {args[0]} {args[1]}");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("User unauthorized");
            }
        }
    }
}
