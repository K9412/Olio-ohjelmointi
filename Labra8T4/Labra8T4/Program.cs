using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra8T4
{
    abstract class Shape
    {
        public string Name { get; set; }

        abstract public double Area();
        abstract public double Circumference();
    }
    class Circle : Shape
    {
        public double Pi { get { return 3.14; } }
        public double Radius { get; }

        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
        }
        public override double Area()
        {
            return Pi * (Radius * Radius);
        }
        public override double Circumference()
        {
            return Pi * (Radius * 2);
        }
        public override string ToString()
        {
            return Name + " Radius=" + Radius + " Area=" + Area() + " Circumference=" + Circumference() + "\n";
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; }
        public double Height { get; }

        public Rectangle(double width, double height)
        {
            Name = "Rectangle";
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
        public override double Circumference()
        {
            return (Width * 2) + (Height * 2);
        }
        public override string ToString()
        {
            return Name + " Width=" + Width + " Height=" + Height + " Area=" + Area() + " Circumference="
                                                                                    + Circumference() + "\n";
        }
    }
    class Shapes
    {
        private List<Shape> shapes;

        public Shapes()
        {
            shapes = new List<Shape>();
        }
        public void Add(Shape shape)
        {
            shapes.Add(shape);
        }
        public override string ToString()
        {
            string temp = "";
            foreach (Shape shape in shapes)
            {
                temp += shape.ToString();
            }
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle0 = new Circle(1);
            Circle circle1 = new Circle(2);
            Circle circle2 = new Circle(3);
            Rectangle rectangle0 = new Rectangle(10, 20);
            Rectangle rectangle1 = new Rectangle(20, 30);
            Rectangle rectangle2 = new Rectangle(40, 50);

            Shapes shapes = new Shapes();
            shapes.Add(circle0);
            shapes.Add(circle1);
            shapes.Add(circle2);
            shapes.Add(rectangle0);
            shapes.Add(rectangle1);
            shapes.Add(rectangle2);

            Console.WriteLine(shapes.ToString());
        }
    }
}
