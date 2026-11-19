using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема4
{
    internal class Тема4
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите первое число: ");
                string text1 = Console.ReadLine();
                int number1 = int.Parse(text1);
                Console.Write("Введите второе число: ");
                string text2 = Console.ReadLine();
                int number2 = int.Parse(text2);
                int x = number1 / number2;
                Console.WriteLine($"Ответ: {x}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Вводите только цифры");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Программа завершила работу");
            }
        }
    }
}
