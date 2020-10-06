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
            this.fillButton = new System.Windows.Forms.Button();
            this.multButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(164, 122);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(320, 185);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(589, 122);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(320, 185);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToResizeColumns = false;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(1064, 122);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.Size = new System.Drawing.Size(320, 185);
            this.dataGridView3.TabIndex = 2;
            // 
            // generatorMatrix
            // 
            this.generatorMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.generatorMatrix.Location = new System.Drawing.Point(74, 483);
            this.generatorMatrix.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generatorMatrix.Name = "generatorMatrix";
            this.generatorMatrix.Size = new System.Drawing.Size(321, 137);
            this.generatorMatrix.TabIndex = 3;
            this.generatorMatrix.Text = "Сгенерировать";
            this.generatorMatrix.UseVisualStyleBackColor = true;
            this.generatorMatrix.Click += new System.EventHandler(this.generatorMatrix_Click);
            // 
            // tbRows1
            // 
            this.tbRows1.Location = new System.Drawing.Point(220, 334);
            this.tbRows1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRows1.Name = "tbRows1";
            this.tbRows1.Size = new System.Drawing.Size(132, 22);
            this.tbRows1.TabIndex = 4;
            // 
            // tbColumns1
            // 
            this.tbColumns1.Location = new System.Drawing.Point(220, 379);
            this.tbColumns1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbColumns1.Name = "tbColumns1";
            this.tbColumns1.Size = new System.Drawing.Size(132, 22);
            this.tbColumns1.TabIndex = 5;
            // 
            // tbRows2
            // 
            this.tbRows2.Location = new System.Drawing.Point(636, 334);
            this.tbRows2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRows2.Name = "tbRows2";
            this.tbRows2.Size = new System.Drawing.Size(132, 22);
            this.tbRows2.TabIndex = 6;
            // 
            // tbColumns2
            // 
            this.tbColumns2.Location = new System.Drawing.Point(636, 378);
            this.tbColumns2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbColumns2.Name = "tbColumns2";
            this.tbColumns2.Size = new System.Drawing.Size(132, 22);
            this.tbColumns2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(436, 334);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "Строки";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(411, 378);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 35);
            this.label2.TabIndex = 9;
            this.label2.Text = "Столбцы";
            // 
            // fillButton
            // 
            this.fillButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.fillButton.Location = new System.Drawing.Point(403, 483);
            this.fillButton.Margin = new System.Windows.Forms.Padding(4);
            this.fillButton.Name = "fillButton";
            this.fillButton.Size = new System.Drawing.Size(321, 137);
            this.fillButton.TabIndex = 10;
            this.fillButton.Text = "Заполнить";
            this.fillButton.UseVisualStyleBackColor = true;
            this.fillButton.Click += new System.EventHandler(this.fillButton_Click);
            // 
            // multButton
            // 
            this.multButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.multButton.Location = new System.Drawing.Point(732, 483);
            this.multButton.Margin = new System.Windows.Forms.Padding(4);
            this.multButton.Name = "multButton";
            this.multButton.Size = new System.Drawing.Size(321, 137);
            this.multButton.TabIndex = 11;
            this.multButton.Text = "Умножить";
            this.multButton.UseVisualStyleBackColor = true;
            this.multButton.Click += new System.EventHandler(this.multButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1585, 943);
            this.Controls.Add(this.multButton);
            this.Controls.Add(this.fillButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Button fillButton;
        private System.Windows.Forms.Button multButton;
    }
}

