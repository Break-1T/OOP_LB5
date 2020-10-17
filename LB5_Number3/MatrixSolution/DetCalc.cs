using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LB5_Number3.MatrixSolution
{
    class DetCalc
    {
        public DetCalc(Matrix _matrix)
        {
            this.CalcMatrix = _matrix;
        }

        const double NoElement = -5547948.1549473;

        Matrix CalcMatrix;

        public double GetDet()
        {
            if (CalcMatrix.Rows != CalcMatrix.Collums)
                return 0;
            if (CalcMatrix.Rows == 2 && CalcMatrix.Collums == 2)
                return DetTwo(CalcMatrix._Matrix);
            if (CalcMatrix.Rows == 3 && CalcMatrix.Collums == 3)
                return DetThird(CalcMatrix._Matrix);

            double[,] InputMas = CalcMatrix._Matrix;
            int rows = CalcMatrix.Rows;
            double sum = 0;

            for(int i = 0; i < rows; i++)
            {
                sum += (InputMas[0, i] * DetThird(AlgebraicComplement(0, i, InputMas)));
            }
            return sum;            
        }
        public double DetThird(double[,] mas)
        {
            double result1 = (mas[0, 0] * mas[1, 1] * mas[2, 2]) + (mas[0, 1] * mas[1, 2] * mas[2, 0]) + (mas[0, 2] * mas[1, 0] * mas[2, 1]);
            double result2 = (mas[0, 2] * mas[1, 1] * mas[2, 0]) + (mas[0, 1] * mas[1, 0] * mas[2, 2]) + (mas[0, 0] * mas[1, 2] * mas[2, 1]);
            return result1 - result2;
        }
        public double DetTwo(double[,] mas)
        {
            double result1 = (mas[0, 0] * mas[1,1]);
            double result2 = (mas[0, 1] * mas[1, 0]);
            return result1 - result2;
        }
        private double[,] Minor(int a, int b, double[,] mas)
        {
            int collums = mas.GetUpperBound(0) + 1;
            int rows = mas.Length/collums;
            double[,] inputmatrix = new double[rows,collums];
            //Copy mas -> inputmas
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < collums; j++)
                {
                    inputmatrix[i, j] = mas[i, j];
                }
            }

            double[,] result = new double[rows-1, collums-1];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < collums; j++)
                {
                    if (i == a)
                    {
                        inputmatrix[i, j] = NoElement;
                    }
                }
            }
            for(int j = 0; j < collums; j++)
            {
                for(int i = 0; i < rows; i++)
                {
                    if (j == b)
                    {
                        inputmatrix[i,j] = NoElement;
                    }
                }
            }

            double[] pointmas = new double[inputmatrix.Length];
            int count = 0;
            foreach(double i in inputmatrix)
            {
                pointmas[count] = i;
                count++;
            }

            var templist = from nums in pointmas
                 where nums != NoElement
                 select nums;
            pointmas = new double[templist.Count()];
            pointmas = templist.ToArray();

            count = 0;

            for(int i = 0; i < rows - 1; i++)
            {
                for(int j = 0; j < collums - 1; j++)
                {
                    result[i, j] = pointmas[count];
                    count++;
                }
            }
            return result;
        }
        private double[,] AlgebraicComplement(int row, int collum, double[,] mas)
        {
            double[,] resultMas = Minor(row, collum, mas);
            int collums = resultMas.GetUpperBound(0) + 1;
            int rows = resultMas.Length / collums;
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < collums; j++)
                {
                    if ((row + collum) % 2 != 0)
                    {
                        resultMas[i, j] *= -1d;
                    }
                }
            }
            return resultMas;
        }
    }
}
