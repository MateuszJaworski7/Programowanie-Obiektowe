using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3zad2
{
    internal class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Nadwozie { get; set; }
        public string Kolor { get; set; }
        public int RokProdukcji { get; set; }
        public double Przebieg { get; set; }

        public Samochod()
        {
            Console.WriteLine("Podaj dane samochodu:");
            Console.Write("Marka: ");
            Marka = Console.ReadLine();

            Console.Write("Model: ");
            Model = Console.ReadLine();

            Console.Write("Nadwozie: ");
            Nadwozie = Console.ReadLine();

            Console.Write("Kolor: ");
            Kolor = Console.ReadLine();

            Console.Write("Rok produkcji: ");
            RokProdukcji = Convert.ToInt32(Console.ReadLine());

            Console.Write("Przebieg: ");
            Przebieg = Math.Max(0, Convert.ToDouble(Console.ReadLine()));
        }
        public Samochod(string marka, string model, string nadwozie, string kolor, int rokProdukcji, double przebieg)
        {
            Marka = marka;
            Model = model;
            Nadwozie = nadwozie;
            Kolor = kolor;
            RokProdukcji = rokProdukcji;
            Przebieg = Math.Max(0, przebieg);
        }

        public virtual void WyswietlInformacje()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Nadwozie: {Nadwozie}");
            Console.WriteLine($"Kolor: {Kolor}");
            Console.WriteLine($"Rok produkcji: {RokProdukcji}");
            Console.WriteLine($"Przebieg: {Przebieg} km");
        }
    }

}
