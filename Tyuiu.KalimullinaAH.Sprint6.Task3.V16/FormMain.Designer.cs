
namespace Tyuiu.KalimullinaAH.Sprint6.Task3.V16
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox_Task_KAH = new System.Windows.Forms.GroupBox();
            this.dataGridViewMatrix_KAH = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox_OutPut_KAH = new System.Windows.Forms.GroupBox();
            this.labelResult_KAH = new System.Windows.Forms.Label();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.buttonHelp_KAH = new System.Windows.Forms.Button();
            this.textBoxData_KAH = new System.Windows.Forms.TextBox();
            this.groupBox_Task_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAH)).BeginInit();
            this.groupBox_OutPut_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Task_KAH
            // 
            this.groupBox_Task_KAH.Controls.Add(this.textBoxData_KAH);
            this.groupBox_Task_KAH.Controls.Add(this.button2);
            this.groupBox_Task_KAH.Location = new System.Drawing.Point(12, 22);
            this.groupBox_Task_KAH.Name = "groupBox_Task_KAH";
            this.groupBox_Task_KAH.Size = new System.Drawing.Size(345, 340);
            this.groupBox_Task_KAH.TabIndex = 0;
            this.groupBox_Task_KAH.TabStop = false;
            this.groupBox_Task_KAH.Text = "Условие";
            // 
            // dataGridViewMatrix_KAH
            // 
            this.dataGridViewMatrix_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_KAH.ColumnHeadersVisible = false;
            this.dataGridViewMatrix_KAH.Location = new System.Drawing.Point(9, 63);
            this.dataGridViewMatrix_KAH.Name = "dataGridViewMatrix_KAH";
            this.dataGridViewMatrix_KAH.RowHeadersVisible = false;
            this.dataGridViewMatrix_KAH.RowHeadersWidth = 181;
            this.dataGridViewMatrix_KAH.RowTemplate.Height = 24;
            this.dataGridViewMatrix_KAH.Size = new System.Drawing.Size(328, 181);
            this.dataGridViewMatrix_KAH.TabIndex = 3;
            this.dataGridViewMatrix_KAH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_KAH_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(399, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // groupBox_OutPut_KAH
            // 
            this.groupBox_OutPut_KAH.Controls.Add(this.labelResult_KAH);
            this.groupBox_OutPut_KAH.Controls.Add(this.dataGridViewMatrix_KAH);
            this.groupBox_OutPut_KAH.Controls.Add(this.buttonDone_KAH);
            this.groupBox_OutPut_KAH.Controls.Add(this.buttonHelp_KAH);
            this.groupBox_OutPut_KAH.Location = new System.Drawing.Point(363, 22);
            this.groupBox_OutPut_KAH.Name = "groupBox_OutPut_KAH";
            this.groupBox_OutPut_KAH.Size = new System.Drawing.Size(360, 340);
            this.groupBox_OutPut_KAH.TabIndex = 1;
            this.groupBox_OutPut_KAH.TabStop = false;
            this.groupBox_OutPut_KAH.Text = "Вывод данных";
            // 
            // labelResult_KAH
            // 
            this.labelResult_KAH.AutoSize = true;
            this.labelResult_KAH.Location = new System.Drawing.Point(6, 24);
            this.labelResult_KAH.Name = "labelResult_KAH";
            this.labelResult_KAH.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KAH.TabIndex = 3;
            this.labelResult_KAH.Text = "Результат:";
            this.labelResult_KAH.Click += new System.EventHandler(this.labelResult_KAH_Click);
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.Location = new System.Drawing.Point(156, 294);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(116, 30);
            this.buttonDone_KAH.TabIndex = 0;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = true;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonHelp_KAH
            // 
            this.buttonHelp_KAH.Location = new System.Drawing.Point(89, 294);
            this.buttonHelp_KAH.Name = "buttonHelp_KAH";
            this.buttonHelp_KAH.Size = new System.Drawing.Size(45, 30);
            this.buttonHelp_KAH.TabIndex = 1;
            this.buttonHelp_KAH.Text = "?";
            this.buttonHelp_KAH.UseVisualStyleBackColor = true;
            this.buttonHelp_KAH.Click += new System.EventHandler(this.buttonHelp_KAH_Click);
            // 
            // textBoxData_KAH
            // 
            this.textBoxData_KAH.Location = new System.Drawing.Point(6, 24);
            this.textBoxData_KAH.Multiline = true;
            this.textBoxData_KAH.Name = "textBoxData_KAH";
            this.textBoxData_KAH.ReadOnly = true;
            this.textBoxData_KAH.Size = new System.Drawing.Size(339, 316);
            this.textBoxData_KAH.TabIndex = 4;
            this.textBoxData_KAH.Text = "Дан массив 5 на 5 элементов. \r\n14   1  -3   1  10 \r\n7  -3   5  -4   0  \r\n-10 -19 " +
    "-18  -9  19 \r\n -2  -2 -16   2 -17 \r\n -16   9   5 -10  16\r\nЗаменить четные значен" +
    "ия в третьей строке на ноль";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 374);
            this.Controls.Add(this.groupBox_OutPut_KAH);
            this.Controls.Add(this.groupBox_Task_KAH);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 3 | Вариант 16 | Калимуллина А.Х";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox_Task_KAH.ResumeLayout(false);
            this.groupBox_Task_KAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_KAH)).EndInit();
            this.groupBox_OutPut_KAH.ResumeLayout(false);
            this.groupBox_OutPut_KAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Task_KAH;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.GroupBox groupBox_OutPut_KAH;
        private System.Windows.Forms.Label labelResult_KAH;
        private System.Windows.Forms.Button buttonHelp_KAH;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_KAH;
        private System.Windows.Forms.TextBox textBoxData_KAH;
    }
}

