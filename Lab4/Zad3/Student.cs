using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad3
{
    public class Student : IStudent
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Uczelnia { get; set; }
        public string Kierunek { get; set; }
        public int Rok { get; set; }
        public int Semestr { get; set; }

        public virtual string ZwrocPelnaNazwe()
        {
            return $"{Imie} {Nazwisko} – {Semestr}S {Rok}{Kierunek} {Uczelnia}";
        }
    }
}
