using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Escribe los numeros de dos en dos hasta el 100
    /// </summary>
    class Ejercicio5
    {
        //Utilizando un iterador escribir en pantalla los números del 1 al 100 de dos en dos.

        public void Iteracion()
        {
            //for(int i = 0; i <= 100; i=i+2)
            //{
            //    Console.WriteLine(i);
            //}

            //int j = 0;
            //while (j <= 100)
            //{
            //    Console.WriteLine(j);
            //    j = j + 2;
            //}

            for(int i=0; i<=100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
