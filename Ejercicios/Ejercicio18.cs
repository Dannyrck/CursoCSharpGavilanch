using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    class Ejercicio18
    {
        /*18) Escribir un método que acepte un string y devuelva 
         * true si dicho string es un palíndromo, si no lo es devuelve false. 
         * Un palíndromo es un texto que es igual al derecho y al revés. 
         * Ejemplos: "ana" es un palíndromo, pero "Pirata" no es palíndromo. 
         * Para iterar un string caracter por caracter, utilizamos el indexador []. 
         * Ejemplo:
            string nombre = "Felipe"; 
            for (int i = 0; i < nombre.Length; i++) 
            { 
            Console.WriteLine(nombre[i]); 
            }
          */


        public bool Palindromo(string cadena)
        {

            string palin=string.Empty;
            for(int i = cadena.Length; i<= cadena.Length; i--)
            {
                if (i > 0)
                {
                    palin += cadena[i - 1];
                }
                else
                {
                    break;
                }
                
            }

            if (cadena == palin)
            {
                return true;

            }
            return false;
        }
    }
}
