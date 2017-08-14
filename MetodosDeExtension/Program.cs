using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(9.ElevarA(3));
            Console.ReadLine();
        }

    }

    public static class IntegerExtensionMethod
    {
        public static double ElevarA(this int valor, int potencia)
        {
            return Math.Pow(valor, potencia);
        }
    }
}
