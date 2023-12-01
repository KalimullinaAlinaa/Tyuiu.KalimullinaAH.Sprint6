
namespace Tyuiu.KalimullinaAH.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBoxOutPut_KAH = new System.Windows.Forms.GroupBox();
            this.labelResult_KAH = new System.Windows.Forms.Label();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.groupBoxInput_KAH = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KAH = new System.Windows.Forms.Label();
            this.textBoxEndStep_KAH = new System.Windows.Forms.TextBox();
            this.labelStartStep_KAH = new System.Windows.Forms.Label();
            this.textBoxStartStep_KAH = new System.Windows.Forms.TextBox();
            this.buttonInfo_KAH = new System.Windows.Forms.Button();
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.labelTask_KAH = new System.Windows.Forms.Label();
            this.dataGridViewFunction_KAH = new System.Windows.Forms.DataGridView();
            this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.F = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartFunction_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_KAH.SuspendLayout();
            this.groupBoxInput_KAH.SuspendLayout();
            this.groupBoxTask_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOutPut_KAH
            // 
            this.groupBoxOutPut_KAH.Controls.Add(this.chartFunction_KAH);
            this.groupBoxOutPut_KAH.Controls.Add(this.dataGridViewFunction_KAH);
            this.groupBoxOutPut_KAH.Controls.Add(this.labelResult_KAH);
            this.groupBoxOutPut_KAH.Location = new System.Drawing.Point(604, 21);
            this.groupBoxOutPut_KAH.Name = "groupBoxOutPut_KAH";
            this.groupBoxOutPut_KAH.Size = new System.Drawing.Size(798, 451);
            this.groupBoxOutPut_KAH.TabIndex = 7;
            this.groupBoxOutPut_KAH.TabStop = false;
            this.groupBoxOutPut_KAH.Text = "Вывод данных";
            // 
            // labelResult_KAH
            // 
            this.labelResult_KAH.AutoSize = true;
            this.labelResult_KAH.Location = new System.Drawing.Point(6, 27);
            this.labelResult_KAH.Name = "labelResult_KAH";
            this.labelResult_KAH.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KAH.TabIndex = 1;
            this.labelResult_KAH.Text = "Результат:";
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.BackColor = System.Drawing.Color.Blue;
            this.buttonDone_KAH.Location = new System.Drawing.Point(458, 375);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(119, 63);
            this.buttonDone_KAH.TabIndex = 3;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = false;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_KAH_Click);
            this.buttonDone_KAH.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonDone_KAH_MouseDown);
            this.buttonDone_KAH.MouseEnter += new System.EventHandler(this.buttonDone_KAH_MouseEnter);
            this.buttonDone_KAH.MouseLeave += new System.EventHandler(this.buttonDone_KAH_MouseLeave);
            // 
            // groupBoxInput_KAH
            // 
            this.groupBoxInput_KAH.Controls.Add(this.labelStopStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxEndStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.labelStartStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxStartStep_KAH);
            this.groupBoxInput_KAH.Location = new System.Drawing.Point(12, 350);
            this.groupBoxInput_KAH.Name = "groupBoxInput_KAH";
            this.groupBoxInput_KAH.Size = new System.Drawing.Size(315, 122);
            this.groupBoxInput_KAH.TabIndex = 5;
            this.groupBoxInput_KAH.TabStop = false;
            this.groupBoxInput_KAH.Text = "Ввод данных";
            // 
            // labelStopStep_KAH
            // 
            this.labelStopStep_KAH.AutoSize = true;
            this.labelStopStep_KAH.Location = new System.Drawing.Point(109, 25);
            this.labelStopStep_KAH.Name = "labelStopStep_KAH";
            this.labelStopStep_KAH.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_KAH.TabIndex = 4;
            this.labelStopStep_KAH.Text = "Конец шага:";
            // 
            // textBoxEndStep_KAH
            // 
            this.textBoxEndStep_KAH.Location = new System.Drawing.Point(112, 45);
            this.textBoxEndStep_KAH.Name = "textBoxEndStep_KAH";
            this.textBoxEndStep_KAH.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndStep_KAH.TabIndex = 2;
            // 
            // labelStartStep_KAH
            // 
            this.labelStartStep_KAH.AutoSize = true;
            this.labelStartStep_KAH.Location = new System.Drawing.Point(6, 25);
            this.labelStartStep_KAH.Name = "labelStartStep_KAH";
            this.labelStartStep_KAH.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KAH.TabIndex = 3;
            this.labelStartStep_KAH.Text = "Старт шага:";
            // 
            // textBoxStartStep_KAH
            // 
            this.textBoxStartStep_KAH.Location = new System.Drawing.Point(6, 45);
            this.textBoxStartStep_KAH.Name = "textBoxStartStep_KAH";
            this.textBoxStartStep_KAH.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_KAH.TabIndex = 0;
            // 
            // buttonInfo_KAH
            // 
            this.buttonInfo_KAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInfo_KAH.Location = new System.Drawing.Point(333, 375);
            this.buttonInfo_KAH.Name = "buttonInfo_KAH";
            this.buttonInfo_KAH.Size = new System.Drawing.Size(119, 63);
            this.buttonInfo_KAH.TabIndex = 6;
            this.buttonInfo_KAH.Text = "Справка";
            this.buttonInfo_KAH.UseVisualStyleBackColor = false;
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.labelTask_KAH);
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(12, 21);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(565, 310);
            this.groupBoxTask_KAH.TabIndex = 4;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // labelTask_KAH
            // 
            this.labelTask_KAH.AutoSize = true;
            this.labelTask_KAH.Location = new System.Drawing.Point(6, 27);
            this.labelTask_KAH.Name = "labelTask_KAH";
            this.labelTask_KAH.Size = new System.Drawing.Size(470, 51);
            this.labelTask_KAH.TabIndex = 2;
            this.labelTask_KAH.Text = "Протабулировать функцию Math.Cos(x) + (Math.Cos(x)) / (x + 2) - (3 * x)\r\nна задан" +
    "ном диапазоне\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // dataGridViewFunction_KAH
            // 
            this.dataGridViewFunction_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFunction_KAH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.F});
            this.dataGridViewFunction_KAH.Location = new System.Drawing.Point(9, 56);
            this.dataGridViewFunction_KAH.Name = "dataGridViewFunction_KAH";
            this.dataGridViewFunction_KAH.RowHeadersVisible = false;
            this.dataGridViewFunction_KAH.RowHeadersWidth = 51;
            this.dataGridViewFunction_KAH.RowTemplate.Height = 24;
            this.dataGridViewFunction_KAH.Size = new System.Drawing.Size(253, 389);
            this.dataGridViewFunction_KAH.TabIndex = 2;
            // 
            // X
            // 
            this.X.HeaderText = "X";
            this.X.MinimumWidth = 6;
            this.X.Name = "X";
            this.X.Width = 125;
            // 
            // F
            // 
            this.F.HeaderText = "F(X)";
            this.F.MinimumWidth = 6;
            this.F.Name = "F";
            this.F.Width = 125;
            // 
            // chartFunction_KAH
            // 
            chartArea10.Name = "ChartArea1";
            this.chartFunction_KAH.ChartAreas.Add(chartArea10);
            this.chartFunction_KAH.Location = new System.Drawing.Point(268, 56);
            this.chartFunction_KAH.Name = "chartFunction_KAH";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.IsVisibleInLegend = false;
            series10.Name = "Series1";
            this.chartFunction_KAH.Series.Add(series10);
            this.chartFunction_KAH.Size = new System.Drawing.Size(524, 389);
            this.chartFunction_KAH.TabIndex = 8;
            this.chartFunction_KAH.Text = "chart1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1408, 491);
            this.Controls.Add(this.groupBoxOutPut_KAH);
            this.Controls.Add(this.buttonDone_KAH);
            this.Controls.Add(this.groupBoxInput_KAH);
            this.Controls.Add(this.buttonInfo_KAH);
            this.Controls.Add(this.groupBoxTask_KAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 2 | Вариант 29 | Калимуллина А.Х";
            this.groupBoxOutPut_KAH.ResumeLayout(false);
            this.groupBoxOutPut_KAH.PerformLayout();
            this.groupBoxInput_KAH.ResumeLayout(false);
            this.groupBoxInput_KAH.PerformLayout();
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFunction_KAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunction_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOutPut_KAH;
        private System.Windows.Forms.Label labelResult_KAH;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.GroupBox groupBoxInput_KAH;
        private System.Windows.Forms.Label labelStopStep_KAH;
        private System.Windows.Forms.TextBox textBoxEndStep_KAH;
        private System.Windows.Forms.Label labelStartStep_KAH;
        private System.Windows.Forms.TextBox textBoxStartStep_KAH;
        private System.Windows.Forms.Button buttonInfo_KAH;
        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.Label labelTask_KAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_KAH;
        private System.Windows.Forms.DataGridView dataGridViewFunction_KAH;
        private System.Windows.Forms.DataGridViewTextBoxColumn X;
        private System.Windows.Forms.DataGridViewTextBoxColumn F;
    }
}

