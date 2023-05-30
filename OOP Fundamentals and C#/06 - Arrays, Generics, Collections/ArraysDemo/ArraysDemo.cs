using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace ArraysDemo
{
    public class ArraysDemo
    {
        public static void Main(string[] args)
        {
            //ArrayLengthDemo();
            //IteratingArraysDemo();
            //IndexOutOfRangeDemo();
            //ArraysAreRefTypesDemo();
            CopyingArraysDemo();
        }

        private static void ArrayLengthDemo()
        {
            int[] numbers1 = new int[] { 1, 2, 3 };
            int[] numbers2 = new int[5];
            int[] numbers3 = { 1, 2, 3, 4 };

            Console.WriteLine(numbers2.Length);

            numbers2 = numbers1;

            Console.WriteLine(numbers2.Length);

            numbers2 = numbers3;    

            Console.WriteLine(numbers2.Length);
        }

        private static void IteratingArraysDemo()
        {
            int[,] array = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            int[,] array2 = { { 1, 2 }, { 3, 4 }, { 5, 6 } }; // Compile-error

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                    array[i, j] *= 10;
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i, j]);
                }
            }
        }

        private static void IndexOutOfRangeDemo()
        {
            string[] names = { "Tom", "John", "Peter", "Alex", "George" };
            names[10] = "Denis";
        }

        private static void ArraysAreRefTypesDemo()
        {
            float[] stats = { 5.5f, 6.2f, 7.3f };
            int index = 1;
            Console.WriteLine(stats[index]);
            CalculateStats(stats, index);
            Console.WriteLine(stats[index]);
        }

        private static void CalculateStats(float[] data, int indexToUpdate)
        {
            data[indexToUpdate] = 10f;
        }

        private static void CopyingArraysDemo()
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = array1;
            int[] array3 = (int[]) array1.Clone();
            int[] array4 = new int[3];
            array1.CopyTo(array4, 0);

            array1[1] = 100;
            Console.WriteLine(array1[1]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array4[1]);
        }

    }
}