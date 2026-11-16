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
    }
}
