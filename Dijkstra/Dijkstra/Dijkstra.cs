using System;
using System.Collections.Generic;
using System.Text;

namespace Dijkstra
{
    class Dijkstra
    {
        private int rango = 0;
        private int [,] L;
        private int[] C;
        public int[] D;
        private int trango = 0;

        public Dijkstra(int paramRango, int [,]paramArreglo)
        {
            L = new int[paramRango, paramRango];
            C = new int[paramRango];
            D = new int[paramRango];
            rango = paramRango;

            for(int i = 0; i <rango; i++)
            {
                for(int j = 0; j < rango; j++)
                {
                    L[i, j] = paramArreglo[i, j];
                }
            }

            for(int i = 0; i < rango; i++)
            {
                C[i] = i;
            }

            C[0] = -1;

            for(int i = 1; i < rango; i++)
            {
                D[i] = L[0, i];
            }
        }

        public void solDijkstra()
        {
            int minValor = Int32.MaxValue;
            int minNodo = 0;

            for(int i = 0; i < rango; i++)
            {
                if(C[i] == -1)
                {
                    continue;
                }

                if(D[i] > 0 && D[i] < minValor)
                {
                    minValor = D[i];
                    minNodo = i;
                }
                
            }

            C[minNodo] = -1;

            for(int i = 0; i < rango; i++)
            {
                if(L[minNodo, i] < 0)
                {
                    continue;
                }

                if (D[i] < 0)
                {
                    D[i] = minValor + L[minNodo, i];
                    continue;
                }

                if ((D[minNodo] + L[minNodo, i]) < D[i])
                {
                    D[i] = minValor + L[minNodo, i];
                }
            }
        }

        public void correrDijkstra ()
        {
            for(trango = 1; trango < rango; trango++)
            {
                solDijkstra();
                Console.WriteLine("Iteracion no." + trango);
                Console.WriteLine("Matriz de distancias: ");

                for(int i = 0; i < rango; i++)
                {
                    Console.Write(i + " ");  
                }

                Console.WriteLine(" ");

                for (int i = 0; i < rango; i++)
                {
                    Console.Write(D[i] + " ");
                }

                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }
        }
    }
}
