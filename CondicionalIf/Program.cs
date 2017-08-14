using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondicionIteracion
{
    class Program
    {
        static void Main(string[] args)
        {
            //string nombre = "Daniel";
            string frase = "Mas vale pajaro en mano que ciento volando";
            var valorFrase = frase.ToLower();
            //Console.WriteLine(valorFrase == frase.ToLower());

            //if (nombre.Length == 5)
            //{
            //    Console.WriteLine("Tu nombre tiene 5 digitos");
            //}else if(nombre.Length==6){
            //    Console.WriteLine("Tu nombre tiene 6 digitos");
            //}

            List<string> nombres = new List<string>() {"Pedro","Luis","Carmen"};


            Console.WriteLine("Con For");

            for (int i = 0; i < nombres.Count; i++)
            {

                nombres[i] = nombres[i] + "s";
                Console.WriteLine(nombres[i].ToUpper());
                Console.WriteLine(i);
            }

            //foreach (string nombre in nombres)
            //{
            //    Console.WriteLine(nombre.ToUpper());

            //}

            Console.WriteLine("Con While");

            int j = 0;
            while (j < nombres.Count)
            {
                Console.WriteLine(nombres[j]);
                Console.WriteLine(j);
                j++;

            }

            Console.ReadLine();

        }
    }
}
