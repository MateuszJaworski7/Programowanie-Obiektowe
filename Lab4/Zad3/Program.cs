using Lab4zad3;

class Program
{
    static void Main()
    {
        List<IOsoba> listaOsob = new List<IOsoba>();

        Osoba osoba1 = new Osoba { Imie = "Jan", Nazwisko = "Ziemowit" };
        Osoba osoba2 = new Osoba { Imie = "Anna", Nazwisko = "Nowak" };
        Osoba osoba3 = new Osoba { Imie = "Piotr", Nazwisko = "Kowalski" };

        listaOsob.Add(osoba1);
        listaOsob.Add(osoba2);
        listaOsob.Add(osoba3);

        Console.WriteLine("Lista osób przed sortowaniem:");
        listaOsob.WypiszOsoby();

        listaOsob.PosortujOsobyPoNazwisku();

        Console.WriteLine("\nLista osób po sortowaniu:");
        listaOsob.WypiszOsoby();



        IStudent student1 = new StudentWSIiZ
        {
            Imie = "Mateusz",
            Nazwisko = "Jaworski",
            Uczelnia = "WSIiZ",
            Kierunek = " IID-P",
            Rok = 2022,
            Semestr = 3,
            Specjalizacja = "Programowanie"
        };

        Console.WriteLine(student1.ZwrocPelnaNazwe());

        StudentWSIiZ student2 = new StudentWSIiZ
        {
            Imie = "Anna",
            Nazwisko = "Nowak",
            Uczelnia = "WSIiZ",
            Kierunek = "TI",
            Rok = 2020,
            Semestr = 2,
            Specjalizacja = "Sieci Komputerowe"
        };

        listaOsob.Add(student1);
        listaOsob.Add(student2);

        Console.WriteLine("Lista osób przed sortowaniem:");
        listaOsob.WypiszOsoby();

        listaOsob.PosortujOsobyPoNazwisku();

        Console.WriteLine("\nLista osób po sortowaniu:");
        listaOsob.WypiszOsoby();
    }
}