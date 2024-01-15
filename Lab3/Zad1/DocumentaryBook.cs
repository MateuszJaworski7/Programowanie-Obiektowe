using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class DocumentaryBook : Book
    {
        private string documentaryTopic;

        public string DocumentaryTopic
        {
            get { return documentaryTopic; }
            set { documentaryTopic = value; }
        }

        public DocumentaryBook(string title, Person author, string releaseDate, string documentaryTopic)
            : base(title, author, releaseDate)
        {
            DocumentaryTopic = documentaryTopic;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Documentary Topic: {DocumentaryTopic}");
        }
    }
}
