using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number3.MatrixSolution
{
    class UpperTriangularMatrix :Matrix
    {
        public UpperTriangularMatrix(int Rows, int Collums) : base(Rows, Collums)
        {
            int j = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int k = j; k < Collums; k++)
                    _Matrix[i, k] = 1;
                j++;
            }
        }

        public override void Add()
        {
            Console.WriteLine($"Размерность матрицы {Rows}х{Collums}");
            
            int j = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int k=j; k < Collums; k++)
                {
                    Console.Write($"_Matrix[{i + 1},{k + 1}] = ");
                    _Matrix[i, k] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
                j++;
            }
        }
    }
}
