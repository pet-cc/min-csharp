using System;
using System.Collections.Generic;
using System.Text;

namespace Dia1.Example1
{
    class Circle : Shape
    {
        private int radius;

        public Circle() : this(0) { }

        public Circle(int radius) {
            this.radius = radius;
        }

        public int Radius {
            set
            {
                radius = value;
            }
            get
            {
                return radius;
            }
        }

        public override string Draw()
        {
            return "Drawing Circle...";
        }

        public override int GetArea()
        {
            return (this.radius * this.radius) * 3;
        }
    }
}
