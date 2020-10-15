using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number2.BellSolution
{
    class FrustumCalc : BellCalc
    {
        public FrustumCalc(double H,double R,double R2) : base(H, R)
        {
            this.R2 = R2;
        }

        public double R2 { get; set; }
        public override double BellSize
        {
            get
            {
                return PI*H*(Math.Pow(R,2)+R*R2+Math.Pow(R2,2))/3d;
            }
        }
        public override void ShowBaseSize()
        {
            base.ShowBaseSize();
        }
    }
}
