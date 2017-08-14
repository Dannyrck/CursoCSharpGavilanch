using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio14
    {

        //14) Escribir un método que acepte una lista de números y 
        //devuelva una lista con los mismos números ordenados de menor a mayor. 
        //Ejemplo: Si ingresamos la lista {5,2,9,4}, entonces el método debe devolver la lista {2,4,5,9}

        public void MayoraMenor(List<int> numeros)
        {
            numeros.Sort();
            foreach(int numero in numeros)
            {
                Console.Write(numero + " ");
            }
        }
    }
}
