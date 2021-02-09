using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleccion
{
    class Program
    {
        private static int[] vector = new int[6] { 4, 3, 8, 6, 1, 5 };

        static void Main(string[] args)
        {


            Console.WriteLine("La longitud del vector es: " + vector.Length);

            for (int h = 0; h <= vector.Length - 1; h++)
            {
                Console.Write(vector[h] + " ");
            }
            Console.WriteLine("");

            int i = 0;
            int j = 0;
            int iMin = 0;
            int n = vector.Length;

            //hacemos el recorrido por todos los elementos
            for(i = 0; i < n - 1; i++)
            {
                //este es el indice menor y es la posicion actual desde donde empezaremos
                iMin = i;

                //hallamos el nuevo indice del menor
                for(j = i + 1; j < n; j++)
                {
                    if (vector[j] < vector[iMin])
                        iMin = j;
                }
                Swap(i, iMin);
            }

            for (int g = 0; g <= vector.Length - 1; g++)
            {
                Console.Write(vector[g] + " ");
            }
            Console.Read();

        }
        private static void Swap(int i1, int i2)
        {
            int temp = vector[i1];
            vector[i1] = vector[i2];
            vector[i2] = temp;
        }
    }
}
