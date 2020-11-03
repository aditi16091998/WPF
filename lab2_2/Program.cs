using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] my_array = new int[5, 6];
            Console.WriteLine("Enter the elements in the matrix-------------------------------");

            for ( i = 0; i < 5; i++)
            {
                for ( j = 0; j < 6; j++)
                {
                    Console.WriteLine("enter the elements at [{0},{1}]", i, j);
                    my_array[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The 2-D matrix is-----------------------------------------------");
            for (i = 0; i < 5; i++)
            {
                Console.Write("   ");
                for (j = 0; j < 6; j++)
                {
                    Console.Write("{0}",my_array[i,j]);
                
                }
            
            }


            Console.ReadLine();


        }
    }
}
