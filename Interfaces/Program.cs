using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Correo email = new Correo();
            //MensajeDeTexto msj = new MensajeDeTexto();

            //email.EnviarMensaje("oskar@yo.com");
            //msj.EnviarMensaje("588982345");

            var factoriraEnviarMensaje = FactoriaEnviarMensaje.Factoria("correo");
            var enviarEmail = new Correo();
            var enviadorMensaje = new EnviadorMensaje(factoriraEnviarMensaje);
            enviadorMensaje.EnviarMensaje("un  mensaje");

            Console.ReadLine();
        }
    }
}
