
namespace Tyuiu.KalimullinaAH.Sprint6.Task0.V3
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.textBoxTask_KAH = new System.Windows.Forms.TextBox();
            this.labelTask_KAH = new System.Windows.Forms.Label();
            this.pictureBoxFormula_KAH = new System.Windows.Forms.PictureBox();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.textBoxVarX_KAH = new System.Windows.Forms.TextBox();
            this.groupBoxInput_KAH = new System.Windows.Forms.GroupBox();
            this.labelVarX_KAH = new System.Windows.Forms.Label();
            this.buttonHelp_KAH = new System.Windows.Forms.Button();
            this.textBoxResult_KAH = new System.Windows.Forms.TextBox();
            this.groupBoxOutPut_KAH = new System.Windows.Forms.GroupBox();
            this.labelResult_KAH = new System.Windows.Forms.Label();
            this.groupBoxTask_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAH)).BeginInit();
            this.groupBoxInput_KAH.SuspendLayout();
            this.groupBoxOutPut_KAH.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.textBoxTask_KAH);
            this.groupBoxTask_KAH.Controls.Add(this.labelTask_KAH);
            this.groupBoxTask_KAH.Controls.Add(this.pictureBoxFormula_KAH);
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(12, 22);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(608, 254);
            this.groupBoxTask_KAH.TabIndex = 0;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // textBoxTask_KAH
            // 
            this.textBoxTask_KAH.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxTask_KAH.Location = new System.Drawing.Point(6, 21);
            this.textBoxTask_KAH.Multiline = true;
            this.textBoxTask_KAH.Name = "textBoxTask_KAH";
            this.textBoxTask_KAH.Size = new System.Drawing.Size(368, 216);
            this.textBoxTask_KAH.TabIndex = 2;
            this.textBoxTask_KAH.Text = "Вычислить выражение по формуле";
            // 
            // labelTask_KAH
            // 
            this.labelTask_KAH.AutoSize = true;
            this.labelTask_KAH.Location = new System.Drawing.Point(29, 40);
            this.labelTask_KAH.Name = "labelTask_KAH";
            this.labelTask_KAH.Size = new System.Drawing.Size(0, 17);
            this.labelTask_KAH.TabIndex = 1;
            // 
            // pictureBoxFormula_KAH
            // 
            this.pictureBoxFormula_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task0.V3.Properties.Resources.Untitled;
            this.pictureBoxFormula_KAH.Location = new System.Drawing.Point(392, 21);
            this.pictureBoxFormula_KAH.Name = "pictureBoxFormula_KAH";
            this.pictureBoxFormula_KAH.Size = new System.Drawing.Size(196, 95);
            this.pictureBoxFormula_KAH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxFormula_KAH.TabIndex = 0;
            this.pictureBoxFormula_KAH.TabStop = false;
            this.pictureBoxFormula_KAH.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.Location = new System.Drawing.Point(497, 397);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(124, 43);
            this.buttonDone_KAH.TabIndex = 1;
            this.buttonDone_KAH.Text = "Выполнить";
            this.buttonDone_KAH.UseVisualStyleBackColor = true;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_KAH_Click);
            // 
            // textBoxVarX_KAH
            // 
            this.textBoxVarX_KAH.Location = new System.Drawing.Point(19, 62);
            this.textBoxVarX_KAH.Name = "textBoxVarX_KAH";
            this.textBoxVarX_KAH.Size = new System.Drawing.Size(105, 22);
            this.textBoxVarX_KAH.TabIndex = 2;
            this.textBoxVarX_KAH.TextChanged += new System.EventHandler(this.textBoxVarX_KAH_TextChanged);
            this.textBoxVarX_KAH.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxVarX_KAH_KeyPress);
            // 
            // groupBoxInput_KAH
            // 
            this.groupBoxInput_KAH.Controls.Add(this.labelVarX_KAH);
            this.groupBoxInput_KAH.Controls.Add(this.textBoxVarX_KAH);
            this.groupBoxInput_KAH.Location = new System.Drawing.Point(13, 297);
            this.groupBoxInput_KAH.Name = "groupBoxInput_KAH";
            this.groupBoxInput_KAH.Size = new System.Drawing.Size(172, 117);
            this.groupBoxInput_KAH.TabIndex = 4;
            this.groupBoxInput_KAH.TabStop = false;
            this.groupBoxInput_KAH.Text = "Ввод данных";
            // 
            // labelVarX_KAH
            // 
            this.labelVarX_KAH.AutoSize = true;
            this.labelVarX_KAH.Location = new System.Drawing.Point(17, 28);
            this.labelVarX_KAH.Name = "labelVarX_KAH";
            this.labelVarX_KAH.Size = new System.Drawing.Size(108, 17);
            this.labelVarX_KAH.TabIndex = 5;
            this.labelVarX_KAH.Text = "Переменная X:";
            // 
            // buttonHelp_KAH
            // 
            this.buttonHelp_KAH.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonHelp_KAH.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp_KAH.Location = new System.Drawing.Point(433, 397);
            this.buttonHelp_KAH.Name = "buttonHelp_KAH";
            this.buttonHelp_KAH.Size = new System.Drawing.Size(58, 42);
            this.buttonHelp_KAH.TabIndex = 4;
            this.buttonHelp_KAH.Text = "?";
            this.buttonHelp_KAH.UseVisualStyleBackColor = false;
            this.buttonHelp_KAH.Click += new System.EventHandler(this.buttonHelp_KAH_Click);
            // 
            // textBoxResult_KAH
            // 
            this.textBoxResult_KAH.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxResult_KAH.Location = new System.Drawing.Point(15, 62);
            this.textBoxResult_KAH.Name = "textBoxResult_KAH";
            this.textBoxResult_KAH.ReadOnly = true;
            this.textBoxResult_KAH.Size = new System.Drawing.Size(100, 22);
            this.textBoxResult_KAH.TabIndex = 3;
            this.textBoxResult_KAH.TextChanged += new System.EventHandler(this.textBoxResult_KAH_TextChanged);
            // 
            // groupBoxOutPut_KAH
            // 
            this.groupBoxOutPut_KAH.Controls.Add(this.labelResult_KAH);
            this.groupBoxOutPut_KAH.Controls.Add(this.textBoxResult_KAH);
            this.groupBoxOutPut_KAH.Location = new System.Drawing.Point(214, 297);
            this.groupBoxOutPut_KAH.Name = "groupBoxOutPut_KAH";
            this.groupBoxOutPut_KAH.Size = new System.Drawing.Size(200, 117);
            this.groupBoxOutPut_KAH.TabIndex = 5;
            this.groupBoxOutPut_KAH.TabStop = false;
            this.groupBoxOutPut_KAH.Text = "Вывод данных";
            // 
            // labelResult_KAH
            // 
            this.labelResult_KAH.AutoSize = true;
            this.labelResult_KAH.Location = new System.Drawing.Point(12, 28);
            this.labelResult_KAH.Name = "labelResult_KAH";
            this.labelResult_KAH.Size = new System.Drawing.Size(80, 17);
            this.labelResult_KAH.TabIndex = 6;
            this.labelResult_KAH.Text = "Результат:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.groupBoxOutPut_KAH);
            this.Controls.Add(this.groupBoxInput_KAH);
            this.Controls.Add(this.buttonHelp_KAH);
            this.Controls.Add(this.groupBoxTask_KAH);
            this.Controls.Add(this.buttonDone_KAH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 0 | Вариант 3 | Калимуллина А.Х";
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFormula_KAH)).EndInit();
            this.groupBoxInput_KAH.ResumeLayout(false);
            this.groupBoxInput_KAH.PerformLayout();
            this.groupBoxOutPut_KAH.ResumeLayout(false);
            this.groupBoxOutPut_KAH.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.PictureBox pictureBoxFormula_KAH;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.TextBox textBoxVarX_KAH;
        private System.Windows.Forms.GroupBox groupBoxInput_KAH;
        private System.Windows.Forms.Button buttonHelp_KAH;
        private System.Windows.Forms.Label labelVarX_KAH;
        private System.Windows.Forms.TextBox textBoxResult_KAH;
        private System.Windows.Forms.GroupBox groupBoxOutPut_KAH;
        private System.Windows.Forms.Label labelTask_KAH;
        private System.Windows.Forms.Label labelResult_KAH;
        private System.Windows.Forms.TextBox textBoxTask_KAH;
    }
}

