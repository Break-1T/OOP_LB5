using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;

namespace LB5_Number1.SquareSolution
{
    class CreateSquare
    {
        public CreateSquare(CreatePoint Point)
        {
            this.Point = Point;
        }

        CreatePoint Point { get; set; }

        public CreatePoint PointA() => Point;
        public CreatePoint PointB()
        {
            CreatePoint pointB = new CreatePoint();
            pointB.X = Point.X + Point.Length;
            pointB.Y = Point.Y;
            pointB.Length = Point.Length;

            return pointB;
        }
        public CreatePoint PointC()
        {
            CreatePoint pointC = new CreatePoint();
            pointC.X = Point.X + Point.Length;
            pointC.Y = Point.Y-Point.Length;

            return pointC;
        }
        public CreatePoint PointD()
        {
            CreatePoint pointD = new CreatePoint();
            pointD.X = Point.X;
            pointD.Y = Point.Y-Point.Length;

            return pointD;
        }

    }
}
