using System;

namespace Dijkstra
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[,] L = {
                {-1, 10, 18, -1, -1, -1, -1},
                {-1, -1, 6, -1, 3, -1, -1},
                {-1, -1, -1, 3, -1, 20, -1},
                {-1, -1, 2, -1, -1, -1, 2},
                {-1, -1, -1, 6, -1, -1, 10},
                {-1, -1, -1, -1, -1, -1, -1},
                {-1, -1, 10, -1, -1, 5, -1},
            };

            Dijkstra dijkstra = new Dijkstra((int)Math.Sqrt(L.Length), L);

            dijkstra.correrDijkstra();
            Console.WriteLine(
                "La solucion de la ruta mas corta tomando como nodo incial el nodo 1 es: "
                );
            int nodo = 1;

            foreach( int i in dijkstra.D)
            {
                Console.Write("Distancia minima a nodo " + nodo + " es");
                Console.WriteLine(i);
                nodo++;
            }

            Console.WriteLine();
            Console.WriteLine("Presione la tecla Enter para salir. ");
            Console.Read();
        }
    }
}
