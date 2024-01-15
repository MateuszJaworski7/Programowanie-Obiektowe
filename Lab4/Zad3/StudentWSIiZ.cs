using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad3
{
    public class StudentWSIiZ : Student
    {
        public string Specjalizacja { get; set; }

        public override string ZwrocPelnaNazwe()
        {
            return $"{base.ZwrocPelnaNazwe()} - {Specjalizacja}";
        }
    }
}
