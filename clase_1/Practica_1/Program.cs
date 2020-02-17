using System;

namespace Practica_1
{
    class Program
    {
        //Variable de la clase.
        static string nombre = "Yuu";

        static void Main(string[] args)
        {
            if (nombre=args[0])
            {
                //Respondemos con el primer argumento.
                Console.WriteLine($"Hola {args[0]} {args[1]}");
            }

            else
            {
                Console.WriteLine("Incorrecto");
            }
            
            

        }
    }
}