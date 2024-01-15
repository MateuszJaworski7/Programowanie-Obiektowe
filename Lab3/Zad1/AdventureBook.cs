using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class AdventureBook : Book
    {
        private string mainCharacter;

        public string MainCharacter
        {
            get { return mainCharacter; }
            set { mainCharacter = value; }
        }

        public AdventureBook(string title, Person author, string releaseDate, string mainCharacter)
            : base(title, author, releaseDate)
        {
            MainCharacter = mainCharacter;
        }

        public override void View()
        {
            base.View();
            Console.WriteLine($"Main Character: {MainCharacter}");
        }
    }

}