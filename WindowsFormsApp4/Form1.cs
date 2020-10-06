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
            dataGridView1.RowCount =Convert.ToInt32(tbColumns1);
            dataGridView1.ColumnCount = Convert.ToInt32(tbRows1);
            int i = 0;
            int j = 0;
            int[,] mas1 = new int[i, j];
            for (i = 0; i < Convert.ToInt32(tbColumns1); ++i)
                for (j = 0; j < Convert.ToInt32(tbRows1); ++j)
                    dataGridView1.Rows[i].Cells[j].Value = mas1[i, j];

            //Привязка второй
            dataGridView2.RowCount = Convert.ToInt32(tbColumns2);
            dataGridView2.ColumnCount = Convert.ToInt32(tbRows2);
            int[,] mas2 = new int[i, j];
            for (i = 0; i < Convert.ToInt32(tbColumns1); ++i)
                for (j = 0; j < Convert.ToInt32(tbRows1); ++j)
                    dataGridView1.Rows[i].Cells[j].Value = mas2[i, j];
        }

        Matrix M1;
        Matrix M2;

        private void generatorMatrix_Click(object sender, EventArgs e)
        {
            createMatrix(Convert.ToInt32(tbRows1.Text), Convert.ToInt32(tbColumns1.Text), M1);
            createMatrix(Convert.ToInt32(tbRows2.Text), Convert.ToInt32(tbColumns2.Text), M2);
            //Вызов функции для  создания 
        }

        private Matrix createMatrix(int rows,int columns, Matrix M)
        {
            return M = new Matrix(columns, rows);
        }
    }
}
