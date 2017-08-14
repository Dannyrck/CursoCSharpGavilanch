using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio13
    {
        /*13) Escribir un método que acepte una lista con números 
         * y devuelva dicha lista en orden invertido
         *Ejemplo: Si ingresamos la lista {4,6,49}, 
         * entonces el método debe devolver la lista {49,6,4}
         */

        public void Reverse(List<int> numeros)
        {
            numeros.Reverse();
            foreach(int numero in numeros)
            {
                Console.Write($"{numero}, ");
                
            }

            
        }

    }
}
