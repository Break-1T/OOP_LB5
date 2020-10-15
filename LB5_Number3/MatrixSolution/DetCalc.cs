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
            this._matrix = _matrix;
        }

        const double NoElement = -5547948.1549473;

        Matrix _matrix;

        public double GetDet()
        {
            if (_matrix.Rows != _matrix.Collums)
                return 0;
            if (_matrix.Rows == 2 && _matrix.Collums == 2)
                return DetTwo(_matrix._Matrix);
            if (_matrix.Rows == 3 && _matrix.Collums == 3)
                return DetThird(_matrix._Matrix);

            double[,] InputMas = _matrix._Matrix;
            int rows = _matrix.Rows;
            int colums = _matrix.Collums;
            double result = 0;

            for(int i = 0; i < rows; i++)
            {
                result += Math.Pow(-1, i + 1) * InputMas[0, i] * DetThird(Minor(0, i, InputMas));
            }
            Console.WriteLine(result);
            return result;            
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
        public double[,] Minor(int a, int b, double[,] mas)
        {
            if (mas == null)
                throw new Exception();

            int collums = mas.GetUpperBound(0) + 1;
            int rows =mas.Length/collums;
            double[,] result = new double[rows-1, collums-1];

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < collums; j++)
                {
                    if (i == a)
                    {
                        mas[i, j] = NoElement;
                    }
                }
            }
            for(int j = 0; j < collums; j++)
            {
                for(int i = 0; i < rows; i++)
                {
                    if (j == b)
                    {
                        mas[i,j] = NoElement;
                    }
                }
            }

            double[] pointmas = new double[mas.Length];
            int count = 0;
            foreach(double i in mas)
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
        public double[,] AlgebraicComplement(int row, int collum , double [,] mas)
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
                    Console.Write(resultMas[i,j]+"\t");
                }
                Console.WriteLine();
            }
            return resultMas;
        }
    }
}
