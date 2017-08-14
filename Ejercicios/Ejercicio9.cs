using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Promedio de una lista de numeros
    /// </summary>
    class Ejercicio9
    {
        //9) Escribir un método que acepte una lista de números y devuelva su promedio.

        
        public void CalculaPromedio(List<float> numeros)
        {
            float resultado=0;
            foreach (float numero in numeros)
            {
                resultado += numero;
            }
            resultado = resultado / numeros.Count();
            Console.WriteLine($"El promedio de la lista es: {resultado}");
        }
    }
}
