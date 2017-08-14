using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Daniel",28);
            persona = null;

            //int valor = null; //--No se puede declarar un valor null por que el tipo de dato no lo permite
            Nullable<int> valor = null;
            DateTime? fechaDeNacimiento = null;

            if (valor.HasValue)
            {
                Console.WriteLine("La variable tiene un valor");
                SumarEdad(fechaDeNacimiento.Value);
            }
            else
            {
                Console.WriteLine("No tiene un valor");
            }

            Console.ReadKey();
        }

        static public void SumarEdad(DateTime fechaNacimiento)
        {

        }
    }

    
}
