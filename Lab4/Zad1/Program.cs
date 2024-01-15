using Lab4zad1;

class Program
{
    static void Main()
    {
        List<Shape> shapes = new List<Shape>();

        shapes.Add(new Rectangle { X = 1, Y = 2, Height = 5, Width = 10 });
        shapes.Add(new Triangle { X = 3, Y = 4, Height = 6, Width = 12 });
        shapes.Add(new Circle { X = 5, Y = 6, Height = 8, Width = 8 });

        foreach (var shape in shapes)
        {
            shape.Draw();
        }
    }
}