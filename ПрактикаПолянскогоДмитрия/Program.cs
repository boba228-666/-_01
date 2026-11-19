using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;
using ClassLibrary1;

namespace ПрактикаПолянскогоДмитрия
{
    public class Program
    {
        static void Main(string[] args)
        {
            //2 тема
            User player = new User();
            player.Nickname = "Dimasik";
            player.Level = 10;
            player.Balance = 150.5;
            player.HasVacBan = false;
            //вызываем публичные методы из 2 темы
            Console.WriteLine("Очки (public метод AddPoints): " + player.AddPoints(5, 7));
            player.ShowUserStats();

            Console.WriteLine();

            //1 способ подключения к библиотеки 3 темы
            MyLibrary.Class1 lib = new MyLibrary.Class1();
            lib.SayHi();
            lib.ShowScore(99);
            Console.WriteLine("Умножение: " + lib.Multiply(4, 5));
            Console.WriteLine(lib.MakeTitle("Dimasik"));
            Console.WriteLine("Богатый: " + lib.IsRish(player.Balance));

            //2 способ подключения к библиотеки 3 темы
            ClassLibrary1.Class1 ext = new ClassLibrary1.Class1();
            ext.PrintFromExternal();
            Console.WriteLine("Вычитание из внешней DLL: " + ext.Subtract(20, 8));

            Console.ReadLine();
        }
    }
}
