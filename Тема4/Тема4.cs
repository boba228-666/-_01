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
            //это блок, в котором потенциально может произойти ошибка
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
            // catch срабатывает если в try случилась ошибка
            catch (FormatException)
            {
                Console.WriteLine("Вводите только цифры");// срабатывает если пользователь ввел другие символы вместо цифр
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("На ноль делить нельзя!");// срабатывает если второе число равно 0
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Произошла ошибка: {ex.Message}");// срабатывает при непредвиденных ошибках
            }
            finally
            {
                Console.WriteLine("Программа завершила работу");//всегда срабатывает в самом конце и завершает работу программы
            }
        }
    }
}
