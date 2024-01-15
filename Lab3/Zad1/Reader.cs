using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Reader : Person
    {
        private List<Book> readBooks;

        public List<Book> ReadBooks
        {
            get { return readBooks; }
        }

        public Reader(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            readBooks = new List<Book>();
        }

        public void AddReadBook(Book book)
        {
            readBooks.Add(book);
        }

        public virtual void ViewBooks()
        {
            Console.WriteLine($"Przeczytane książki przez {FirstName} {LastName}:");

            foreach (var book in readBooks)
            {
                book.View();
                Console.WriteLine();  // Dodaj pustą linię między książkami
            }
        }
    }


}
