using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios
{
    /// <summary>
    /// Calcular edad con un datetime
    /// </summary>
    class Ejercicio11
    {
        // 11) Escribir un método que acepte un datetime que represente 
        //la fecha de nacimiento de una persona y retornar su edad al día de hoy. //
        //Nota: DateTime.Today te da la fecha de hoy.
        public void CalculaEdad(DateTime fecha)
        {

            System.TimeSpan edad;
            edad = DateTime.Today-fecha ;
            Console.WriteLine($"Tu tienes {(int)edad.TotalDays/365} años. ");

        }
    }
}
