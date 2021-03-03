using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class CArbol
    {
        private CNodo raiz;
        //Este nodo nos apoyará en algunas operaciones
        private CNodo trabajo;
        private int i = 0;

        //El constructor nos instanciará el nodo raíz
        public CArbol()
        {
            raiz = new CNodo();
        }

        public CNodo Insertar(string pDato, CNodo pNodo)
        {
            //Si no hay nodo donde insertar, tomamos como si fuera la raíz
            if(pNodo == null)
            {
                raiz = new CNodo();
                raiz.Dato = pDato;

                //No hay hijo
                raiz.Hijo = null;

                //No hay hermano
                raiz.Hermano = null;

                return raiz;
            }

            //Verificamos si no tiene hijo
            //Insertamos el dato como hijo
            if(pNodo.Hijo == null)
            {
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                //Conectamos el nuevo nodo como hijo
                pNodo.Hijo = temp;

                return temp;
            }

            else //Ya tiene un hijo, tenemos que insertarlo como hermano
            {
                trabajo = pNodo.Hijo;

                //Avanzamos hasta el último hermano
                while(trabajo.Hermano != null)
                {
                    trabajo = trabajo.Hermano;
                }

                //Creamos nodo temporal
                CNodo temp = new CNodo();

                temp.Dato = pDato;

                //Unimos el temp al último hermano
                trabajo.Hermano = temp;

                return temp;
            }

        }

        //Transversa preorder
        public void TransversaPreO(CNodo pNodo)
        {
            if (pNodo == null)
                return;

            //Primero realizo el proceso en mí
            for (int n = 0; n < i; n++)
                Console.Write(" ");

            Console.WriteLine(pNodo.Dato);

            //Luego proceso a mi hijo
            if(pNodo.Hijo != null)
            {
                i++;
                TransversaPreO(pNodo.Hijo);
                i--;
            }

            //Si tengo hermanos los proceso
            if (pNodo.Hermano != null)
                TransversaPreO(pNodo.Hermano);
        }


    }
}
