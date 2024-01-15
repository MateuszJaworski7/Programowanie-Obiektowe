namespace Lab6zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> pesels = new List<string>(File.ReadAllLines("pesels.txt"));

            int femaleCount = 0;

            foreach (var pesel in pesels)
            {
                if (pesel.Length == 11)
                {
                    if (int.Parse(pesel.Substring(9, 1)) % 2 == 0)
                    {
                        femaleCount++;
                    }
                }
            }
            Console.WriteLine(femaleCount);

        }
    }
}