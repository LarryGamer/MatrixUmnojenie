using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Matrix
    {
        private double[,] mass;
        private int rows;
        private int columns;

        public int Rows {
            get => rows;
        }

        public int Columns {
            get => columns;
        }

        
        

        public double this [int i,int j]
        {
            get => mass[i, j];
            set => mass[i, j] = value;
        }


        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            mass = new double[rows, columns];
        }

        public void FillMatrix(Random rnd, int min = -10, int max = 10) {
            for (int i = 0; i < this.rows; i++)
                for (int j = 0; j < this.columns; j++)
                    this.mass[i, j] = rnd.NextDouble() * rnd.Next(min, max);
        }

        public static Matrix operator*(Matrix M1, Matrix M2)
        {
            if (M1.columns==M2.rows)
            {
                Matrix M3 = new Matrix(M1.rows, M2.columns);

                for (int i = 0; i < M1.rows; i++)
                {
                    for (int j = 0; j < M2.columns; j++)
                    {
                        for (int k=0; k < M1.columns; k++)
                        {
                            M3[i, j] += M1[i, k] * M2[k, j];
                        }
                    }
                }

                return M3;
            }
            else
            {
                throw new Exception();
            }
        }
    }
}
