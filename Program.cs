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
        }

    }
}