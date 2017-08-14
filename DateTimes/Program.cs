using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2016, 04, 23);
            DateTime fechaConHora = new DateTime(2000, 9, 23, 8, 45, 55);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("mm-dd-yyyy"));
            Console.WriteLine(fecha.ToString("dd/mm/yy"));
            Console.WriteLine(fechaConHora.ToString("dd/mm/yy hh:mm:ss"));
            Console.WriteLine(fecha.AddDays(45));

            Console.WriteLine(fecha.DayOfWeek);

            Console.WriteLine(fecha.Subtract(fechaConHora).Days);
            Console.ReadLine();
        }
    }
}
