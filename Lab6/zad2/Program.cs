namespace Lab6zad2 { 
    internal class Program
    {
        static void Main(string[] args)
        {
            if (File.Exists("test1.txt"))
            {
                string content = File.ReadAllText("test1.txt");
                Console.WriteLine("Zawartość pliku:");
                Console.WriteLine(content);
            }
        }
    }
}