using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Vaca:Animal
    {
        public Vaca(string nombre) : base(nombre)
        {

        }

        public bool Corral { get; set; }
        public bool Marcada { get; set; }

        

        
    }
}
