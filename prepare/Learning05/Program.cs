using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");

        List<Shape> objects = new List<Shape>(); 

        Square shape1 = new Square("Red", 25);
        objects.Add(shape1);

        Rectangle shape2 = new Rectangle("Blue", 8, 6);
        objects.Add(shape2);

        Circle shape3 = new Circle("Green", 6);
        objects.Add(shape3); 

        foreach(Shape shape in objects)
        {
            string color = shape.GetShape();

            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }
       
    }
}