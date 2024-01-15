using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5zad5
{
    public class WlasneDane : ICloneable
    {
        public int Number { get; set; }
        public string Text { get; set; }

        public WlasneDane(int number, string text)
        {
            Number = number;
            Text = text;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
