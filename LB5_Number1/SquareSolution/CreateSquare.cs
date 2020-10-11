using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;

namespace LB5_Number1.SquareSolution
{
    class CreateSquare
    {
        public CreateSquare() { }
        public CreateSquare(CreatePoint PointA)
        {
            this.PointA = PointA;
        }

        private CreatePoint _pointB;
        private CreatePoint _pointC;
        private CreatePoint _pointD;

        public CreatePoint PointA { get; set; }
        public CreatePoint PointB
        {
            get
            {
                CreatePoint pointB = new CreatePoint();
                pointB.X = PointA.X + PointA.Length;
                pointB.Y = PointA.Y;
                pointB.Length = PointA.Length;

                return pointB;
            }
            set
            {
                _pointB = value;
            }
        }
        public CreatePoint PointC
        {
            get
            {
                CreatePoint pointC = new CreatePoint();
                pointC.X = PointA.X + PointA.Length;
                pointC.Y = PointA.Y + PointA.Length;

                return pointC;
            }
            set
            {
                _pointC = value;
            }
        }
        public CreatePoint PointD
        {
            get
            {
                CreatePoint pointD = new CreatePoint();
                pointD.X = PointA.X;
                pointD.Y = PointA.Y + PointA.Length;

                return pointD;
            }
            set
            {
                _pointD = value;
            }
        }

        public CreateSquare MoveLeft()
        {
            return new CreateSquare(PointA.Left);
        }
        public CreateSquare MoveRight()
        {
            return new CreateSquare(PointA.Right);
        }
    }
}
