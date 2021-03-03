using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbol
{
    class Program
    {

        static void Main(string[] args)
        {
            CArbol arbol = new CArbol();

            CNodo raiz = arbol.Insertar("a", null);

            arbol.Insertar("b", raiz);
            arbol.Insertar("c", raiz);

            //arbol.TransversaPreO(raiz);

            CNodo n = arbol.Insertar("d", raiz);
            arbol.Insertar("h", n);

            n = arbol.Insertar("e", raiz);
            arbol.Insertar("i", n);
            n = arbol.Insertar("j", n);
            arbol.Insertar("p", n);
            arbol.Insertar("q", n);

            //arbol.TransversaPreO(raiz);

            n = arbol.Insertar("f", raiz);
            arbol.Insertar("k", n);
            arbol.Insertar("l", n);
            arbol.Insertar("m", n);

            n = arbol.Insertar("g", raiz);
            arbol.Insertar("n", n);

            arbol.TransversaPreO(raiz);
            Console.WriteLine("-------");
            //arbol.TransversaPostO(raiz);
            //Console.WriteLine("-------");

            CNodo encontrado = arbol.Buscar("z", raiz);
            if (encontrado != null)
                Console.WriteLine(encontrado.Dato);
            else
                Console.WriteLine("No lo encontré");

            Console.WriteLine("------");

            string donde = "";
            string que = "";
            Console.WriteLine("¿En dónde insertar?");
            donde = Console.ReadLine();
            Console.WriteLine("¿Qué deseas insertar?");
            que = Console.ReadLine();

            encontrado = arbol.Buscar(donde, raiz);
            arbol.Insertar(que, encontrado);
            arbol.TransversaPreO(raiz);


            Console.Read();
        }
    }
}
