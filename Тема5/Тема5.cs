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
                Console.WriteLine("Пароль верный");//проверяет что строки равны
            }
            if (userWord != secretWord)
            {
                Console.WriteLine("Пароль не верный");//проверяет что тсроки не равны
            }

            // 2. Проверка методом Equals() - тоже что и ==, возвращает true если строки полностью совпадают
            bool isEqual = userWord.Equals(secretWord);
            Console.WriteLine($"Результат Equals: {isEqual}");

            // 3. Сравнение методами Compare() и CompareOrdinal() - сравнивает строки по алфавиту
            int compResult = string.Compare(userWord, secretWord);// учитывает языковые настройки системы
            int ordResult = string.CompareOrdinal(userWord, secretWord);// сравнивает по числовым кодам символов
            Console.WriteLine($"Compare: {compResult}, CompareOrdinal: {ordResult}");

            // 4. Поиск подстроки методом Contains() - проверяет, есть ли нужная строчка (в данном случае 2026) в кодовом слове, если есть - true
            bool has2026 = userWord.Contains("2026");
            Console.WriteLine($"Содержит '2026': {has2026}");

            // 5. Поиск позиции методом IndexOf() - счет начинается с 0, если буква не найдена -1
            int index = userWord.IndexOf("A");
            Console.WriteLine($"Позиция буквы 'A': {index}");
        }
    }
}
