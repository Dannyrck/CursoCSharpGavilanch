using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio16
    {
        /*16) Escribir un método que acepte una lista de strings 
         * y escriba en la consola el primer caracter de cada uno de los strings.
         */
         
        public void PrimerCaracter(List<string> cadenas)
        {
            foreach(string cadena in cadenas)
            {
                Console.Write(cadena.First<char>()+" ");
            }
        }
    }
}
