using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Pedir dos numeros al usuario y decide cual es mayor
    /// </summary>
    class Ejercicio1
    {
        public void Ejercicio()
        {
            float a = 0;
            float b = 0;

            Console.WriteLine("Hola, ingresa el primer valor");
            try
            {
                a = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingresa el segundo valor");
                b = float.Parse(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error el valor ingresado no es numerico");
            }

            if (a > b)
            {
                Console.WriteLine("El numero {0}, es el mayor", a);
            }
            else if (b > a)
            {
                Console.WriteLine("El numero {0}, es mayor", b);
            }
            else if (a == b && b != 0)
            {
                Console.WriteLine("Los dos valores son iguales {0}", a);
            }
            Console.ReadLine();
        }
    }
}
