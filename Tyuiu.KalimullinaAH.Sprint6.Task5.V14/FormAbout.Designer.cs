
namespace Tyuiu.KalimullinaAH.Sprint6.Task5.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.labelInfo_KAH = new System.Windows.Forms.Label();
            this.buttonOK_KAH = new System.Windows.Forms.Button();
            this.pictureBoxImage_KAH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KAH
            // 
            this.labelInfo_KAH.AutoSize = true;
            this.labelInfo_KAH.Location = new System.Drawing.Point(158, 9);
            this.labelInfo_KAH.Name = "labelInfo_KAH";
            this.labelInfo_KAH.Size = new System.Drawing.Size(370, 170);
            this.labelInfo_KAH.TabIndex = 1;
            this.labelInfo_KAH.Text = resources.GetString("labelInfo_KAH.Text");
            // 
            // buttonOK_KAH
            // 
            this.buttonOK_KAH.Location = new System.Drawing.Point(435, 168);
            this.buttonOK_KAH.Name = "buttonOK_KAH";
            this.buttonOK_KAH.Size = new System.Drawing.Size(75, 26);
            this.buttonOK_KAH.TabIndex = 2;
            this.buttonOK_KAH.Text = "OK";
            this.buttonOK_KAH.UseVisualStyleBackColor = true;
            this.buttonOK_KAH.Click += new System.EventHandler(this.buttonOK_KAH_Click);
            // 
            // pictureBoxImage_KAH
            // 
            this.pictureBoxImage_KAH.ErrorImage = global::Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Properties.Resources.photo_5449884010940583175_y;
            this.pictureBoxImage_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Properties.Resources.photo_5449884010940583175_y;
            this.pictureBoxImage_KAH.InitialImage = global::Tyuiu.KalimullinaAH.Sprint6.Task5.V14.Properties.Resources.photo_5449884010940583175_y;
            this.pictureBoxImage_KAH.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxImage_KAH.Name = "pictureBoxImage_KAH";
            this.pictureBoxImage_KAH.Size = new System.Drawing.Size(127, 176);
            this.pictureBoxImage_KAH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage_KAH.TabIndex = 0;
            this.pictureBoxImage_KAH.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 200);
            this.Controls.Add(this.buttonOK_KAH);
            this.Controls.Add(this.labelInfo_KAH);
            this.Controls.Add(this.pictureBoxImage_KAH);
            this.Name = "FormAbout";
            this.Text = " О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage_KAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelInfo_KAH;
        private System.Windows.Forms.Button buttonOK_KAH;
        private System.Windows.Forms.PictureBox pictureBoxImage_KAH;
    }
}