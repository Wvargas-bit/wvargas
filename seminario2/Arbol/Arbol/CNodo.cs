using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class CNodo
    {
        //El dato o los datos que guardará el nodo
        private string dato;

        //Las referencias a nodo hijo y hermano
        private CNodo hijo;
        private CNodo hermano;

        //propiedades de los datos del nodo, de los hijos y hermanos
        public string Dato { get => dato; set => dato = value; }
        public CNodo Hijo { get => hijo; set => hijo = value; }
        public CNodo Hermano { get => hermano; set => hermano = value; }

        //El constructor del nodo
        public CNodo()
        {
            dato = "";
            hijo = null;
            hermano = null;
        }
    }
}
