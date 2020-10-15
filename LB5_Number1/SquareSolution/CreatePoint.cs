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
            this.X = X+311d;
            this.Y = -Y+240d;
            this.Length = Length;
        }

        public double X { get; set; }
        public double Y { get; set; }
        public double Length { get; set; }

        public CreatePoint Left
        {
            get
            {
                CreatePoint LeftPoint = new CreatePoint();
                LeftPoint.X = X-10d;
                LeftPoint.Y = Y;
                LeftPoint.Length = Length;
                return LeftPoint;
            }
        }
        public CreatePoint Right
        {
            get
            {
                CreatePoint RightPoint = new CreatePoint();
                RightPoint.X = X+10d;
                RightPoint.Y = Y;
                RightPoint.Length = Length;
                return RightPoint;
            }
        }
        public CreatePoint UP
        {
            get
            {
                CreatePoint UpPoint = new CreatePoint();
                UpPoint.X = X;
                UpPoint.Y = Y-10d;
                UpPoint.Length = Length;
                return UpPoint;
            }
        }
        public CreatePoint Down
        {
            get
            {
                CreatePoint DownPoint = new CreatePoint();
                DownPoint.X = X;
                DownPoint.Y = Y+10d;
                DownPoint.Length = Length;
                return DownPoint;
            }
        }
    }
}
