﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_Homework_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[5, 5];

            Console.WriteLine("Fill array with elements:");

            Lesson3.MakeRandomArray(array);
            ArrayPrint(array);

            Console.WriteLine("\nAnd now, show only diagonal of array:\n");

            Lesson3.MakeDiag(array);
            ArrayPrint(array);

            Console.WriteLine("-------------------------------------------------------------------------------\n");

            string[,] array2 = Lesson3.MakePhoneList();
            ArrayPrint(array2);

            

            Console.ReadKey();
        }

        internal static int[,] ArrayPrint(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{0,3}", array[i, j]);
                }
                Console.WriteLine();
            }
            return array;
        }
        internal static string[,] ArrayPrint(string[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return array;
        }
    }
}
