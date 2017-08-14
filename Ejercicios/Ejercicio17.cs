using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Escribe el ultimo caracter de una lista de cadenas
    /// </summary>
    class Ejercicio17
    {
        /*17) Escribir un método que acepte una lista de strings 
         * y escriba en la consola el último caracter 
         * de cada uno de los strings
         */

        public void UltimoCaracter(List<string> cadenas)
        {
            foreach(string cadena in cadenas)
            {
                Console.Write(cadena.Last<char>()+" ");
            }
        }
    }
}
