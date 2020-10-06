using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
            //Привязка первой
            dataGridView1.RowCount = int.Parse(tbColumns1.Text);
            dataGridView1.ColumnCount = int.Parse(tbRows1.Text);
            int i = 0;
            int j = 0;
            int[,] mas1 = new int[i, j];
            for (i = 0; i < int.Parse(tbColumns1.Text); ++i)
                for (j = 0; j < int.Parse(tbRows1.Text); ++j)
                    dataGridView1.Rows[i].Cells[j].Value = mas1[i, j];

            //Привязка второй
            dataGridView2.RowCount = int.Parse(tbColumns2.Text);
            dataGridView2.ColumnCount = int.Parse(tbRows2.Text);
            int[,] mas2 = new int[i, j];
            for (i = 0; i < int.Parse(tbColumns1.Text); ++i)
                for (j = 0; j < int.Parse(tbRows1.Text); ++j)
                    dataGridView1.Rows[i].Cells[j].Value = mas2[i, j];
        }

        Matrix M1;
        Matrix M2;

        private void generatorMatrix_Click(object sender, EventArgs e)
        {
            createMatrix(int.Parse(tbRows1.Text), int.Parse(tbColumns1.Text), M1);
            createMatrix(int.Parse(tbRows2.Text), int.Parse(tbColumns2.Text), M2);
            //Вызов функции для  создания 
        }

        private Matrix createMatrix(int rows,int columns, Matrix M)
        {
            return M = new Matrix(columns, rows);
        }
    }
}
