using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad1
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuję prostokąt o współrzędnych ({X}, {Y}), wysokość: {Height}, szerokość: {Width}");
        }
    }
}
