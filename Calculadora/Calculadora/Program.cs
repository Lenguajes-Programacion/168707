using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos
{
    class Program

    {
        static void Main(string[] args)
        {
            Console.WriteLine("CalculAPP");
            Console.WriteLine("----------\n");
            bool close_app = false; 
            public int valor1 = 0;
            public int valor2 = 0;
            public float result = 0;
            public bool reut = false;
            {
                while (!close_app)
                {
                    Console.WriteLine("Elige una opcion escribiendo el numero");
                    Console.WriteLine("1.- Suma");
                    Console.WriteLine("2.- Resta");
                    Console.WriteLine("3.- Multiplicacion");
                    Console.WriteLine("4.- Division");
                    Console.WriteLine("5.- para reutilizar el resultado anterior");
                    Console.WriteLine("6.-  para salir");
                    string selec = Console.ReadLine();


                    switch (selec)
                    {
                        case "1":
                            Suma();
                            break;

                        case "2":
                            Resta();
                            break;

                        case "3":
                            Multiplicacion();
                            break;

                        case "4":
                            Division();
                            break;

                        case "5":
                            reut = true;
                            break;



                    }

                }



            }
            float Suma()
            {
                if (reut == false)
                {
                    Console.WriteLine("Ingresa el primer digito");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo digito");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 + valor2;
                    reut = true;

                }

                else
                {
                    Console.WriteLine("Ingresa el nuevo numero");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 + result;
                }

                Console.WriteLine("El resultado es:" + result);
                return result;
                

            }

            float Resta()
            {
                if (reut == false)
                {
                    Console.WriteLine("Ingresa el primer digito");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo digito");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 - valor2;
                    reut = true;

                }

                else
                {
                    Console.WriteLine("Ingresa el nuevo numero");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 - result;
                }

                Console.WriteLine("El resultado es:" + result);
                return result;


            }

            float Multiplicacion()
            {
                if (reut == false)
                {
                    Console.WriteLine("Ingresa el primer digito");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo digito");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 * valor2;
                    reut = true;

                }

                else
                {
                    Console.WriteLine("Ingresa el nuevo numero");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 * result;
                }

                Console.WriteLine("El resultado es:" + result);
                return result;


            }

            float Division()
            {
                if (reut == false)
                {
                    Console.WriteLine("Ingresa el primer digito");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa el segundo digito");
                    valor2 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 / valor2;
                    reut = true;

                }

                else
                {
                    Console.WriteLine("Ingresa el nuevo numero");
                    valor1 = Convert.ToInt32(Console.ReadLine());
                    result = valor1 / result;
                }

                Console.WriteLine("El resultado es:" + result);
                return result;


            }

        }

    }
}
