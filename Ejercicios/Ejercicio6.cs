using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Convierte de grados celcius a farenheit
    /// </summary>
    class Ejercicio6
    {
        /*Escribir un método que acepte un double que represente 
         * un número en grados Celcius y lo transforme a grados 
         * Fahrenheit. 
         * Formula                   (T(°F) = T(°C) × 9/5 + 32)   
         */
        double farenheit=0;

        /// <summary>
        /// Emplea este metodo convirte los grados celcius
        /// a grados farenheit
        /// </summary>
        /// <param name="Celicius"> Grados celcius</param>
        public void ToFarenheit(double celicius)
        {
            //farenheit = celicius*(9 / 5) + 32;
            farenheit = celicius * 1.8000 + 32;
            Console.WriteLine($"{celicius} C° equivalen a {farenheit} °F");
        }


    }
}
