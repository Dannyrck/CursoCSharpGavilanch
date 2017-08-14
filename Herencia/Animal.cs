using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Animal
    {
        public string Nombre { get; set; }

        public Animal(string nombre)
        {
            this.Nombre = nombre;
        }
        public virtual string Sonido()
        {
            return $"{Nombre} dice muuuuu!!";
        }
    }
}
