using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Calcula el factorial de un numero
    /// </summary>
    class Ejercicio8
    {
        /*Escribir un método que acepte un int y te devuelva el factorial
         * de dicho número. Nota: El factorial de 3 es 3*2*1, 
         * el factorial de 5 es 5*4*3*2*1, etc*/

        public void Factorial (int numero)
        {
            double resultado= numero;
            double j = numero;
            while (j > 0)
            {
                j--;
                if(j>0)
                 resultado *= j ;
                
            }
            Console.WriteLine("El factorial de numero {0} es: {1}",numero,resultado);
        }
    }
}
