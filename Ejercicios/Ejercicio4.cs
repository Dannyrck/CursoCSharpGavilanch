using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Calcula la Hipotenusa de dos catetos
    /// </summary>
    class Ejercicio4
    {
        //Escribir un método que acepte dos catetos y devuelve la hipotenusa 
        //(usar la clase Math para calcular la raíz cuadrada)

        public void Hipotenusa(double cateto1, double cateto2)
        {
            //cateto1 = cateto1 * cateto1;
            //cateto2 = cateto2 * cateto2;
            double hipotenusa = Math.Sqrt((
                Math.Pow(cateto1,2) + Math.Pow(cateto2,2)));
            Console.WriteLine(hipotenusa);
        }
    }
}
