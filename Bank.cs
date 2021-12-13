using System;
using System.Collections.Generic;
using System.Text;

namespace DU
{
    class Bank
    {

        public string Name { get; set; }
        public int Money { get; set; }
        public double Pujcka { get; set; }

        public Bank(string name, int money, double pujcka)
        {
            Name = name;
            Money = money;
            Pujcka = pujcka;
        }

        public override string ToString()
        {
            return Name + ", " + Money + ", " + Pujcka;
        }
    }
}
