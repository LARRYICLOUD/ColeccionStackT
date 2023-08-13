using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColeccionStackT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            //stack
            Stack<double> miPila = new Stack<double>();
            //insertar objetos al principio del stack
            miPila.Push(5.9);
            miPila.Push(13.1);
            miPila.Push(8.7);
            miPila.Push(3.2);
            miPila.Push(10.5);

            int i = 0; //mostrar indice
            // mostrar informacion del stack
            foreach(double elemento in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }
            //Despues de insertar un elemento
            Console.WriteLine("\nDespues de insertar un elemento\n");
            miPila.Push(1.5);
            i = 0;

            // mostrar informacion del stack
            foreach (double elemento in miPila)
            {
                Console.WriteLine("{0}. {1}", i++, elemento);
            }

        }
    }
}
