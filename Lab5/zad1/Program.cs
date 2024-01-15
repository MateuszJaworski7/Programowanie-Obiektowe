using System;

class Program
{
    static void WypiszDlugoscNapisu(string napis)
    {
        try
        {
            if (napis == null)
            {
                throw new ArgumentNullException("napis", "Napis nie może być null");
            }

            int dlugosc = napis.Length;
            Console.WriteLine($"Długość napisu: {dlugosc}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wyjątek został przechwycony:");
            Console.WriteLine(ex.StackTrace);

            throw new Exception("Wystąpił błąd w trakcie przetwarzania napisu.", ex);
        }
    }

    static void Main()
    {
        try
        {
            WypiszDlugoscNapisu(null);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\nGłówny blok catch - Obsługiwany wyjątek:");
            Console.WriteLine(ex.Message);
            Console.WriteLine("Przyczyna:");
            Console.WriteLine(ex.InnerException?.Message);
        }
    }
}
