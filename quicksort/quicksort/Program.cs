using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort
{
    class Program
    {
        private static int[] vector = new int[6] { 4, 3, 8, 6, 1, 5 };

        static void Main(string[] args)
        {

            OrdenamientoRap(0, vector.Length - 1);

            Console.WriteLine("La longitud del vector es: " + vector.Length);
            
            for(int i = 0; i <= vector.Length-1; i++)
            {
               Console.Write(vector[i]+" ");
            }
            Console.Read();
        }

        private static void Swap(int i1, int i2)
        {
            int temp = vector[i1];
            vector[i1] = vector[i2];
            vector[i2] = temp;
        }

        public static int Particion(int pInicio, int pFin)
        {
            int pivote = 0;
            int iPivote = 0;
            int n = 0;

            pivote = vector[pFin];

            iPivote = pInicio;

            for (n = pInicio; n < pFin; n++)
            {

                if (vector[n] <= pivote)
                {

                    Swap(n, iPivote);

                    iPivote++;
                }
            }

            Swap(iPivote, pFin);

            return iPivote;
        }

        public static void OrdenamientoRap(int pInicio, int pFin)
        {
            int iPivote = 0;

            if (pInicio >= pFin)
                return;

            iPivote = Particion(pInicio, pFin);

            OrdenamientoRap(pInicio, iPivote - 1);
            OrdenamientoRap(iPivote + 1, pFin);
        }


    }
}
