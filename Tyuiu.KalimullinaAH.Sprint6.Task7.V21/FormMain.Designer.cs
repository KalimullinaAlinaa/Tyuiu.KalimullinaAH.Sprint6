
namespace Tyuiu.KalimullinaAH.Sprint6.Task7.V21
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelOutPut_KAH = new System.Windows.Forms.Panel();
            this.groupBoxResult_KAH = new System.Windows.Forms.GroupBox();
            this.panelInPut_KAH = new System.Windows.Forms.Panel();
            this.groupBoxLoadFile_KAH = new System.Windows.Forms.GroupBox();
            this.panelTask_KAH = new System.Windows.Forms.Panel();
            this.groupBoxTask_KAH = new System.Windows.Forms.GroupBox();
            this.labelTask_KAH = new System.Windows.Forms.Label();
            this.groupBoxButton_KAH = new System.Windows.Forms.GroupBox();
            this.dataGridViewOut_KAH = new System.Windows.Forms.DataGridView();
            this.dataGridViewIn_KAH = new System.Windows.Forms.DataGridView();
            this.openFileDialogTask_KAH = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMatrix_KAH = new System.Windows.Forms.SaveFileDialog();
            this.buttonSave_KAH = new System.Windows.Forms.Button();
            this.buttonHelp_KAH = new System.Windows.Forms.Button();
            this.buttonOpenFile_KAH = new System.Windows.Forms.Button();
            this.buttonDone_KAH = new System.Windows.Forms.Button();
            this.toolTipButtons_KAH = new System.Windows.Forms.ToolTip(this.components);
            this.panelOutPut_KAH.SuspendLayout();
            this.groupBoxResult_KAH.SuspendLayout();
            this.panelInPut_KAH.SuspendLayout();
            this.groupBoxLoadFile_KAH.SuspendLayout();
            this.panelTask_KAH.SuspendLayout();
            this.groupBoxTask_KAH.SuspendLayout();
            this.groupBoxButton_KAH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KAH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(462, 166);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 445);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // panelOutPut_KAH
            // 
            this.panelOutPut_KAH.Controls.Add(this.groupBoxResult_KAH);
            this.panelOutPut_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOutPut_KAH.Location = new System.Drawing.Point(462, 166);
            this.panelOutPut_KAH.Name = "panelOutPut_KAH";
            this.panelOutPut_KAH.Size = new System.Drawing.Size(550, 445);
            this.panelOutPut_KAH.TabIndex = 6;
            // 
            // groupBoxResult_KAH
            // 
            this.groupBoxResult_KAH.Controls.Add(this.dataGridViewOut_KAH);
            this.groupBoxResult_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxResult_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxResult_KAH.Name = "groupBoxResult_KAH";
            this.groupBoxResult_KAH.Size = new System.Drawing.Size(550, 445);
            this.groupBoxResult_KAH.TabIndex = 0;
            this.groupBoxResult_KAH.TabStop = false;
            this.groupBoxResult_KAH.Text = "Вывод:";
            // 
            // panelInPut_KAH
            // 
            this.panelInPut_KAH.Controls.Add(this.groupBoxLoadFile_KAH);
            this.panelInPut_KAH.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelInPut_KAH.Location = new System.Drawing.Point(0, 166);
            this.panelInPut_KAH.Name = "panelInPut_KAH";
            this.panelInPut_KAH.Size = new System.Drawing.Size(462, 445);
            this.panelInPut_KAH.TabIndex = 5;
            // 
            // groupBoxLoadFile_KAH
            // 
            this.groupBoxLoadFile_KAH.Controls.Add(this.dataGridViewIn_KAH);
            this.groupBoxLoadFile_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLoadFile_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLoadFile_KAH.Name = "groupBoxLoadFile_KAH";
            this.groupBoxLoadFile_KAH.Size = new System.Drawing.Size(462, 445);
            this.groupBoxLoadFile_KAH.TabIndex = 0;
            this.groupBoxLoadFile_KAH.TabStop = false;
            this.groupBoxLoadFile_KAH.Text = "Ввод:";
            // 
            // panelTask_KAH
            // 
            this.panelTask_KAH.Controls.Add(this.groupBoxTask_KAH);
            this.panelTask_KAH.Controls.Add(this.groupBoxButton_KAH);
            this.panelTask_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTask_KAH.Location = new System.Drawing.Point(0, 0);
            this.panelTask_KAH.Name = "panelTask_KAH";
            this.panelTask_KAH.Size = new System.Drawing.Size(1012, 166);
            this.panelTask_KAH.TabIndex = 4;
            // 
            // groupBoxTask_KAH
            // 
            this.groupBoxTask_KAH.Controls.Add(this.labelTask_KAH);
            this.groupBoxTask_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTask_KAH.Location = new System.Drawing.Point(0, 88);
            this.groupBoxTask_KAH.Name = "groupBoxTask_KAH";
            this.groupBoxTask_KAH.Size = new System.Drawing.Size(1012, 78);
            this.groupBoxTask_KAH.TabIndex = 4;
            this.groupBoxTask_KAH.TabStop = false;
            this.groupBoxTask_KAH.Text = "Условие";
            // 
            // labelTask_KAH
            // 
            this.labelTask_KAH.AutoSize = true;
            this.labelTask_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTask_KAH.Location = new System.Drawing.Point(3, 18);
            this.labelTask_KAH.Name = "labelTask_KAH";
            this.labelTask_KAH.Size = new System.Drawing.Size(1012, 51);
            this.labelTask_KAH.TabIndex = 0;
            this.labelTask_KAH.Text = resources.GetString("labelTask_KAH.Text");
            // 
            // groupBoxButton_KAH
            // 
            this.groupBoxButton_KAH.Controls.Add(this.buttonSave_KAH);
            this.groupBoxButton_KAH.Controls.Add(this.buttonHelp_KAH);
            this.groupBoxButton_KAH.Controls.Add(this.buttonOpenFile_KAH);
            this.groupBoxButton_KAH.Controls.Add(this.buttonDone_KAH);
            this.groupBoxButton_KAH.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxButton_KAH.Location = new System.Drawing.Point(0, 0);
            this.groupBoxButton_KAH.Name = "groupBoxButton_KAH";
            this.groupBoxButton_KAH.Size = new System.Drawing.Size(1012, 88);
            this.groupBoxButton_KAH.TabIndex = 3;
            this.groupBoxButton_KAH.TabStop = false;
            // 
            // dataGridViewOut_KAH
            // 
            this.dataGridViewOut_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOut_KAH.ColumnHeadersVisible = false;
            this.dataGridViewOut_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOut_KAH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewOut_KAH.Name = "dataGridViewOut_KAH";
            this.dataGridViewOut_KAH.ReadOnly = true;
            this.dataGridViewOut_KAH.RowHeadersVisible = false;
            this.dataGridViewOut_KAH.RowHeadersWidth = 51;
            this.dataGridViewOut_KAH.RowTemplate.Height = 24;
            this.dataGridViewOut_KAH.Size = new System.Drawing.Size(544, 424);
            this.dataGridViewOut_KAH.TabIndex = 0;
            // 
            // dataGridViewIn_KAH
            // 
            this.dataGridViewIn_KAH.AllowUserToOrderColumns = true;
            this.dataGridViewIn_KAH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIn_KAH.ColumnHeadersVisible = false;
            this.dataGridViewIn_KAH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewIn_KAH.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewIn_KAH.Name = "dataGridViewIn_KAH";
            this.dataGridViewIn_KAH.ReadOnly = true;
            this.dataGridViewIn_KAH.RowHeadersVisible = false;
            this.dataGridViewIn_KAH.RowHeadersWidth = 51;
            this.dataGridViewIn_KAH.RowTemplate.Height = 24;
            this.dataGridViewIn_KAH.Size = new System.Drawing.Size(456, 424);
            this.dataGridViewIn_KAH.TabIndex = 0;
            // 
            // buttonSave_KAH
            // 
            this.buttonSave_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave_KAH.Enabled = false;
            this.buttonSave_KAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_KAH.ForeColor = System.Drawing.Color.Silver;
            this.buttonSave_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task7.V21.Properties.Resources.page_save;
            this.buttonSave_KAH.Location = new System.Drawing.Point(274, 12);
            this.buttonSave_KAH.Name = "buttonSave_KAH";
            this.buttonSave_KAH.Size = new System.Drawing.Size(107, 70);
            this.buttonSave_KAH.TabIndex = 3;
            this.toolTipButtons_KAH.SetToolTip(this.buttonSave_KAH, "Сохранить обработанные данные в файл в формате CSV");
            this.buttonSave_KAH.UseVisualStyleBackColor = true;
            this.buttonSave_KAH.Click += new System.EventHandler(this.buttonSave_KAH_Click);
            this.buttonSave_KAH.MouseEnter += new System.EventHandler(this.buttonSave_KAH_MouseEnter);
            // 
            // buttonHelp_KAH
            // 
            this.buttonHelp_KAH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task7.V21.Properties.Resources.information;
            this.buttonHelp_KAH.Location = new System.Drawing.Point(899, 12);
            this.buttonHelp_KAH.Name = "buttonHelp_KAH";
            this.buttonHelp_KAH.Size = new System.Drawing.Size(107, 70);
            this.buttonHelp_KAH.TabIndex = 2;
            this.toolTipButtons_KAH.SetToolTip(this.buttonHelp_KAH, "Сведение о программе");
            this.buttonHelp_KAH.UseVisualStyleBackColor = true;
            this.buttonHelp_KAH.Click += new System.EventHandler(this.buttonHelp_KAH_Click);
            this.buttonHelp_KAH.MouseEnter += new System.EventHandler(this.buttonHelp_KAH_MouseEnter);
            // 
            // buttonOpenFile_KAH
            // 
            this.buttonOpenFile_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpenFile_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task7.V21.Properties.Resources.folder_page;
            this.buttonOpenFile_KAH.Location = new System.Drawing.Point(12, 12);
            this.buttonOpenFile_KAH.Name = "buttonOpenFile_KAH";
            this.buttonOpenFile_KAH.Size = new System.Drawing.Size(107, 70);
            this.buttonOpenFile_KAH.TabIndex = 0;
            this.toolTipButtons_KAH.SetToolTip(this.buttonOpenFile_KAH, "Открыть файл для обработки данных в формате CSV");
            this.buttonOpenFile_KAH.UseVisualStyleBackColor = true;
            this.buttonOpenFile_KAH.Click += new System.EventHandler(this.buttonOpenFile_KAH_Click);
            this.buttonOpenFile_KAH.MouseEnter += new System.EventHandler(this.buttonOpenFile_KAH_MouseEnter);
            // 
            // buttonDone_KAH
            // 
            this.buttonDone_KAH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDone_KAH.Enabled = false;
            this.buttonDone_KAH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDone_KAH.ForeColor = System.Drawing.Color.Silver;
            this.buttonDone_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task7.V21.Properties.Resources.page_white_go;
            this.buttonDone_KAH.Location = new System.Drawing.Point(141, 12);
            this.buttonDone_KAH.Name = "buttonDone_KAH";
            this.buttonDone_KAH.Size = new System.Drawing.Size(107, 70);
            this.buttonDone_KAH.TabIndex = 0;
            this.toolTipButtons_KAH.SetToolTip(this.buttonDone_KAH, "Выполнить обработку данных");
            this.buttonDone_KAH.UseVisualStyleBackColor = true;
            this.buttonDone_KAH.Click += new System.EventHandler(this.buttonDone_KAH_Click);
            this.buttonDone_KAH.MouseEnter += new System.EventHandler(this.buttonDone_KAH_MouseEnter);
            // 
            // toolTipButtons_KAH
            // 
            this.toolTipButtons_KAH.IsBalloon = true;
            this.toolTipButtons_KAH.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 611);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelOutPut_KAH);
            this.Controls.Add(this.panelInPut_KAH);
            this.Controls.Add(this.panelTask_KAH);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Спринт 6 | Таск 7 | Вариант 21 | Калимуллина А.Х";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelOutPut_KAH.ResumeLayout(false);
            this.groupBoxResult_KAH.ResumeLayout(false);
            this.panelInPut_KAH.ResumeLayout(false);
            this.groupBoxLoadFile_KAH.ResumeLayout(false);
            this.panelTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.ResumeLayout(false);
            this.groupBoxTask_KAH.PerformLayout();
            this.groupBoxButton_KAH.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOut_KAH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIn_KAH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelOutPut_KAH;
        private System.Windows.Forms.GroupBox groupBoxResult_KAH;
        private System.Windows.Forms.DataGridView dataGridViewIn_KAH;
        private System.Windows.Forms.Panel panelInPut_KAH;
        private System.Windows.Forms.GroupBox groupBoxLoadFile_KAH;
        private System.Windows.Forms.DataGridView dataGridViewOut_KAH;
        private System.Windows.Forms.Panel panelTask_KAH;
        private System.Windows.Forms.GroupBox groupBoxTask_KAH;
        private System.Windows.Forms.Label labelTask_KAH;
        private System.Windows.Forms.GroupBox groupBoxButton_KAH;
        private System.Windows.Forms.Button buttonHelp_KAH;
        private System.Windows.Forms.Button buttonOpenFile_KAH;
        private System.Windows.Forms.Button buttonDone_KAH;
        private System.Windows.Forms.Button buttonSave_KAH;
        private System.Windows.Forms.OpenFileDialog openFileDialogTask_KAH;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMatrix_KAH;
        private System.Windows.Forms.ToolTip toolTipButtons_KAH;
    }
}

