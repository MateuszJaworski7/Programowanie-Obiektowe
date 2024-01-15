using Lab3;
using System;


internal class Program
{
    static void Main()
    {
        Person Autor1 = new("Andrzej", "Kowalski", 35);
        Person Autor2 = new("Alicja", "Nowak", 28);

        Console.WriteLine("Informacje o autorze:");
        Autor1.View();

        Console.WriteLine("Informacje o innej osobie:");
        Autor2.View();

        Book book1 = new("Dowolna Książka", Autor1, "2023-01-15");

        Console.WriteLine("Informacje o książce:");
        book1.View();


        Person Autor3 = new("Jan", "Tadla", 70);
        Person Autor4 = new("Alicja", "Nowakowska", 24);

        Book book2 = new("Książka2", Autor2, "2023-02-20");
        Book book3 = new("Książka3", Autor3, "2023-03-25");
        Book book4 = new("Książka4", Autor4, "2023-04-30");
        Book book5 = new("Książka5", Autor1, "2023-05-05");

        Reader reader1 = new("Tomasz", "Śliwka", 40);
        Reader reader2 = new("Emilia", "Kowal", 32);

        reader1.ReadBooks.Add(book1);
        reader1.ReadBooks.Add(book2);
        reader1.ReadBooks.Add(book3);
        reader2.ReadBooks.Add(book4);
        reader2.ReadBooks.Add(book5);

        reader1.ViewBooks();
        Console.WriteLine();
        reader2.ViewBooks();


        Reviewer reviewer1 = new("Aleks", "Nowakowski", 18);
        Reviewer reviewer2 = new("Magda", "Majka", 45);

        reader1.AddReadBook(book1);
        reader1.AddReadBook(book2);
        reader1.AddReadBook(book3);
        reader2.AddReadBook(book4);
        reader2.AddReadBook(book5);

        reviewer1.AddReadBook(book1);
        reviewer1.AddReadBook(book2);
        reviewer2.AddReadBook(book3);
        reviewer2.AddReadBook(book4);

        List<Person> people = new()
        {
            reader1,
            reader2,
            reviewer1,
            reviewer2
        };

        foreach (var person in people)
        {
            Console.WriteLine("Informacje o osobie:");


            if (person is Reader)
            {
                ((Reader)person).ViewBooks();
            }
            else
            {
                person.View();
            }
        }
    }
}





