using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4zad1
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Rysuję trójkąt o współrzędnych ({X}, {Y}), wysokość: {Height}, szerokość: {Width}");
        }
    }
}
