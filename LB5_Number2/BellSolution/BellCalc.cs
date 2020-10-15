using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number2.BellSolution
{
    class BellCalc
    {
        public BellCalc(double H,double R)
        {
            this.H = H;
            this.R = R;
        }
        public double H { get; set; }
        public double R { get; set; }
        public const double PI = Math.PI;
        
        public double BaseArea
        {
            get
            {
                return PI * Math.Pow(R, 2);
            }
        }
        public virtual double BellSize
        {
            get
            {
                return (BaseArea * H) / 3d;
            }
        }

        public void ShowBaseArea()
        {
            Console.WriteLine($"Площадь нижнего основания равна: {BaseArea}");
        }
        public virtual void ShowBaseSize()
        {
            Console.WriteLine($"Объём конуса равнен: {BellSize}");
        }
    }
}
