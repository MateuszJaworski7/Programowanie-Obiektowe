using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad3
{
    public interface IStudent : IOsoba
    {
        string Uczelnia { get; set; }
        string Kierunek { get; set; }
        int Rok { get; set; }
        int Semestr { get; set; }
    }
}
