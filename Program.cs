using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork
{
    internal class Program
{
    static void Main(string[] args)
        {
            // Здесь массивы заданий 1-4
            // Создайте массив, сожержащий первые 8 чисел данной последовательности:
            int[] a = new int[] { 0, 1, 1, 2, 3, 5, 8, 13 };
            //Создайте массив типа string, содержащий название 12 месяцев
            string[] b = new string[] { January, February, March, April, May, June, July, August, September, October, November, December };
            //Создайте двумерный массив (матрицу) 3x3
            int[,] c = new int[3, 3] {{ 2, 3, 4 },{ 4, 9, 16 },{ 9, 27, 81 } };

            // Объявляем ступенчатый массив
            double[][] d = new double[3][];
            d[0] = new double[5] {1,2,3,4,5};//числа от 1 до 5 
            d[1] = new double[2] { Math.PI, Math.E };//константы e и pi
            d[2] = new double[4] { Math.Log10(0), Math.Log10(10), Math.Log10(100), Math.Log10(1000)};//логарифм по основанию 10 чисел 1, 10, 100 и 1000

            // массивы для заданий 5 и 6.
            int[] array = { 1, 2, 3, 4, 5 };
            int[] array2 = { 7, 8, 9, 10, 11, 12, 13 };
            array.CopyTo(array2, 7); // новая строка массива копируется в массив 2, место вставки 7 индекс
            var CopyArrays = array2.Length - 2; // убираем лишние индексы в массиве
            var result = Array.Copy(array, array2, 2); //что это за строка и для чего она не поняла((
            Console.WriteLine(array2); // Выведите результат

        string[] sample = { "", "" };
            Array.Resize(ref array, 9);
                                    // Что же будет выведено? Ничего))
        }
}
}