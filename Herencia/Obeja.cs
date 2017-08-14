using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Obeja : Animal
    {
        public Obeja(string nombre) : base(nombre)
        {
             
        }

        public override string Sonido()
        {
            return $"{Nombre} dice beeeeeeee!!";
        }
    }
}
