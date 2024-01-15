using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad2
{
    class Nauczyciel : Uczen
    {
        private string tytulNaukowy;
        private List<Uczen> podwladniUczniowie;

        public void SetTytulNaukowy(string title)
        {
            tytulNaukowy = title;
        }

        public void AddPodwladny(Uczen uczen)
        {
            if (podwladniUczniowie == null)
            {
                podwladniUczniowie = new List<Uczen>();
            }

            podwladniUczniowie.Add(uczen);
        }

        public void RemovePodwladny(Uczen uczen)
        {
            podwladniUczniowie?.Remove(uczen);
        }

        public string TytulNaukowy
        {
            get { return tytulNaukowy; }
        }

        public List<Uczen> PodwladniUczniowie
        {
            get { return podwladniUczniowie; }
        }

        public void WhichStudentCanGoHomeAlone(DateTime dateToCheck)
        {
            if (podwladniUczniowie != null)
            {
                Console.WriteLine($"Uczniowie, którzy mogą iść sami do domu na dzień {dateToCheck}:");
                foreach (var uczen in podwladniUczniowie.Where(u => u.CanGoAloneToHome()))
                {
                    Console.WriteLine($"{uczen.GetFullName()}, Klasa: {uczen.GetEducationInfo()}");
                }
            }
            else
            {
                Console.WriteLine("Nauczyciel nie ma podwładnych uczniów.");
            }
        }
    }
}
