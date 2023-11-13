using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class Data
    {
        public DateTime data;

        public Data()
        {
            data = DateTime.Now;

        }
        public void Tydzien1()
        {
            data = data.AddDays(7);
        }

        public void Tydzien2()
        {
            data = data.AddDays(-7);
        }
    }
}