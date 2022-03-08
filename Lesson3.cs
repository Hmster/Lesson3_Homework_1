using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Homework_1
{
    internal static class Lesson3
    {   
        /// <summary>
        /// Make array and it's diagonal
        /// </summary>
        /// <returns>array</returns>
        internal static int[,] MakeArray(int[,] array)
        {
            Random rnd = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1,9);
                }
            }
            return array;
        }

        internal static int[,] MakeDiag(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                        array[i, j] = array[i, j];
                    else
                        array[i, j] = 0;
                }
            }
            return array;
        }
    }
}
