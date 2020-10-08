using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number1.SquareSolution
{
    class CreatePoint
    {
        public CreatePoint() { }
        public CreatePoint(double X, double Y, double Length)
        {
            this.X = X;
            this.Y = Y;
            this.Length = Length;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get; set; }
        public bool Left { get; set; }
        public bool Right { get; set; }
    }
}
