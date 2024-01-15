using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3zad2
{
    class SamochodOsobowy : Samochod
    {
        public double Waga { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int IloscOsob { get; set; }
        public SamochodOsobowy()
            : base()
        {
            Console.WriteLine("Podaj dodatkowe dane dla samochodu osobowego:");
            Console.Write("Waga (2-4,5 t): ");
            Waga = Math.Max(2, Math.Min(4.5, Convert.ToDouble(Console.ReadLine())));

            Console.Write("Pojemność silnika (0,8-3,0): ");
            PojemnoscSilnika = Math.Max(0.8, Math.Min(3.0, Convert.ToDouble(Console.ReadLine())));

            Console.Write("Ilość osób: ");
            IloscOsob = Convert.ToInt32(Console.ReadLine());
        }
        public override void WyswietlInformacje()
        {
            base.WyswietlInformacje();
            Console.WriteLine($"Waga: {Waga} t");
            Console.WriteLine($"Pojemność silnika: {PojemnoscSilnika}");
            Console.WriteLine($"Ilość osób: {IloscOsob}");
        }
    }

}
