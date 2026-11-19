using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема5
{
    internal class Тема5
    {
        static void Main(string[] args)
        {
            string secretWord = "Admin2026";

            Console.Write("Введите кодовое слово: ");
            string userWord = Console.ReadLine();

            // 1. Проверка операторами == и !=
            
            if (userWord == secretWord)
            {
                Console.WriteLine("Пароль верный");
            }
            if (userWord != secretWord)
            {
                Console.WriteLine("Пароль не верный");
            }

            // 2. Проверка методом Equals()
            bool isEqual = userWord.Equals(secretWord);
            Console.WriteLine($"Результат Equals: {isEqual}");

            // 3. Сравнение методами Compare() и CompareOrdinal()
            int compResult = string.Compare(userWord, secretWord);
            int ordResult = string.CompareOrdinal(userWord, secretWord);
            Console.WriteLine($"Compare: {compResult}, CompareOrdinal: {ordResult}");

            // 4. Поиск подстроки методом Contains()
            bool has2026 = userWord.Contains("2026");
            Console.WriteLine($"Содержит '2026': {has2026}");

            // 5. Поиск позиции методом IndexOf()
            int index = userWord.IndexOf("A");
            Console.WriteLine($"Позиция буквы 'A': {index}");
        }
    }
}
