
namespace Tyuiu.KalimullinaAH.Sprint6.Task4.V28
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.groupBoxInput_KAH = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KAH = new System.Windows.Forms.Label();
            this.textBoxEndStep_KAH = new System.Windows.Forms.TextBox();
            this.labelStartStep_KAH = new System.Windows.Forms.Label();
            this.textBoxStartStep_KAH = new System.Windows.Forms.TextBox();
            this.buttonInfo_KAH = new System.Windows.Forms.Button();
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonSave_KAH = new System.Windows.Forms.Button();
            this.chartResult_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBoxOutPut_KAH = new System.Windows.Forms.GroupBox();
            this.labelResult_KAH = new System.Windows.Forms.Label();
            this.textBoxResult_KAH = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxInput_KAH.SuspendLayout();
            this.groupBoxTask_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAH)).BeginInit();
            this.groupBoxOutPut_KAH.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.BackColor = System.Drawing.Color.Blue;
            this.buttonDone_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_KAH.Location = new System.Drawing.Point(866, 6);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonDone_KAH.TabIndex = 8;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = false;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_KAH_Click);
            // 
            // groupBoxInput_KAH
            // 
            this.groupBoxInput_KAH.Controls.Add(this.labelStopStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxEndStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.labelStartStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxStartStep_KAH);
            this.groupBoxInput_KAH.Location = new System.Drawing.Point(508, 6);
            this.groupBoxInput_KAH.Name = "groupBoxInput_KAH";
            this.groupBoxInput_KAH.Size = new System.Drawing.Size(280, 89);
            this.groupBoxInput_KAH.TabIndex = 10;
            this.groupBoxInput_KAH.TabStop = false;
            this.groupBoxInput_KAH.Text = "Ввод данных";
            // 
            // labelStopStep_KAH
            // 
            this.labelStopStep_KAH.AutoSize = true;
            this.labelStopStep_KAH.Location = new System.Drawing.Point(140, 24);
            this.labelStopStep_KAH.Name = "labelStopStep_KAH";
            this.labelStopStep_KAH.Size = new System.Drawing.Size(89, 17);
            this.labelStopStep_KAH.TabIndex = 4;
            this.labelStopStep_KAH.Text = "Конец шага:";
            // 
            // textBoxEndStep_KAH
            // 
            this.textBoxEndStep_KAH.Location = new System.Drawing.Point(143, 45);
            this.textBoxEndStep_KAH.Name = "textBoxEndStep_KAH";
            this.textBoxEndStep_KAH.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndStep_KAH.TabIndex = 2;
            this.textBoxEndStep_KAH.TextChanged += new System.EventHandler(this.textBoxEndStep_KAH_TextChanged);
            // 
            // labelStartStep_KAH
            // 
            this.labelStartStep_KAH.AutoSize = true;
            this.labelStartStep_KAH.Location = new System.Drawing.Point(19, 24);
            this.labelStartStep_KAH.Name = "labelStartStep_KAH";
            this.labelStartStep_KAH.Size = new System.Drawing.Size(87, 17);
            this.labelStartStep_KAH.TabIndex = 3;
            this.labelStartStep_KAH.Text = "Старт шага:";
            // 
            // textBoxStartStep_KAH
            // 
            this.textBoxStartStep_KAH.Location = new System.Drawing.Point(22, 45);
            this.textBoxStartStep_KAH.Name = "textBoxStartStep_KAH";
            this.textBoxStartStep_KAH.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartStep_KAH.TabIndex = 0;
            // 
            // buttonInfo_KAH
            // 
            this.buttonInfo_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonInfo_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_KAH.Location = new System.Drawing.Point(1151, 6);
            this.buttonInfo_KAH.Name = "buttonInfo_KAH";
            this.buttonInfo_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonInfo_KAH.TabIndex = 11;
            this.buttonInfo_KAH.Text = "Справка";
            this.buttonInfo_KAH.UseVisualStyleBackColor = false;
            this.buttonInfo_KAH.Click += new System.EventHandler(this.buttonInfo_KAH_Click);
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.textBox1);
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(3, 6);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(499, 89);
            this.groupBoxTask_KAH.TabIndex = 9;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 21);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(487, 68);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "Протабулировать функцию (Math.Cos(2 * x) + (Math.Sin(x) / (x + 2.5) + 2 * x)\r\nРез" +
    "ультат вывести в textBox, построить график функции и сохранить в файл OutPutFile" +
    "Task.txt по нажатию кнопки\r\n\r\n\r\n";
            // 
            // buttonSave_KAH
            // 
            this.buttonSave_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonSave_KAH.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonSave_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_KAH.Location = new System.Drawing.Point(1015, 6);
            this.buttonSave_KAH.Name = "buttonSave_KAH";
            this.buttonSave_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonSave_KAH.TabIndex = 13;
            this.buttonSave_KAH.Text = "Сохранить";
            this.buttonSave_KAH.UseVisualStyleBackColor = false;
            this.buttonSave_KAH.Click += new System.EventHandler(this.buttonSave_KAH_Click);
            // 
            // chartResult_KAH
            // 
            this.chartResult_KAH.BorderlineWidth = 5;
            chartArea1.Name = "ChartArea1";
            this.chartResult_KAH.ChartAreas.Add(chartArea1);
            this.chartResult_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartResult_KAH.Legends.Add(legend1);
            this.chartResult_KAH.Location = new System.Drawing.Point(0, 0);
            this.chartResult_KAH.Name = "chartResult_KAH";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartResult_KAH.Series.Add(series1);
            this.chartResult_KAH.Size = new System.Drawing.Size(938, 602);
            this.chartResult_KAH.TabIndex = 14;
            this.chartResult_KAH.Text = "chartResult_KAH";
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "Func_KAH";
            title1.ShadowColor = System.Drawing.Color.Transparent;
            title1.Text = "График функции";
            this.chartResult_KAH.Titles.Add(title1);
            this.chartResult_KAH.Click += new System.EventHandler(this.chartResult_KAH_Click);
            // 
            // groupBoxOutPut_KAH
            // 
            this.groupBoxOutPut_KAH.Controls.Add(this.textBoxResult_KAH);
            this.groupBoxOutPut_KAH.Controls.Add(this.labelResult_KAH);
            this.groupBoxOutPut_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KAH.Name = "groupBoxOutPut_KAH";
            this.groupBoxOutPut_KAH.Size = new System.Drawing.Size(344, 602);
            this.groupBoxOutPut_KAH.TabIndex = 12;
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
            // textBoxResult_KAH
            // 
            this.textBoxResult_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxResult_KAH.Location = new System.Drawing.Point(3, 18);
            this.textBoxResult_KAH.Multiline = true;
            this.textBoxResult_KAH.Name = "textBoxResult_KAH";
            this.textBoxResult_KAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KAH.Size = new System.Drawing.Size(338, 581);
            this.textBoxResult_KAH.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTask_KAH);
            this.panel1.Controls.Add(this.buttonSave_KAH);
            this.panel1.Controls.Add(this.groupBoxInput_KAH);
            this.panel1.Controls.Add(this.buttonDone_KAH);
            this.panel1.Controls.Add(this.buttonInfo_KAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 101);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.groupBoxOutPut_KAH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 602);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartResult_KAH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(344, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(938, 602);
            this.panel3.TabIndex = 16;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 602);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 703);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(1300, 750);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBoxInput_KAH.ResumeLayout(false);
            this.groupBoxInput_KAH.PerformLayout();
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartResult_KAH)).EndInit();
            this.groupBoxOutPut_KAH.ResumeLayout(false);
            this.groupBoxOutPut_KAH.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.GroupBox groupBoxInput_KAH;
        private System.Windows.Forms.Label labelStopStep_KAH;
        private System.Windows.Forms.TextBox textBoxEndStep_KAH;
        private System.Windows.Forms.Label labelStartStep_KAH;
        private System.Windows.Forms.TextBox textBoxStartStep_KAH;
        private System.Windows.Forms.Button buttonInfo_KAH;
        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonSave_KAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult_KAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAH;
        private System.Windows.Forms.TextBox textBoxResult_KAH;
        private System.Windows.Forms.Label labelResult_KAH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Splitter splitter1;
    }
}

