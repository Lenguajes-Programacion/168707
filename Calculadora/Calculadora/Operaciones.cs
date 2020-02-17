using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Operaciones
    {
    }

    public static float Suma()
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
}
