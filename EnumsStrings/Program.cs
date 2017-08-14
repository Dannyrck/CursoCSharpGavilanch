using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsStrings
{
    class Program
    {

        enum EstatusOperacion
        {
            Exitoso=1,
            ErrorDeSistema=3,
            ClienteNoEncontrado=4
        }


        static void Main(string[] args)
        {
            int resultadoOperacion = 5;
            string Operacion = " ";

            if (resultadoOperacion == (int)EstatusOperacion.Exitoso)
            {

            }

            if (resultadoOperacion == (int)EstatusOperacion.ErrorDeSistema) ;
            {

            }
            //Con string Magico
            if (Operacion == EstatusDeOperacion._exito)
            {

            }

        }
        
    }

}
