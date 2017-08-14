using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadOnlyConst
{
    class Program
    {
        static readonly double Pi2 = new RepositorioDatos().Pi;
        const double Pi = 3.14;
        static void Main(string[] args)
        {
            Console.WriteLine("primer Valor "+ Pi2);
            
            Console.ReadLine();
            
        }

        
    }

    public class RepositorioDatos
    {
        public  double Pi = 3.1416;
        public void CambiarValor()
        {
            Pi = 3.1416;
        }
    }
}
