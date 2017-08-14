using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Compara dos cadenas y devuelve cual es mas grande
    /// </summary>
    class Ejercicio3
    {
        string cadena1;
        string cadena2;

        public void EvaluarCadenas()
        {
            Console.WriteLine("Ingresa la primer cadena");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Ingresa la segunda cadena");
            cadena2 = Console.ReadLine();

            if (cadena1.Length > cadena2.Length)
            {
                Console.WriteLine($"la primer cadena es mayor con {cadena1.Length} caracteres");
                Console.WriteLine(cadena1);
            }
            else if (cadena1.Length == cadena2.Length)
            {
                Console.WriteLine($"Las dos cadenas tienen {cadena1.Length} caracteres");
                Console.WriteLine(cadena1);
            }
            else
            {
                Console.WriteLine($"La cadena 2 es mayor con {cadena2.Length} caracteres");
                Console.WriteLine(cadena2);
            }
        }       
    }
}
