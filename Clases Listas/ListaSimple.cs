using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista_simple.Clases_Listas
{
    class ListaSimple
    {
        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public ListaSimple()
        {
            Primero = null;
            Ultimo = null; 
        }

        public void InsertarLista()
        {
            Nodo Nuevo = new Nodo();

            Console.WriteLine("Ingrese el dato");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
            Console.WriteLine("Se agrego el elemento");
        }


        public void Mostrar()
        {
            Nodo actual = new Nodo();
            actual = Primero;

            if (Primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine($"Elemento es: {actual.Dato}");
                    actual = actual.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista esta vacia");
            }
        }

    }
}
