using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_18_Making_Your_Own_Classes
{
    class Ball
    {
        int size;
        Color color;
        uint timesThrown;

        public Ball(int size, Color color)
        {
            this.size = size;
            this.color = color;
        }

        public Ball(int size, byte red, byte green, byte blue)
        {
            this.size = size;
            this.color = new Color(red, green, blue);
        }

        public void Pop()
        {
            this.size = 0;
        }
        public void Throw()
        {
            if(size != 0)
            this.timesThrown++;
        }
        public uint GetTimesThown() { return this.timesThrown; }
        override
        public string ToString()
        {
            return $"Size: {size}, Color: (R {color.GetRed():X} G {color.GetGreen():X} B {color.GetBlue():X}, Times Thrown: {timesThrown}, Popped: {size == 0}";
        }
    }
}
