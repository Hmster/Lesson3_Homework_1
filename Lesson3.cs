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
        internal static int[,] MakeRandomArray(int[,] array)
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
        /// <summary>
        /// Make array with only diagonal
        /// </summary>
        /// <param name="array"></param>
        /// <returns>array</returns>
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

        /// <summary>
        /// Fill string array
        /// </summary>
        /// <returns>array</returns>
        internal static string[,] MakePhoneList()
        {
            string[,] array = 
            {
                {"Aleks", "555-55-55 / a@a.com"},
                {"Elena", "333-33-33 / e@a.com"},
                {"Kostia", "444-44-44 / j@a.com"},
                {"Maria", "222-22-22 / d@a.com"},
                {"Maxim", "777-77-77 / m@a.com"}
            };
            return array;
        }

        /// <summary>
        /// Reverse string
        /// </summary>
        /// <param name="text"></param>
        /// <returns>string</returns>
        internal static string ReverseString(string text)
        {
            string revText = "";
            for (int i = 1; i <= text.Length; i++)
            {
               revText += text[text.Length - i];
            }
            return revText;
        }
    }
}
