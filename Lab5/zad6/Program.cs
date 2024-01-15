namespace Lab5zad6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> list = new MyList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.PrintList();

            list.Insert(0, 70);
            list.PrintList();

            list.RemoveAt(3);
            list.PrintList();

            list.RemoveAt(4);
            list.PrintList();

            list.PrintEvenNumbers();

        }
    }
}