using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KuzakinSI.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KuzakinSI.Sprint0.Task7.V0
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Спринт #0");
            Console.WriteLine("Тема: Создания итогового решения по спринту");
            Console.WriteLine("Задание #7");
            Console.WriteLine("Вариант #0");
            Console.WriteLine("Выполнил: Кузякин Семён Игоревич | ПИНб-25-1");
            Console.WriteLine();

            Console.WriteLine("Условие:");
            Console.WriteLine("Написать консольную программу на C#, которая суммирует значения двух одинаковых по длине массивов.");
            Console.WriteLine();

            Console.WriteLine("Исходные данные:");
            Console.WriteLine("Значения элементов массива №1");

            int[] arrayNums = new int[] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arrayNums.Length; i++)
            {
                Console.Write(arrayNums[i] + ", ");
            }

            Console.WriteLine();

            Console.WriteLine("Значения элементов массива №1");
            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 0; i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }
            Console.WriteLine();

            Console.WriteLine("Результат:");
            Console.WriteLine("Сумма элементов массива равна:");
            if (arrayNums.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums, arrayNums2);
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Error. The sizes of the arrays not the same");
            }


            Console.ReadKey();
        }
    }
}
