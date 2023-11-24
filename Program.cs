using System;
using lista_simple.Clases_Listas;

namespace lista_simple
{
    public class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            for (int i = 0; i < 5; i++)
            {
                lista.InsertarLista();
            }

            Console.WriteLine("Los elementos dentro de la lista son: ");
            lista.Mostrar();

            // Después de mostrar la lista
            Console.WriteLine("Ingrese el elemento a buscar: ");
            int elementoABuscar = int.Parse(Console.ReadLine());

            Nodo nodoEncontrado = lista.BuscarElemento(elementoABuscar);

            if (nodoEncontrado != null)
            {
                Console.WriteLine($"Elemento {elementoABuscar} encontrado en la lista.");
            }
            else
            {
                Console.WriteLine($"Elemento {elementoABuscar} no encontrado en la lista.");
            }

            // Insertar un elemento en la mitad
            Console.WriteLine("Ingrese el elemento a insertar en la mitad: ");
            int elementoAInsertar = int.Parse(Console.ReadLine());
            lista.InsertarEnMedio(elementoAInsertar);

            // Mostrar la lista después de la inserción en la mitad
            Console.WriteLine("Los elementos dentro de la lista después de la inserción en la mitad son: ");
            lista.Mostrar();
        }

    }
}