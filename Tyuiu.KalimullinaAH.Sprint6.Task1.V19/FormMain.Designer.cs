
namespace Tyuiu.KalimullinaAH.Sprint6.Task1.V19
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
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.labelTask_KAH = new System.Windows.Forms.Label();
            this.groupBoxInput_KAH = new System.Windows.Forms.GroupBox();
            this.labelStopStep_KAH = new System.Windows.Forms.Label();
            this.textBoxEndStep_KAH = new System.Windows.Forms.TextBox();
            this.labelStartStep_KAH = new System.Windows.Forms.Label();
            this.textBoxStartStep_KAH = new System.Windows.Forms.TextBox();
            this.buttonInfo_KAH = new System.Windows.Forms.Button();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.groupBoxOutPut_KAH = new System.Windows.Forms.GroupBox();
            this.labelResult_KAH = new System.Windows.Forms.Label();
            this.textBoxResult_KAH = new System.Windows.Forms.TextBox();
            this.groupBoxTask_KAH.SuspendLayout();
            this.groupBoxInput_KAH.SuspendLayout();
            this.groupBoxOutPut_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.labelTask_KAH);
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(565, 310);
            this.groupBoxTask_KAH.TabIndex = 0;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // labelTask_KAH
            // 
            this.labelTask_KAH.AutoSize = true;
            this.labelTask_KAH.Location = new System.Drawing.Point(6, 27);
            this.labelTask_KAH.Name = "labelTask_KAH";
            this.labelTask_KAH.Size = new System.Drawing.Size(547, 51);
            this.labelTask_KAH.TabIndex = 2;
            this.labelTask_KAH.Text = "Протабулировать функцию 2 * Math.Cos(x) + 2) / (2 * x - 1)) + Math.Cos(x) - 5 * x" +
    " + 3\r\nна заданном диапазоне\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxInput_KAH
            // 
            this.groupBoxInput_KAH.Controls.Add(this.labelStopStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxEndStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.labelStartStep_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxStartStep_KAH);
            this.groupBoxInput_KAH.Location = new System.Drawing.Point(12, 341);
            this.groupBoxInput_KAH.Name = "groupBoxInput_KAH";
            this.groupBoxInput_KAH.Size = new System.Drawing.Size(298, 122);
            this.groupBoxInput_KAH.TabIndex = 1;
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
            this.labelStopStep_KAH.Click += new System.EventHandler(this.labelStopStep_KAH_Click);
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
            this.buttonInfo_KAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonInfo_KAH.Location = new System.Drawing.Point(333, 366);
            this.buttonInfo_KAH.Name = "buttonInfo_KAH";
            this.buttonInfo_KAH.Size = new System.Drawing.Size(119, 63);
            this.buttonInfo_KAH.TabIndex = 1;
            this.buttonInfo_KAH.Text = "Справка";
            this.buttonInfo_KAH.UseVisualStyleBackColor = false;
            this.buttonInfo_KAH.Click += new System.EventHandler(this.buttonInfo_KAH_Click);
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonDone_KAH.Location = new System.Drawing.Point(458, 366);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(119, 63);
            this.buttonDone_KAH.TabIndex = 0;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = false;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxOutPut_KAH
            // 
            this.groupBoxOutPut_KAH.Controls.Add(this.labelResult_KAH);
            this.groupBoxOutPut_KAH.Controls.Add(this.textBoxResult_KAH);
            this.groupBoxOutPut_KAH.Location = new System.Drawing.Point(604, 12);
            this.groupBoxOutPut_KAH.Name = "groupBoxOutPut_KAH";
            this.groupBoxOutPut_KAH.Size = new System.Drawing.Size(367, 451);
            this.groupBoxOutPut_KAH.TabIndex = 2;
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
            this.textBoxResult_KAH.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxResult_KAH.Location = new System.Drawing.Point(6, 61);
            this.textBoxResult_KAH.Multiline = true;
            this.textBoxResult_KAH.Name = "textBoxResult_KAH";
            this.textBoxResult_KAH.ReadOnly = true;
            this.textBoxResult_KAH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult_KAH.Size = new System.Drawing.Size(355, 435);
            this.textBoxResult_KAH.TabIndex = 0;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 510);
            this.Controls.Add(this.groupBoxOutPut_KAH);
            this.Controls.Add(this.buttonDone_KAH);
            this.Controls.Add(this.groupBoxInput_KAH);
            this.Controls.Add(this.buttonInfo_KAH);
            this.Controls.Add(this.groupBoxTask_KAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск1 | Вариант 19 | Калимуллина А.Х";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            this.groupBoxInput_KAH.ResumeLayout(false);
            this.groupBoxInput_KAH.PerformLayout();
            this.groupBoxOutPut_KAH.ResumeLayout(false);
            this.groupBoxOutPut_KAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.GroupBox groupBoxInput_KAH;
        private System.Windows.Forms.Button buttonInfo_KAH;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAH;
        private System.Windows.Forms.TextBox textBoxEndStep_KAH;
        private System.Windows.Forms.TextBox textBoxStartStep_KAH;
        private System.Windows.Forms.TextBox textBoxResult_KAH;
        private System.Windows.Forms.Label labelTask_KAH;
        private System.Windows.Forms.Label labelResult_KAH;
        private System.Windows.Forms.Label labelStopStep_KAH;
        private System.Windows.Forms.Label labelStartStep_KAH;
    }
}

