using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad2
{
    class Uczen : Osoba
    {
        private string szkola;
        private bool mozeSamWracacDoDomu;

        public void SetSchool(string school)
        {
            szkola = school;
        }

        public void SetCanGoHomeAlone(bool canGoHomeAlone)
        {
            mozeSamWracacDoDomu = canGoHomeAlone;
        }

        public override string GetEducationInfo()
        {
            return $"Uczeń klasy {szkola}";
        }

        public override bool CanGoAloneToHome()
        {
            if (GetAge() < 12 && !mozeSamWracacDoDomu)
            {
                Console.WriteLine("Uczeń poniżej 12 roku życia nie może iść sam do domu bez pozwolenia.");
                return false;
            }

            return base.CanGoAloneToHome();
        }
    }
}
