using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example1
{
    class Square : Shape
    {

        private int size;

        public Square() : this(0) { }

        public Square(int size)
        {
            this.size = size;
        }

        public int Size {
            set
            {
                size = value;
            }
            get
            {
                return size;
            }
        }

        public override string Draw()
        {
            return "Drawing Square...";
        }

        public override int GetArea()
        {
            return this.size * this.size;
        }
    }
}
