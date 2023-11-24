using System;
using System.Collections;
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


        public Nodo BuscarElemento(int elemento)
        {
            Nodo actual = Primero;

            while (actual != null)
            {
                if (actual.Dato == elemento)
                {
                    return actual; // Se encontró el elemento, devolver el nodo actual
                }

                actual = actual.Siguiente;
            }

            return null; // No se encontró el elemento en la lista 
        }


        public void InsertarEnMedio(int elemento)
        {
            Nodo nuevo = new Nodo
            {
                Dato = elemento
            };

            if (Primero == null)
            {
                // Si la lista está vacía, simplemente se agrega
                // el elemento como el primero y el último
                Primero = nuevo;
                Ultimo = nuevo;
                nuevo.Siguiente = null;
            }
            else
            {
                Nodo actual = Primero;
                Nodo anterior = null;
                int longitud = ObtenerLongitud();

                // Si la longitud de la lista es impar,
                // se avanza un nodo extra para llegar al medio
                int pasos = (longitud % 2 == 0) ? longitud / 2 : (longitud / 2) + 1;

                for (int i = 0; i < pasos; i++)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }

                // Insertar el nuevo nodo en la mitad
                anterior.Siguiente = nuevo;
                nuevo.Siguiente = actual;
            }

            Console.WriteLine("Se agregó el elemento en la mitad de la lista.");
        }

        private int ObtenerLongitud()
        {
            Nodo actual = Primero;
            int longitud = 0;

            while (actual != null)
            {
                longitud++;
                actual = actual.Siguiente;
            }

            return longitud;
        }
    }
}
