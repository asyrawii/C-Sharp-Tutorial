using System;
using System.IO;

namespace Tutorial2
{
    class Rectangle
    {

        // member variables
        //double length;
        //double width;

        public void Acceptdetails()
        {
            //length = 4.5;
            //width = 3.5;
        }
        public double GetArea(double x, double y)
        {
            return x * y;
        }
        public void Display(double x, double y)
        {
            // Ways of displaying 
            Console.WriteLine("Length and width: {0} {1}", x, y);
            Console.WriteLine($"Width: {y}");
            Console.WriteLine("Area: {0}", GetArea(x, y));
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            //r.Acceptdetails();
            Console.WriteLine("Enter length: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            double y = Convert.ToDouble(Console.ReadLine());
            r.Display(x, y);
            Console.ReadLine();
        }
    }
}
