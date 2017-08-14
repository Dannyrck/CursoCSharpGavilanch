using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefYOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antes de cambiar el valor");
            Persona persona = new Persona { Nombre = "Oscar" };
            Console.WriteLine($"{persona.Nombre}");
            int edad ;
            //Console.WriteLine($"Edad = {edad}");

            Console.WriteLine("Despues de cambiar el valor");
            CambiarNombre(persona, "Juan");
            //CambiarEdad(edad, 16);//Le estamos pasando un valor
            //CambiarEdad(ref edad, 16);//Referncia 
            CambiarEdad(out edad, 16);
            Console.WriteLine(persona.Nombre);
            Console.WriteLine($"Edad= {edad}");

            Console.ReadLine();
        }

        public static void CambiarNombre(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }

        //public static void CambiarEdad(int edad, int nuevaEdad)//Le estamos pasando un valor y no cambia
        //public static void CambiarEdad(ref int edad,int nuevaEdad)
                //no podemos usar una referencia si no se ha inicializado la variable
        public static void CambiarEdad(out int edad, int nuevaEdad)//Nos exige asignarle un valor al parametro
            //Antes de que este metodo termine
        {
            edad = nuevaEdad;
        }
    }
}
