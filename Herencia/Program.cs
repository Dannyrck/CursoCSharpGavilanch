using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>()
            {
                new Vaca("Vacacia"),
                new Obeja("Booooop")
            };
            animales.Add(new Vaca("Vaquita"));
            animales.Add(new Obeja("Obejita"));
            

            foreach( var animal in animales)
            {
                Console.WriteLine(animal.Sonido());
                if (animal.Equals(typeof(Vaca)))
                {
                    Console.WriteLine(" ¿? ");
                }
            }

            Console.ReadLine();
        }
    }
}
