using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_19_Properties
{
    class Color
    {
        private byte red;
        private byte green;
        private byte blue;
        private byte alpha;
        public byte Red
        {
            get
            {
                return red;
            }
            set
            {
                red = value > 255 ? (byte)255 : (byte)value;
            }
        }
        public byte Green
        {
            get
            {
                return green;
            }
            set
            {
                green = value > 255 ? (byte)255 : (byte)value;
            }
        }
        public byte Blue
        {
            get
            {
                return blue;
            }
            set
            {
                blue = value > 255 ? (byte)255 : (byte)value;
            }
        }
        public byte Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value > 255 ? (byte)255 : (byte)value;
            }
        }


        public Color (byte red, byte green, byte blue, byte alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }
        public Color(byte red, byte green, byte blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = 255;
        }

        public byte GetGrayScale()
        {
            return (byte)((red + green + blue) / 3);
        }

    }
}
