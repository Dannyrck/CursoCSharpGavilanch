using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poliorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal cebra = new Cebra();
            Animal oso = new Oso();

            //perro.HaceRuido();
            AnimalHaceRuido(perro);
            AnimalHaceRuido(gato);
            AnimalHaceRuido(cebra);
            AnimalHaceRuido(oso);


            Console.ReadLine();

        }

        public static void AnimalHaceRuido(Animal animal)
        {
            animal.HaceRuido();
        }


    }
}
