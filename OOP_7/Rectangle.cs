using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_7
{
    public class Rect
    {

       private int width, height;

        public Rect(int width, int heigth)
        {
           this.width = width;
            this.height = heigth;
        }


        //public int X { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        

        public void GetPerimeter()
        {
            Console.WriteLine($"Perimeter is: {height*2+width*2}");
        }

        public void GetSquare()
        {
            Console.WriteLine($"Square = {width*height}");

        }
    }
}
