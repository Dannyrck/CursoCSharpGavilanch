using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class MensajeDeTexto:IMensajeria
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Mensaje de texto enviado satisfactoriamente");
        }
    }
}
