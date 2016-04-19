using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<int> unsorted = new List<int>
            {
                1,3,5,4,8,2,3
            };

          

            QuickSort2(ref unsorted);

            foreach (int myInts in unsorted)
            {
                Console.WriteLine(myInts);
            }

            
                        
        }

        public static void QuickSort(List<int> lista)
        {
            int n = lista.Count - 1;

            int pivot = lista[n];

            //int temp1=0, temp2=0;

            List<int> temporary = new List<int>();
                       
                for (int i = 0; i < pivot; i++)
                {
                    if (lista[i] > lista[pivot])
                    {
                           
                    }
                    
                }

                for (int j = pivot + 1; j < n; j++)
                {
                    if (lista[j] < lista[pivot])
                    {
                                       
                    }

                }
            
           
            

            
            }




        /// <summary>
        /// Metoda przyjmująca nieposortowaną listę i zwracająca posortowaną jako referencję
        /// </summary>
        /// <param name="lista">Nieposortowana lista</param>



        public static void QuickSort2(ref List<int> lista)
        {
            var sorted = from n in lista orderby n select n;
            lista = sorted.ToList<int>();
        }

        

        

        
    }
}
