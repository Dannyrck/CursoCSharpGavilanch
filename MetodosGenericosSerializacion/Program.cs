
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace MetodosGenericosSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona { Edad = 18, Nombre = "Daniel" };
            Empresa empresa1 = new Empresa { Nombre = "Arcelomital" };
            //var xml_persona=Serializar(empresa1);
            var xml_empresa = Serializar<Empresa>(empresa1);
            var xml_persona = Serializar<Persona>(persona1);

        }

        /*Este Metodo solo funciona con miembros de un solo objeto
         * Si quisieramos pasarle un objeto empresa en vez de persona que es el que esta 
         * diseñado nos mandaria un terrible error
         Para solucionarlo  podemos escribir el mismo metodo pasandole un objeto empresa
         como parametro pero aqui estariamos cometiendo un error que es reescribir codigo 
         similar ademas si despues nececitaos pasarle otra clase de objeto 
         tendriamos que crear otro metodo y asi cada vez que se nesecite.
         la solucion que emplearemos y la que es correcta es utilizar un metodo generico*/

        //public static string Serializar(Persona persona)
        //{
        //    var serializador = new XmlSerializer(typeof (Persona));
        //    using (var escritorString= new StringWriter())
        //    {
        //        using (var escritor = XmlWriter.Create(escritorString))
        //        {
        //            serializador.Serialize(escritor, persona);
        //            return escritorString.ToString();
        //        }
        //    }
        //}

        /*Acontinuacion se muestra cmo implementar el mismo metodo serializar pero 
         * esta vez recibiendo un objeto generico
         */

        public static string Serializar<T>(T valor)
        {
            var serializador = new XmlSerializer(typeof(T));
            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }
    }
}
