using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace lista_simple.Clases_Listas
{
    class Nodo
    {
        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return  dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return  siguiente; }
            set { siguiente = value; }
        }

    }
}
