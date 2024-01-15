using Lab3zad2;

class Program
{
    static void Main()
    {
        SamochodOsobowy samochodOsobowy = new SamochodOsobowy();

        Samochod samochod1 = new Samochod("Ford", "Focus", "Sedan", "Czerwony", 2022, 15000);
        Samochod samochod2 = new Samochod();

        Console.WriteLine("Informacje o samochodzie osobowym:");
        samochodOsobowy.WyswietlInformacje();

        Console.WriteLine("Informacje o samochodzie 1:");
        samochod1.WyswietlInformacje();

        Console.WriteLine("Informacje o samochodzie 2:");
        samochod2.WyswietlInformacje();
    }
}