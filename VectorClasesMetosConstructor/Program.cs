using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorClasesMetosConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vector vector = new Vector(new List<int>() { 3, 4 });
            //Console.WriteLine(vector.ToString());
            //Console.WriteLine(vector.Dimension);
            //Console.WriteLine(vector[1]);
            //vector[1] = 100;
            //Console.WriteLine(vector[1]);
            Vector v1 = new Vector(new List<int>() { 3, 5 });
            Vector v2 = new Vector(new List<int>() { 4, 8 });
            Vector v3 = new Vector(new List<int>() { 6, 2 });
            Vector suma = v1.Suma(v2);
            Vector suma2 = v1 + v2 + v3;


            Console.ReadLine();

        }
    }

    class Vector
    {
        //Campo
        private List<int> _componentes;
        
        //Propiedades
        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }


        public int Dimension { get { return _componentes.Count; } }


        //Indexador
        public int this[int i]
        {
            get
            {
                return _componentes[i];
            }
            set
            {
                _componentes[i] = value;//Value es importante como parametro de entrada
            }
        }
        //Metodo constructor de la clase que recibe como parametro una lista de componentes.
        public Vector(List<int>componentes)
        {
            _componentes = componentes;
        }

        //implementando el operador "+" (Suma) para poder usarlo directamente al sumar vectores
        //por ejemplo:  vector1 + vector2

        public static Vector operator +(Vector v1, Vector v2)
        {
            return v1.Suma(v2);
        }

        public static int operator *(Vector v1, Vector v2)
        {
             throw new NotImplementedException();
        }

        public static Vector operator ++(Vector v1)
        {
            throw new NotImplementedException();
        }

        //Metodo que suma 2 o mas vectores
        public Vector Suma(Vector v2)
        {
            if (Dimension != v2.Dimension)
            {
                throw new ApplicationException("Los vectores son diferentes en sus dimensiones");
            }
            List<int> resultado = new List<int>();

            for (int i = 0; i < Dimension; i++)
            {
                resultado.Add(this[i] + v2[i]);
            }
            return new Vector(resultado);
        }

    }
}
