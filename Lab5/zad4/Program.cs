using Lab5zad4;

class Program
{
    static void Main()
    {
        Przykład originalObject = new Przykład(42, "Witaj, Świecie!");

        try
        {
            Przykład copiedObject = Kopia.Copy(originalObject);
            Console.WriteLine("Oryginalny obiekt: " + originalObject.Number + " - " + originalObject.Text);
            Console.WriteLine("Kopia obiektu: " + copiedObject.Number + " - " + copiedObject.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
    }
}