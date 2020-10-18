using System;
using System.Collections.Generic;
using System.Text;

namespace LB5_Number3.MatrixSolution
{
    class Matrix
    {
        public Matrix(int Rows,int Collums)
        {
            this.Collums = Collums;
            this.Rows = Rows;
            _Matrix = new double[Rows, Collums];
        }
        public double[,] _Matrix;
        public int Rows { get; set; }
        public int Collums { get; set; }

        public virtual void Show()
        {
            Console.WriteLine(new string('-', 50));
            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Collums; j++)
                {
                    Console.Write(_Matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 50));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Det: " + DetCalc.GetDet(_Matrix));
            Console.ResetColor();
            Console.WriteLine(new string('-', 50));
        }
        public virtual void Add()
        {
            Console.WriteLine($"Размерность матрицы {Rows}х{Collums}");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Collums; j++)
                {
                    Console.Write($"_Matrix[{i + 1},{j + 1}] = ");
                    _Matrix[i, j] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                }
            }
        }
        public void Add(int Row,int Collum,double content)
        {
            if (Row < 1 || Collum < 1 || Row>this.Rows || Collum>this.Collums)
                return;
            Console.WriteLine($"Added  [{Row},{Collum}] = {content}");
            this._Matrix[Row - 1, Collum - 1] = content;
        }
        public virtual void AutoAdd()
        {
            Random random = new Random();
            Console.WriteLine($"Размерность матрицы {Rows}х{Collums}\n*Автоматическое добавление элементов*");

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Collums; j++)
                {
                    _Matrix[i, j] = random.Next(-25,50);
                }
            }
        }

        public void Delete(int Row, int Collum)
        {
            Console.WriteLine($"Deleted [{Row},{Collum}]");
            if (Row < 1 || Collum < 1 || Row > this.Rows || Collum > this.Collums)
                return;
            this._Matrix[Row - 1, Collum - 1] = 0;
        }
        public void Clear()
        {
            Console.WriteLine("Cleared");
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Collums; j++)
                {
                    _Matrix[i, j] = 0;
                }
            }
        }
    }
}
