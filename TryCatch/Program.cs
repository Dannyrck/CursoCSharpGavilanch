using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;
            try
            {
                int resultado = a / b;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Se ha encontrado un error");
            }
            finally
            {
                Console.WriteLine("El finally siempre se va a ejecutar");
            }
        }
    }
}
