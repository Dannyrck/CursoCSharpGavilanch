using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class FactoriaEnviarMensaje
    {
        public static IMensajeria Factoria(string parametro)
        {
            if (parametro == "sms")
            {
                return new MensajeDeTexto();
            }
            else if (parametro == "correo")
            {
                return new Correo();
            }
            else
            {
                throw new ApplicationException();
            }

        }
    }
}
