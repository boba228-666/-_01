using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;


namespace ПрактикаПолянскогоДмитрия
{
    public class Program
    {
        static void Main(string[] args)
        {
            User player = new User();
            player.Nickname = "Dimasik";
            player.Level = 10;
            player.Balance = 150.5;
            player.HasVacBan = false;
            Console.WriteLine(Sum(5, 7));
            Console.WriteLine(GetStatus(player.Nickname));
            Console.WriteLine($"Уровень: {player.Level}, Баланс: {player.Balance}, Бан в играх: {player.HasVacBan}");
            Class1 lib = new Class1();
            lib.SayHi();
            lib.ShowScore(99);
            Console.WriteLine("Умножение: " + lib.Multiply(4, 5));
            Console.WriteLine(lib.MakeTitle("Dimasik"));
            Console.WriteLine("Богатый: " + lib.IsRish(player.Balance));
            Console.ReadLine();
        }
        public static int Sum(int a, int b) { return a + b; }
        private static string GetStatus(string nick) { return "Игрок: " + nick; }
    }
}
