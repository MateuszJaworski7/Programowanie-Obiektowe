using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Reviewer : Reader
    {
        private Random random;

        public Reviewer(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            random = new Random();
        }

        public void WriteReview()
        {
            Console.WriteLine($"Recenzja dla czytelnika {FirstName} {LastName}:");
            foreach (var book in ReadBooks)
            {
                int rating = random.Next(1, 6);  // Losowa ocena od 1 do 5
                Console.WriteLine($"- {book.Title} - Ocena: {rating}");
            }
        }
    }

}
