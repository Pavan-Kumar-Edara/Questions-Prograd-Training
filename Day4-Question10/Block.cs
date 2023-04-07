using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question
{
    public class Block
    {
        public int width;
        public int length;
        public int height;

        public Block(int[] dimensions)
        {
            this.width = dimensions[0];
            this.length = dimensions[1];
            this.height = dimensions[2];
        }

        public int GetWidth()
        {
            return width;
        }

        public int GetLength()
        {
            return length;
        }

        public int GetHeight()
        {
            return height;
        }

        public int GetVolume()
        {
            return width * length * height;
        }

        public int GetSurfaceArea()
        {
            return 2 * (width * length + width * height + length * height);
        }
    }
}

