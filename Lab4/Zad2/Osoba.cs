using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad2
{
    class Osoba
    {
        protected string imie;
        protected string nazwisko;
        protected string pesel;

        public void SetFirstName(string firstName)
        {
            imie = firstName;
        }

        public void SetLastName(string lastName)
        {
            nazwisko = lastName;
        }

        public void SetPesel(string pesel)
        {
            this.pesel = pesel;
        }

        public int GetAge()
        {
            int year = int.Parse(pesel.Substring(0, 2));
            int currentYear = DateTime.Now.Year % 100;
            return (currentYear >= year) ? currentYear - year : currentYear + 100 - year;
        }

        public char GetGender()
        {
            return pesel[9] % 2 == 0 ? 'K' : 'M';
        }

        public virtual string GetEducationInfo()
        {
            return "Osoba bez informacji o edukacji.";
        }

        public string GetFullName()
        {
            return $"{imie} {nazwisko}";
        }

        public virtual bool CanGoAloneToHome()
        {
            return GetAge() >= 18;
        }
    }
}
