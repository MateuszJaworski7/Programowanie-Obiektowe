using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Licz
    {
        private double value = 5;

        public double dodaj(double a)
        {
            value += a;
            return value;
        }
        public double odejmij(double a)
        {
            value -= a;
            return value;
        }

        public Licz(double a)
        {
            value = a;
        }
        public void Wypisz()
        {
            Console.WriteLine($"Wartość: {value}");
        }
    }
}