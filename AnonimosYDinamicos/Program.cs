using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonimosYDinamicos
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalito1 = new { tipo = "Perro", nombre = "Perrito", edad = 12 };
            var animalito2 = new { tipo = "Gato", nombre = "minino", edad = 2 };

            List<dynamic> animalitos = new List<dynamic>() { animalito1, animalito2 };
            foreach(dynamic animalito in animalitos)
            {
                Console.WriteLine($"El {animalito.tipo} se llama {animalito.nombre} " +
                    $"y tiene {animalito.edad} años");
            }

            Console.ReadLine();

        }
    }
}
