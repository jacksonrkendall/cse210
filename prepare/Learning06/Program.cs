using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 5.0);
        Rectangle rectangle = new Rectangle("Red", 4.0, 6.0);
        Circle circle = new Circle("Green", 3.0);

        Console.WriteLine($"Square Color: {square.Color}, Area: {square.GetArea()}");
        Console.WriteLine($"Rectangle Area: {rectangle.Color}, Area: {rectangle.GetArea()}");
        Console.WriteLine($"Circle Color: {circle.Color}, Area: {circle.GetArea()}");
    
        List<Shape> shapes = new List<Shape> { square, rectangle, circle };
        foreach (var shape in shapes)
        {
            Console.WriteLine($"Shape Color: {shape.Color}, Area: {shape.GetArea()}");
        }    
    }
}