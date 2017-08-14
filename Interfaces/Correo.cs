using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Correo : IMensajeria
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Correo electronico enviado de manera correcta");
        }
    }
}
