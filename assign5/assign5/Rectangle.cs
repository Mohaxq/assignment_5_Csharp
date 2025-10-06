using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assign5
{
    internal struct Rectangle
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public void setLength(double len)
        {
            if (len < 0)
            {
                Console.WriteLine("error, you should not enter negative value in length");
                return;
            }
            length = len;
        }
        public void setWidth(double wid)
        {
            if (wid < 0)
            {
                Console.WriteLine("error, you should not enter negative value in width");
                return;
            }
            width = wid;
        }

        public double getlength()
        {
            return length;
        }

        public double getwidth()
        {
            return width;
        }

        public double Area()
        {
            return length * width;
        }
        
        public void display()
        {
            Console.WriteLine($"Length: {length}, Width: {width}, Area: {Area()}");
        }
    }
}
