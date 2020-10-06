namespace WindowsFormsApp4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.generatorMatrix = new System.Windows.Forms.Button();
            this.tbRows1 = new System.Windows.Forms.TextBox();
            this.tbColumns1 = new System.Windows.Forms.TextBox();
            this.tbRows2 = new System.Windows.Forms.TextBox();
            this.tbColumns2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(123, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(442, 99);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 150);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(798, 99);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(240, 150);
            this.dataGridView3.TabIndex = 2;
            // 
            // generatorMatrix
            // 
            this.generatorMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.generatorMatrix.Location = new System.Drawing.Point(253, 373);
            this.generatorMatrix.Name = "generatorMatrix";
            this.generatorMatrix.Size = new System.Drawing.Size(241, 111);
            this.generatorMatrix.TabIndex = 3;
            this.generatorMatrix.Text = "Сгенерировать";
            this.generatorMatrix.UseVisualStyleBackColor = true;
            this.generatorMatrix.Click += new System.EventHandler(this.generatorMatrix_Click);
            // 
            // tbRows1
            // 
            this.tbRows1.Location = new System.Drawing.Point(165, 271);
            this.tbRows1.Name = "tbRows1";
            this.tbRows1.Size = new System.Drawing.Size(100, 20);
            this.tbRows1.TabIndex = 4;
            // 
            // tbColumns1
            // 
            this.tbColumns1.Location = new System.Drawing.Point(165, 308);
            this.tbColumns1.Name = "tbColumns1";
            this.tbColumns1.Size = new System.Drawing.Size(100, 20);
            this.tbColumns1.TabIndex = 5;
            // 
            // tbRows2
            // 
            this.tbRows2.Location = new System.Drawing.Point(477, 271);
            this.tbRows2.Name = "tbRows2";
            this.tbRows2.Size = new System.Drawing.Size(100, 20);
            this.tbRows2.TabIndex = 6;
            // 
            // tbColumns2
            // 
            this.tbColumns2.Location = new System.Drawing.Point(477, 307);
            this.tbColumns2.Name = "tbColumns2";
            this.tbColumns2.Size = new System.Drawing.Size(100, 20);
            this.tbColumns2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(327, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(308, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Столбцы";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 766);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbColumns2);
            this.Controls.Add(this.tbRows2);
            this.Controls.Add(this.tbColumns1);
            this.Controls.Add(this.tbRows1);
            this.Controls.Add(this.generatorMatrix);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button generatorMatrix;
        private System.Windows.Forms.TextBox tbRows1;
        private System.Windows.Forms.TextBox tbColumns1;
        private System.Windows.Forms.TextBox tbRows2;
        private System.Windows.Forms.TextBox tbColumns2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

