using System;

namespace Tutorial2
{
    class Rectangle
    {

        // member variables
        double length;
        double width;

        public void Acceptdetails()
        {
            length = 4.5;
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            // Ways of displaying 
            Console.WriteLine("Length and width: {0} {1}", length, width);
            Console.WriteLine($"Width: {width}");
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    class ExecuteRectangle
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
