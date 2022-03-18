using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class.Models
{
     class Square:Figure
    {
        public double side { get; set; }
        public Square(double side)
        {
            this.side = side;
        }
        public override double CalcArea()
        {
            return (side * side);
        }

    }
}
