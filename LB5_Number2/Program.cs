using LB5_Number2.BellSolution;
using System;

namespace LB5_Number2
{
    class Program
    {
        static void Main(string[] args)
        {
            BellCalc bell = new BellCalc(25,5);
            bell.ShowBaseArea();
            bell.ShowBaseSize();

            FrustumCalc frustum = new FrustumCalc(25, 5, 10);
            frustum.ShowBaseSize();
        }
    }
}
