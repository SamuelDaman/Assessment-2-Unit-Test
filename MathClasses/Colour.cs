using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public class Colour
    {
        public UInt32 colour;
        public uint r, g, b, a;

        public Colour()
        {
            colour = 0;
        }
        public Colour(uint rVal, uint gVal, uint bVal, uint aVal)
        {
            r = rVal;
            g = gVal;
            b = bVal;
            a = aVal;
        }
        public void Set(uint x)
        {
            colour = x;
        }
        public void TrColourSetAlpha()
        {
            Colour c = new Colour();
            c.SetAlpha(0x78);

            Assert.AreEqual<UInt32>(c.colour, 0x00000056);
        }
        public void SetAlpha(uint a)
        {
            colour = colour & (uint)0xFF00FFFF;
            colour = colour | (a << 24);
        }
    }
}
