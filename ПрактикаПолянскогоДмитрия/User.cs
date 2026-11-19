using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ПрактикаПолянскогоДмитрия
{
    public class User
    {
        //свойства пользователя
        public string Nickname { get; set; }
        public int Level { get; set; }
        public double Balance { get; set; }
        public bool HasVacBan { get; set; }
        //публичный метод
        public int AddPoints(int a, int b)
        {
            return a + b;
        }
        //приватный метод
        private double DivideBalance(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }
        //публичный метод для вывода статистики
        public void ShowUserStats()
        {
            double halfBalance = DivideBalance(Balance, 2);
            Console.WriteLine($"Игрок: {Nickname} | Уровень: {Level} | Половина баланса: {halfBalance} | Бан: {HasVacBan}");
        }
    }
}
