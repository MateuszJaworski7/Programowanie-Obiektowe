using Lab5zad5;

class Program
{
    static void Main()
    {
        WlasneDane originalObject = new WlasneDane(42, "Witaj, Świecie!");

        try
        {
            WlasneDane copiedObject = Kopia.Copy(originalObject);

            Console.WriteLine("Oryginalny obiekt: " + originalObject.Number + " - " + originalObject.Text);
            Console.WriteLine("Kopia obiektu: " + copiedObject.Number + " - " + copiedObject.Text);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Błąd: " + ex.Message);
        }
    }
}