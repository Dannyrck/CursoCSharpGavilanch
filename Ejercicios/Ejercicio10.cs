using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Devuelve el numero de mayor valor en una lista
    /// </summary>
    class Ejercicio10
    {
        public void NumeroMayor(List<int> numeros)
        {
            int numeroMasGrande=0;
            foreach(int numero in numeros)
            {
                if (numero > numeroMasGrande)
                {
                    numeroMasGrande = numero;
                }
            }

            Console.WriteLine($"El numero mas grande de la lista es: {numeroMasGrande}");
        }
    }
}
