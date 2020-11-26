using System;

namespace Geometry
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Polygone carrer = new Square { cote = 10 };
            Polygone rect = new Rectangle { height = 10, width = 8 };
            Console.WriteLine(rect.area + " est le perimetre du rectangle et " + carrer.area + " du carrer.");

        }
    }
    public abstract class Polygone
    {
        public virtual double area { get; }

    }
    class Rectangle : Polygone
    {
        public double height { get; set; }
        public double width { get; set; }
        public override double area
        {
            get{ return height * 2 + width * 2; }
        }
        public void SetWidth(double width)
        {
            this.width = width;
        }

        public void SetHeight(double height)
        {
            this.height = height;
        }
    }

    class Square : Polygone
    {
        public double cote { get; set; }
        public override double area
        {
            get { return cote * 4; }
        }
        public void SetWidth(double width)
        {
            cote = width;
        }
        public void SetHeight(double height)
        {
            cote = height;
        }
    }
}