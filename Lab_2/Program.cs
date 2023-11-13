

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Licz[] LiczLiczby = new Licz[5];
            LiczLiczby[0] = new Licz(1);
            LiczLiczby[1] = new Licz(2);
            LiczLiczby[2] = new Licz(3);
            LiczLiczby[3] = new Licz(4);
            LiczLiczby[4] = new Licz(5);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(LiczLiczby[i].dodaj(1));
                Console.WriteLine(LiczLiczby[i].odejmij(1));
                Console.WriteLine();
            }
            double[] liczby = { 3, 9, 12, -4, 7 };
            Sumator sumator = new Sumator(liczby);
            double suma = sumator.Suma();
            double sumaPodziel2 = sumator.SumDziel2();
            int ileElementow = sumator.IleElementów();

            Console.WriteLine($"Suma wszystkich liczb wynosi: {suma}");
            Console.WriteLine($"Suma liczb podzielnych przez 2 wynosi: {sumaPodziel2}");
            Console.WriteLine($"Liczba elementów tablicy jest równa: {ileElementow}");
            Console.WriteLine("Wszystkie elementy tablicy:");
            sumator.WypiszElem();
            Console.WriteLine("Elementy o indeksach od 0 do 2:");
            sumator.WypiszElem(0,2);

            Data data1 = new Data();
            Console.WriteLine($"Aktualna data to {data1.data}");

            data1.Tydzien1();
            Console.WriteLine($"Data za tydzień: {data1.data}");

            data1.Tydzien2();
            Console.WriteLine($"Data cofnięta o tydzień: {data1.data}");

            Liczba liczba = new Liczba("456");
            liczba.Wypisz();

            liczba.Mnozenie(7);
            liczba.Wypisz();

            liczba.Silnia(3);
            liczba.Wypisz();
        }
    }
}