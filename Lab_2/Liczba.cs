using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3

{
    internal class Liczba
    {
        private int[] cyfry;
        public Liczba(string napis)
        {
            Konwertuj(napis);
        }
        public void Konwertuj(string napis)
        {
            int dlugosc = napis.Length;
            cyfry = new int[dlugosc];

            for (int i = 0; i < dlugosc; i++)
            {
                if (char.IsDigit(napis[i]))
                {
                    cyfry[i] = int.Parse(napis[i].ToString());
                }
                else
                {
                    Console.WriteLine("Operacja niemożliwa do wykonania");
                }
            }
        }
        public void Wypisz()
        {
            Console.WriteLine(string.Join("", cyfry));
        }
        public void Mnozenie(int x)
        {
            int reszta = 0;
            for (int i = cyfry.Length - 1; i >= 0; i--)
            {
                int wynik = cyfry[i] * x + reszta;
                cyfry[i] = wynik % 10;
                reszta = wynik / 10;
            }
            if (reszta > 0)
            {
                int[] tab = new int[cyfry.Length + 1];
                cyfry.CopyTo(tab, 1);
                tab[0] = reszta;
                cyfry = tab;
            }

        }
        public void Silnia(int n)
        {
            Konwertuj("1");
            for (int i = 2; i <= n; i++)
            {
                Mnozenie(i);
            }
        }
    }
}