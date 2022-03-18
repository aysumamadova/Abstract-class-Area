using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract_class.Models
{
    class Rectangular:Figure
    {
        public double width { get; set; }
        public double length { get; set; }

        public Rectangular(double width,double length)
        {
            this.width =width;
            this.length = length;
        }

        public override double CalcArea()
        {
            return (width*length);
        }



    }
}
