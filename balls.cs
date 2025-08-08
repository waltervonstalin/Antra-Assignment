using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Color
    {
        public int Red { get; private set; }
        public int Green { get; private set; }
        public int Blue { get; private set; }
        public int Alpha { get; private set; }
        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public Color(int red, int green, int blue) :this (red, green,blue,255 ){ }
        public int Getgraysclae()
        {
            return (Red + Green + Blue) / 3;
        }
    }
    public class Balls
    {
        public int Size {  get; private set; }
        public Color Color { get; private set; }
        private int throwCount;
        public Balls(int size, Color color) { 
            Size = size;
            Color = color; 
            throwCount = 0;
        }
        public void Pop() { Size = 0; }
        public void Throw()
        {
            if (Size > 0)
            {
                throwCount++;
            }
        }
        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}
