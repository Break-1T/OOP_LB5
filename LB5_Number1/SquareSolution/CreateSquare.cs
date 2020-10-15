using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media.Animation;

namespace LB5_Number1.SquareSolution
{
    class CreateSquare
    {
        public CreateSquare() { }
        public CreateSquare(CreatePoint BasePoint)
        {
            this.BasePoint = BasePoint;
        }
        public CreatePoint BasePoint;
        //Получение точек
        public virtual CreatePoint GetPointA()
        {
            return BasePoint;
        }
        public virtual CreatePoint GetPointB()
        {
            CreatePoint pointB = new CreatePoint();
            pointB.X = BasePoint.X + BasePoint.Length;
            pointB.Y = BasePoint.Y;
            pointB.Length = BasePoint.Length;

            return pointB;
        }
        public virtual CreatePoint GetPointC()
        {
            CreatePoint pointC = new CreatePoint();
            pointC.X = BasePoint.X + BasePoint.Length;
            pointC.Y = BasePoint.Y + BasePoint.Length;

            return pointC;
        }
        public virtual CreatePoint GetPointD()
        {
            CreatePoint pointD = new CreatePoint();
            pointD.X = BasePoint.X;
            pointD.Y = BasePoint.Y + BasePoint.Length;

            return pointD;
        }

        //Передвижение фигуры
        public CreateSquare MoveLeft()
        {
            return new CreateSquare(BasePoint.Left);
        }
        public CreateSquare MoveRight()
        {
            return new CreateSquare(BasePoint.Right);
        }
        public CreateSquare MoveUP()
        {
            return new CreateSquare(BasePoint.UP);
        }
        public CreateSquare MoveDown()
        {
            return new CreateSquare(BasePoint.Down);
        }
    }
}
