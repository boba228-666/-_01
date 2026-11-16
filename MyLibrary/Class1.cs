using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class Class1
    {
        public void SayHi()
        {
            Console.WriteLine("Привет из DLL!");
        }
        public void ShowScore(int score)
        {
            Console.WriteLine("Очки: " + score);
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public string MakeTitle(string name)
        {
            return "Мастер " + name;
        }
        public bool IsRish(double balance)
        {
            return balance > 100;
        }
    }
}
