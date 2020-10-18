using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number3.MatrixSolution
{
    class SingleMatrix:Matrix
    {
        public SingleMatrix(int Rows,int Collums) : base(Rows,Collums) 
        {
            for (int i = 0; i < Rows; i++)
            {
                _Matrix[i, i] = 1;
            }
        }

        public override void Add()
        {
            Console.WriteLine($"Размерность матрицы {Rows}х{Collums}");

            for (int i = 0; i < Rows; i++)
            {
                Console.Write($"_Matrix[{i + 1},{i + 1}] = ");
                _Matrix[i, i] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
            }
        }
        public override void AutoAdd()
        {
            Random random = new Random();
            Console.WriteLine($"Размерность матрицы {Rows}х{Collums}\n*Автоматическое добавление элементов*");

            for (int i = 0; i < Rows; i++)
            {
               _Matrix[i, i] = random.Next(-25, 50);
            }
        }
    }
}
