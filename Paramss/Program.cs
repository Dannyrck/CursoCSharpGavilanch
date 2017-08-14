using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paramss
{
    class Program
    {
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            Console.WriteLine(op.Suma(5,2,3,4));

            Console.ReadKey();
        }


    }

    class Operaciones
    {
        //int _numeroUno;
        //int _numeroDos;
        float resultado;

        //public Operaciones(int numeroUno, int numeroDos)
        //{
        //    _numeroUno = numeroUno;
        //    _numeroDos = numeroDos;
        //}

        public float Suma(params int[]numeros)
        {
            foreach (int numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }
    }
}
