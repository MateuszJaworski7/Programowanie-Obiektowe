using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad3
{
    public static class ListOsobRozszerzenie
    {
        public static void WypiszOsoby(this List<IOsoba> listaOsob)
        {
            foreach (var osoba in listaOsob)
            {
                Console.WriteLine($"{osoba.Imie} {osoba.Nazwisko}");
            }
        }

        public static void PosortujOsobyPoNazwisku(this List<IOsoba> listaOsob)
        {
            listaOsob.Sort((os1, os2) => os1.Nazwisko.CompareTo(os2.Nazwisko));
        }
    }
}
