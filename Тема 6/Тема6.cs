using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Тема_6
{
    internal class Тема6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Демонстрация методов разбора даты и времени (Тема 6) ===\n");

            // 1. Метод Parse() — преобразует стандартную строку в DateTime
            string str1 = "23.11.2026 23:30:00";
            DateTime date1 = DateTime.Parse(str1);
            Console.WriteLine($"1. Parse(\"{str1}\") -> {date1}");

            // 2. Метод ParseExact() — преобразует строку по строго заданному шаблону (формату)
            string str2 = "2026/11/23 18-45";
            string format2 = "yyyy/MM/dd HH-mm";
            DateTime date2 = DateTime.ParseExact(str2, format2, CultureInfo.InvariantCulture);
            Console.WriteLine($"2. ParseExact(\"{str2}\", \"{format2}\") -> {date2}");

            // 3. Метод TryParse() — безопасный разбор стандартной строки (не выдает ошибку при кривом вводе)
            string str3 = "15.05.2026";
            if (DateTime.TryParse(str3, out DateTime date3))
            {
                Console.WriteLine($"3. TryParse(\"{str3}\") -> Успех: {date3.ToShortDateString()}");
            }
            else
            {
                Console.WriteLine($"3. TryParse(\"{str3}\") -> Ошибка преобразования");
            }

            // 4. Метод TryParseExact() — безопасный разбор строки строго по шаблону
            string str4 = "25-12-2026";
            string format4 = "dd-MM-yyyy";
            if (DateTime.TryParseExact(str4, format4, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4))
            {
                Console.WriteLine($"4. TryParseExact(\"{str4}\", \"{format4}\") -> Успех: {date4.ToLongDateString()}");
            }
            else
            {
                Console.WriteLine($"4. TryParseExact(\"{str4}\", \"{format4}\") -> Неверный формат даты");
            }

            // Дополнительно: проверка TryParse на некорректной строке, чтобы показать что программа не падает
            string badStr = "некорректная_дата";
            bool isParsed = DateTime.TryParse(badStr, out DateTime badDate);
            Console.WriteLine($"\nПроверка некорректной строки \"{badStr}\": результат = {isParsed}, значение = {badDate}");

            Console.ReadLine();
        }
    }
}
