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
        public string Nickname { get; set; }
        public int Level { get; set; }
        public double Balance { get; set; }
        public bool HasVacBan { get; set; }

        public int AddPoints(int a, int b)
        {
            return a + b;
        }

        private double DivideBalance(double a, double b)
        {
            if (b == 0) return 0;
            return a / b;
        }

        public void ShowUserStats()
        {
            double halfBalance = DivideBalance(Balance, 2);
            Console.WriteLine($"Игрок: {Nickname} | Уровень: {Level} | Половина баланса: {halfBalance} | Бан: {HasVacBan}");
        }
    }
}
