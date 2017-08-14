using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class EnviadorMensaje
    {
        private IMensajeria _enviadorMensaje;
        public EnviadorMensaje(IMensajeria enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
        }
    }
}
