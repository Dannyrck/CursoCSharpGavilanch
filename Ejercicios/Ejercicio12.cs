using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Fizzbuzz
    /// </summary>
    class Ejercicio12
    {
        /*12) Escribir un fizzbuzz: Iterar los números del uno al cien,
         * y cuando llegues a un número que sea múltiplo de 3 (el 6 por ejemplo), 
         * escribir en la consola "Fizz", cuando llegues a un número que sea múltiplo 
         * de 5 (el 20 por ejemplo) escribir en la consola "Buzz", 
         * cuando llegues a un número que sea múltiplo de 3 y 5 (el 30 por ejemplo) 
         * escribir FizzBuzz en la consola.
         */

        public void Fizzbuzz()
        {
            for (int i = 1; i < 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine($"{i} FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine($"{i} Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine($"{i} Buzz");
                }
            }
        }
    }
}
