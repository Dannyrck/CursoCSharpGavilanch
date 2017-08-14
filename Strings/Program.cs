using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra="Felipe";
            string frase="Juan y Jose son amigos";

            //Lenght
            Console.WriteLine(palabra.Length);
            Console.WriteLine(frase.Length);
            //Substring
            Console.WriteLine(palabra.Substring(3));
            Console.WriteLine(frase.Substring(7, 4));
            //startsWith
            Console.WriteLine(palabra.StartsWith("Juan"));
            Console.WriteLine(frase.StartsWith("Juan"));
            //endsWith
            Console.WriteLine(frase.EndsWith("amigos"));
            Console.WriteLine(frase.EndsWith("enemigos"));

            //contains
            Console.WriteLine(frase.Contains("Jose"));
            Console.WriteLine(frase.Contains("Daniel"));

            //index of

            Console.WriteLine(frase.IndexOf("son"));

            //operador +

            Console.WriteLine(palabra + ", " + frase);

            //ToLower
            Console.WriteLine(frase.ToLower());
            //ToUpper
            Console.WriteLine(frase.ToUpper());
            //Trim
            string ejemploTrim = "   Felipe   ";
            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim());
            Console.WriteLine(ejemploTrim.Length);
            Console.WriteLine(ejemploTrim.Trim().Length);
            //Format
            string ejemploFormat = "Felicidades {0} en tu cumpleaños numero {1}!  {0},{1} " ;
            var resultadoEjemploFormat = string.Format(ejemploFormat, "Oscar", 28);
            Console.WriteLine(resultadoEjemploFormat);

            //Replace

            string ejemploReplace = "Felicidades @nombre en tu cumpleaños numero @numero!";
            var resultadoReplace = ejemploReplace.Replace("@nombre", "Daniel");
            resultadoReplace = resultadoReplace.Replace("@numero", "28");
            Console.WriteLine(resultadoReplace);


            //ItsNullOrWhiteSpaces
            string nulo=null;
            string espaciosEnBlanco="                   ";
            Console.WriteLine(string.IsNullOrWhiteSpace(nulo));
            Console.WriteLine(string.IsNullOrWhiteSpace(espaciosEnBlanco));
            Console.WriteLine(string.IsNullOrWhiteSpace(palabra));


            Console.Read();
        }
    }
}
