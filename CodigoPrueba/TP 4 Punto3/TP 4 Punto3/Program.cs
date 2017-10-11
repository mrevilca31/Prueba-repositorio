using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4_Punto5
{
    class Program
    {
        static void Main(string[] args)
        {
            //MISA BIEN PUTITO SE LA COME
            int x;
            Random generador = new Random();
            Queue<int> cola1 = new Queue<int>();
            Queue<int> cola2 = new Queue<int>();

            cargarCola(cola1);
            mostrarCola(cola1);
            Console.ReadKey();

            x = generador.Next(15);
            cola2 = eliminarElemento(cola1,x);
            mostrarCola(cola2);
            Console.ReadKey();
        }

        static void cargarCola(Queue<int> c)
        {
            int cant;
            Random generador = new Random();
            cant = generador.Next(5,20);
            for (int i = 0; i < cant; i++)
            {
                c.Enqueue(generador.Next(15));
            }
        }

        static void mostrarCola(Queue<int> c)
        {
            Console.WriteLine("Cantidad de elementos en la cola: {0}", c.Count);
            foreach (int item in c)
            {
                Console.Write("{0} ",item);
            }
            Console.WriteLine();
        }

        static Queue<int> eliminarElemento(Queue<int> c, int x)
        {
            Queue<int> aux = new Queue<int>();
            
            Console.WriteLine("\nNumero a eliminar: {0}", x);

            if (c.Contains(x))
            {
                foreach (int item in c)
                {
                    if (item != x)
                    {
                        aux.Enqueue(item);
                    }
                }
                Console.WriteLine("\nEl Numero {0} fue eliminado exitosamente.", x);
                Console.WriteLine();
                return aux;
            }
            else
            {
                Console.WriteLine("\nEl numero {0} no se encontro", x);
                Console.WriteLine();
                return c;
            }
        }
    }
}
}
