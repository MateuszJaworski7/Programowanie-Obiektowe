using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Book
    {
        protected string title;
        protected Person author;
        protected string releaseDate;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public Person Author
        {
            get { return author; }
            set { author = value; }
        }

        public string ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = value; }
        }

        public Book(string title, Person author, string releaseDate)
        {
            Title = title;
            Author = author;
            ReleaseDate = releaseDate;
        }

        public virtual void View()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine("Author:");
            Author.View();
            Console.WriteLine($"Release Date: {ReleaseDate}");
        }
    }


}
