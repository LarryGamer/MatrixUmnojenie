using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        private Matrix[] matrixes;
        private Matrix resultMatrix;

        public Form1()
        {
            
            InitializeComponent();

            ////Привязка первой
            //dataGridView1.RowCount = int.Parse(tbColumns1.Text);
            //dataGridView1.ColumnCount = int.Parse(tbRows1.Text);
            //int i = 0;
            //int j = 0;
            //int[,] mas1 = new int[i, j];
            //for (i = 0; i < int.Parse(tbColumns1.Text); ++i)
            //    for (j = 0; j < int.Parse(tbRows1.Text); ++j)
            //        dataGridView1.Rows[i].Cells[j].Value = mas1[i, j];

            ////Привязка второй
            //dataGridView2.RowCount = int.Parse(tbColumns2.Text);
            //dataGridView2.ColumnCount = int.Parse(tbRows2.Text);
            //int[,] mas2 = new int[i, j];
            //for (i = 0; i < int.Parse(tbColumns1.Text); ++i)
            //    for (j = 0; j < int.Parse(tbRows1.Text); ++j)
            //        dataGridView1.Rows[i].Cells[j].Value = mas2[i, j];
        }

        private void MatrixAndDataGridViewSizeCheck(Matrix matrix, DataGridView dataGridView) {
            if (matrix.Rows != dataGridView.RowCount || matrix.Columns != dataGridView.ColumnCount)
                throw new Exception();
        }

        private void InitDataGridView(DataGridView dataGridView, int rows, int columns) {
            dataGridView.RowCount = rows;
            dataGridView.ColumnCount = columns;
        }

        private void InitMatrixes() {
            matrixes = new Matrix[2] {
                new Matrix(int.Parse(tbRows1.Text), int.Parse(tbColumns1.Text)),
                new Matrix(int.Parse(tbRows2.Text), int.Parse(tbColumns2.Text))
            };

            InitDataGridView(dataGridView1, int.Parse(tbRows1.Text), int.Parse(tbColumns1.Text));
            InitDataGridView(dataGridView2, int.Parse(tbRows2.Text), int.Parse(tbColumns2.Text));
            UpdateDataGridView(matrixes[0], dataGridView1);
            UpdateDataGridView(matrixes[1], dataGridView2);
        }

        private void FillMatrixes() {
            if (matrixes == null)
                throw new Exception();

            Random rnd = new Random();
            foreach (Matrix matrix in matrixes) {
                matrix.FillMatrix(rnd);
            }

            UpdateDataGridView(matrixes[0], dataGridView1);
            UpdateDataGridView(matrixes[1], dataGridView2);
        }

        private void MultMatrixes() {
            UpdateMatrix(matrixes[0], dataGridView1);
            UpdateMatrix(matrixes[1], dataGridView2);

            resultMatrix = matrixes[0] * matrixes[1];


            InitDataGridView(dataGridView3, resultMatrix.Rows, resultMatrix.Columns);
            UpdateDataGridView(resultMatrix, dataGridView3);
        }

        private void UpdateDataGridView(Matrix matrix, DataGridView dataGridView, int decimals = 2) {
            MatrixAndDataGridViewSizeCheck(matrix, dataGridView);

            for (int i = 0; i < matrix.Rows; i++) 
                for (int j = 0; j < matrix.Columns; j++) 
                    dataGridView[j, i].Value = Math.Round(matrix[i, j], decimals);
        }

        private void UpdateMatrix(Matrix matrix, DataGridView dataGridView) {
            MatrixAndDataGridViewSizeCheck(matrix, dataGridView);

            for (int i = 0; i < matrix.Rows; i++)
                for (int j = 0; j < matrix.Columns; j++)
                    matrix[i, j] = (double)dataGridView[j, i].Value;
        }

        private void GenerateMatrixes() {
            try {
                InitMatrixes();
            } catch {
                MessageBox.Show("Данные введены некорректно");
            }
        }

        private void FillMatrixesMethod() {
            try {
                FillMatrixes();
            } catch {
                return;
            }
        }

        private void Multiply() {
            try {
                MultMatrixes();
            } catch {
                MessageBox.Show("Ошибка в умножении");
            }
        }

        private void generatorMatrix_Click(object sender, EventArgs e) => GenerateMatrixes();

        private void fillButton_Click(object sender, EventArgs e) => FillMatrixesMethod();

        private void multButton_Click(object sender, EventArgs e) => Multiply();
    }
}
