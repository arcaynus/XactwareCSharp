using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_Properties
{
    class Ball
    {
        public int Size { get; set; } = 1;
        Color color;
        private uint _timesThrown;
        public uint TimesThrown {
            get
            {
                return _timesThrown;
            }
            private set
            {
                _timesThrown = value > 0 ? value : 0;
            }
        }

        public Ball(int size, Color color)
        {
            Size = size;
            this.color = color;
        }

        public Ball(int size, byte red, byte green, byte blue)
        {
            Size = size;
            this.color = new Color(red, green, blue);
        }

        public void Pop()
        {
           Size = 0;
        }
        public void Throw()
        {
            if(Size != 0)
            this.TimesThrown++;
        }
        public uint GetTimesThown() { return TimesThrown; }
        override
        public string ToString()
        {
            return $"Size: {Size}, Color: (R {color.Red:X} G {color.Green:X} B {color.Blue:X}, Times Thrown: {TimesThrown}, Popped: {Size == 0}";
        }
    }
}
