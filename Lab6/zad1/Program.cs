namespace Lab6zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Napisz program pozwalający na zapisanie do pliku o wskazanej nazwie, nr albumu osoby, któranapisała program.

            Console.WriteLine("Podaj numer labumu, który ma być zapisany do pliku: ");
            string newContent = Console.ReadLine();
            File.WriteAllText("test.txt", newContent);

        }
    }
}