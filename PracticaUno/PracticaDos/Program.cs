using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos
{
    class Program

        //Proyecto Calculadora
        //Se espera recibir los argumentos valor1 (int) y valor 2(string) operador
        //valor3(int)
        //Responder resultados en (int)
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CalculAPP");
            Console.WriteLine("----------\n");
            bool close_app = false;
            int valor1 = 0;
            int valor2 = 0;
            float result = 0;
            while (!close_app) { }
            Console.WriteLine("Elige una opcion");
            Console.WriteLine("(+) Suma");
            Console.WriteLine("(-) Resta");
            Console.WriteLine("(*) Multiplicacion");
            Console.WriteLine("(/) Division");
            Console.WriteLine("e para salir");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "+":
                    Console.WriteLine("Captura el primer valor:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura el primer valor:");
                    valor2 = int.Parse(Console.ReadLine());
                    Console.WriteLine("El resultado es:", result = valor1 + valor2);
                    break;

                case "-":
                    Console.WriteLine("Captura el primer valor:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura el primer valor:");
                    valor2 = int.Parse(Console.ReadLine());

                    break;

                case "*":
                    Console.WriteLine("Captura el primer valor:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura el primer valor:");
                    valor2 = int.Parse(Console.ReadLine());
                    break;

                case "/":
                    Console.WriteLine("Captura el primer valor:");
                    valor1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Captura el primer valor:");
                    valor2 = int.Parse(Console.ReadLine());
                    break;


                default:
                    Console.WriteLine("Opción desconocida");
                    break;





            }

        }
        }

    }

    

