using System;
using System.Collections.Generic;

public class StartUp
{
    public static void Main()
    {
        Shape circle = new Circle(2.2);
        Shape rectangle = new Rectangle(2, 5);

        var listOfShapes = new List<Shape>();
        listOfShapes.Add(circle);
        listOfShapes.Add(rectangle);

        foreach (var shape in listOfShapes)
        {
            Console.WriteLine(shape.Draw());
            Console.WriteLine(shape.CalculatePerimeter());
            Console.WriteLine(shape.CalculateArea());
        }
    }
}
