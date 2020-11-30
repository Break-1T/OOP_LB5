using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LB5_Number3.MatrixSolution
{
    class DetCalc
    {
        private const double NoElement = -5547948.1549473;

        public static double GetDet(double[,] inputmas)
        {
            int collums = inputmas.GetUpperBound(0) + 1;
            int rows = inputmas.Length / collums;
            if (rows != collums)
            {
                Console.WriteLine("Количество строк не равно количнству столбцов!");
                return 0;
            }
            if (rows == 2 && collums == 2)
                return DetTwo(inputmas);
            if (rows == 3 && collums == 3)
                return DetThird(inputmas);

            double sum = 0;

            for(int i = 0; i < rows; i++)
            {
                sum += (inputmas[0, i] * GetDet(AlgebraicComplement(0, i, inputmas)));
            }
            return sum;            
        }
        private static double DetThird(double[,] mas)
        {
            double result1 = (mas[0, 0] * mas[1, 1] * mas[2, 2]) + (mas[0, 1] * mas[1, 2] * mas[2, 0]) + (mas[0, 2] * mas[1, 0] * mas[2, 1]);
            double result2 = (mas[0, 2] * mas[1, 1] * mas[2, 0]) + (mas[0, 1] * mas[1, 0] * mas[2, 2]) + (mas[0, 0] * mas[1, 2] * mas[2, 1]);
            return result1 - result2;
        }
        private static double DetTwo(double[,] mas)
        {
            double result1 = (mas[0, 0] * mas[1,1]);
            double result2 = (mas[0, 1] * mas[1, 0]);
            return result1 - result2;
        }
        private static double[,] Minor(int a, int b, double[,] mas)
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
        private static double[,] AlgebraicComplement(int row, int collum, double[,] mas)
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
