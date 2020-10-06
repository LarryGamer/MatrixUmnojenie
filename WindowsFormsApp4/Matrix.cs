using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Matrix
    {
        public int[,] mas;
        public int rowsSize;
        public int columnSize;
        public int a;
        Random rnd = new Random();

        public int this [int i,int j]
        {
            get
            {
                return mas[i, j];
            }
            set
            {
                mas[i, j] = value;
            }
        }
        //public Matrix()
        //{
        //    rowsSize = rnd.Next(3, 6);
        //    columnSize = rnd.Next(3, 7);
        //    mas = new int[rowsSize, columnSize];
        //}

        public Matrix(int columns, int rows)
        {
            rowsSize = rows;
            columnSize = columns;
            mas = new int[rowsSize, columnSize];

        }

        public static Matrix operator*(Matrix M1, Matrix M2)
        {
            if (M1.columnSize==M2.rowsSize)
            {
                Matrix M3 = new Matrix(M1.rowsSize, M2.columnSize);

                for (int i = 0; i < M1.rowsSize; i++)
                {
                    for (int j = 0; j < M2.columnSize; j++)
                    {
                        for (int k=0; k < M1.columnSize; k++)
                        {
                            M3[i, j] += M1[i, k] * M2[k, j];
                        }
                    }
                }

                return M3;
            }
            else
            {
                throw new Exception(" ");
            }
        }
    }
}
