
namespace Tyuiu.KalimullinaAH.Sprint6.Task5.V14
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartGraph_KAH = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.groupBoxOutPut_KAH = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult_KAH = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAH = new System.Windows.Forms.TextBox();
            this.buttonOpen_KAH = new System.Windows.Forms.Button();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.buttonInfo_KAH = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KAH)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBoxOutPut_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAH)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBoxTask_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartGraph_KAH);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(344, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(994, 562);
            this.panel3.TabIndex = 19;
            // 
            // chartGraph_KAH
            // 
            this.chartGraph_KAH.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea12.Name = "ChartArea1";
            this.chartGraph_KAH.ChartAreas.Add(chartArea12);
            this.chartGraph_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            legend12.Name = "Legend1";
            this.chartGraph_KAH.Legends.Add(legend12);
            this.chartGraph_KAH.Location = new System.Drawing.Point(0, 0);
            this.chartGraph_KAH.Name = "chartGraph_KAH";
            this.chartGraph_KAH.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series12.ChartArea = "ChartArea1";
            series12.Legend = "Legend1";
            series12.Name = "Series1";
            this.chartGraph_KAH.Series.Add(series12);
            this.chartGraph_KAH.Size = new System.Drawing.Size(994, 562);
            this.chartGraph_KAH.TabIndex = 0;
            this.chartGraph_KAH.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.groupBoxOutPut_KAH);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 562);
            this.panel2.TabIndex = 18;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 562);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // groupBoxOutPut_KAH
            // 
            this.groupBoxOutPut_KAH.Controls.Add(this.dataGridViewResult_KAH);
            this.groupBoxOutPut_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxOutPut_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxOutPut_KAH.Name = "groupBoxOutPut_KAH";
            this.groupBoxOutPut_KAH.Size = new System.Drawing.Size(344, 562);
            this.groupBoxOutPut_KAH.TabIndex = 12;
            this.groupBoxOutPut_KAH.TabStop = false;
            this.groupBoxOutPut_KAH.Text = "Вывод данных";
            // 
            // dataGridViewResult_KAH
            // 
            this.dataGridViewResult_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult_KAH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewResult_KAH.Name = "dataGridViewResult_KAH";
            this.dataGridViewResult_KAH.RowHeadersVisible = false;
            this.dataGridViewResult_KAH.RowHeadersWidth = 51;
            this.dataGridViewResult_KAH.RowTemplate.Height = 24;
            this.dataGridViewResult_KAH.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dataGridViewResult_KAH.Size = new System.Drawing.Size(338, 541);
            this.dataGridViewResult_KAH.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBoxTask_KAH);
            this.panel1.Controls.Add(this.buttonOpen_KAH);
            this.panel1.Controls.Add(this.buttonDone_KAH);
            this.panel1.Controls.Add(this.buttonInfo_KAH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1338, 101);
            this.panel1.TabIndex = 17;
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.textBoxTask_KAH);
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(3, 6);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(499, 89);
            this.groupBoxTask_KAH.TabIndex = 9;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // textBoxTask_KAH
            // 
            this.textBoxTask_KAH.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_KAH.Multiline = true;
            this.textBoxTask_KAH.Name = "textBoxTask_KAH";
            this.textBoxTask_KAH.ReadOnly = true;
            this.textBoxTask_KAH.Size = new System.Drawing.Size(487, 68);
            this.textBoxTask_KAH.TabIndex = 13;
            this.textBoxTask_KAH.Text = "Прочитать данные из файлы InPutFileTask5.txt.Вывести в dataGridView числа, больше" +
    " или  равные 10 и построить диаграмму по этим значениям";
            // 
            // buttonOpen_KAH
            // 
            this.buttonOpen_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.buttonOpen_KAH.BackColor = System.Drawing.SystemColors.HotTrack;
            this.buttonOpen_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen_KAH.Location = new System.Drawing.Point(687, 3);
            this.buttonOpen_KAH.Name = "buttonOpen_KAH";
            this.buttonOpen_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonOpen_KAH.TabIndex = 13;
            this.buttonOpen_KAH.Text = "Открыть файл";
            this.buttonOpen_KAH.UseVisualStyleBackColor = false;
            this.buttonOpen_KAH.Click += new System.EventHandler(this.buttonOpen_KAH_Click);
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDone_KAH.BackColor = System.Drawing.Color.Lime;
            this.buttonDone_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_KAH.Location = new System.Drawing.Point(536, 3);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonDone_KAH.TabIndex = 8;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = false;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_KAH_Click);
            // 
            // buttonInfo_KAH
            // 
            this.buttonInfo_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonInfo_KAH.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonInfo_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonInfo_KAH.Location = new System.Drawing.Point(1207, 6);
            this.buttonInfo_KAH.Name = "buttonInfo_KAH";
            this.buttonInfo_KAH.Size = new System.Drawing.Size(119, 89);
            this.buttonInfo_KAH.TabIndex = 11;
            this.buttonInfo_KAH.Text = "Справка";
            this.buttonInfo_KAH.UseVisualStyleBackColor = false;
            this.buttonInfo_KAH.Click += new System.EventHandler(this.buttonInfo_KAH_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 663);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 5 | Вариант 14 | Калимуллина А.Х";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph_KAH)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBoxOutPut_KAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_KAH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAH;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.TextBox textBoxTask_KAH;
        private System.Windows.Forms.Button buttonOpen_KAH;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.Button buttonInfo_KAH;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph_KAH;
        private System.Windows.Forms.DataGridView dataGridViewResult_KAH;
    }
}

