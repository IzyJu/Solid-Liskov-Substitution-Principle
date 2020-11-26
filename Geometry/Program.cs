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
    }

    class Square : Polygone
    {
        public double cote { get; set; }
        public override double area
        {
            get { return cote * 4; }
        }
    }
}
