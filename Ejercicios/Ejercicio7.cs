using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Devuelve el producto de una lista de numeros
    /// </summary>
    class Ejercicio7
    {
        /*Escribir un método que acepte una lista de números 
         * y devuelva el producto de dichos números*/

        public void ProductoNumeros(List<int> numeros)
        {
            int resultado = 1;
            foreach(var numero in numeros)
            {
                resultado *= numero;
            }
            Console.WriteLine("El producto de los numeros es: {0}", resultado);
        }
    }
}
