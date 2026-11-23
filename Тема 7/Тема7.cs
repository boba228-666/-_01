using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_7
{
    internal class Тема7
    {
        // --- Задание 1: Три отдельных метода для работы с массивами ---

        // 1. Метод сортировки массива по возрастанию
        public static int[] SortAscending(int[] array)
        {
            int[] result = (int[])array.Clone(); // Копируем, чтобы не портить исходный массив
            Array.Sort(result);
            return result;
        }

        // 2. Метод сортировки массива по убыванию
        public static int[] SortDescending(int[] array)
        {
            int[] result = (int[])array.Clone();
            Array.Sort(result);
            Array.Reverse(result);
            return result;
        }

        // 3. Метод объединения двух массивов в один
        public static int[] MergeArrays(int[] first, int[] second)
        {
            int[] merged = new int[first.Length + second.Length];
            Array.Copy(first, 0, merged, 0, first.Length);
            Array.Copy(second, 0, merged, first.Length, second.Length);
            return merged;
        }

        // --- Задание 2: Абсолютная разность с числом 123 ---
        public static int CalculateDifference(int n)
        {
            int diff = Math.Abs(n - 123);
            if (n > 123)
            {
                return diff * 3;
            }
            return diff;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("=== Задание 1: Работа с массивами ===");
            int[] arr1 = { 42, 7, 19, 3, 85 };
            int[] arr2 = { 10, 55, 1 };

            Console.WriteLine("Исходный массив 1: " + string.Join(", ", arr1));
            Console.WriteLine("Исходный массив 2: " + string.Join(", ", arr2));

            int[] asc = SortAscending(arr1);
            Console.WriteLine("По возрастанию:    " + string.Join(", ", asc));

            int[] desc = SortDescending(arr1);
            Console.WriteLine("По убыванию:       " + string.Join(", ", desc));

            int[] combined = MergeArrays(arr1, arr2);
            Console.WriteLine("Объединенный:      " + string.Join(", ", combined));

            Console.WriteLine("\n=== Задание 2: Абсолютная разность с 123 ===");
            Console.Write("Введите целое число n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result = CalculateDifference(n);
            Console.WriteLine($"Результат для n = {n}: {result}");

            Console.ReadLine();
        }
    }
}
