using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio15
    {
        /*15) Escribir un método que acepte una lista de números y 
         * devuelva una lista con los mismos números ordenados de mayor a menor. 
         * Ejemplo: Si ingresamos la lista {5,2,9,4}, 
         * entonces el método debe devolver la lista {9,5,4,2}*/

        public void MayoraMenor(List<int>numeros)
        {
            numeros.Sort();
            numeros.Reverse();
            foreach(int numero in numeros)
            {
                Console.Write(numero + " ");
            }
            
        }

    }
}
