﻿namespace Tyuiu.KalimullinaAH.Sprint6.Task6.V24
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
            this.buttonOk_KAH = new System.Windows.Forms.Button();
            this.pictureBoxAvatar_KAH = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAH)).BeginInit();
            this.SuspendLayout();
            // 
            // labelInfo_KAH
            // 
            this.labelInfo_KAH.AutoSize = true;
            this.labelInfo_KAH.Location = new System.Drawing.Point(194, 22);
            this.labelInfo_KAH.Name = "labelInfo_KAH";
            this.labelInfo_KAH.Size = new System.Drawing.Size(370, 204);
            this.labelInfo_KAH.TabIndex = 1;
            this.labelInfo_KAH.Text = resources.GetString("labelInfo_KAH.Text");
            // 
            // buttonOk_KAH
            // 
            this.buttonOk_KAH.Location = new System.Drawing.Point(503, 229);
            this.buttonOk_KAH.Name = "buttonOk_KAH";
            this.buttonOk_KAH.Size = new System.Drawing.Size(75, 23);
            this.buttonOk_KAH.TabIndex = 0;
            this.buttonOk_KAH.Text = "OK";
            this.buttonOk_KAH.UseVisualStyleBackColor = true;
            this.buttonOk_KAH.Click += new System.EventHandler(this.buttonOk_KAH_Click);
            // 
            // pictureBoxAvatar_KAH
            // 
            this.pictureBoxAvatar_KAH.Image = global::Tyuiu.KalimullinaAH.Sprint6.Task6.V24.Properties.Resources.photo_5449884010940583175_y;
            this.pictureBoxAvatar_KAH.Location = new System.Drawing.Point(22, 22);
            this.pictureBoxAvatar_KAH.Name = "pictureBoxAvatar_KAH";
            this.pictureBoxAvatar_KAH.Size = new System.Drawing.Size(142, 192);
            this.pictureBoxAvatar_KAH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_KAH.TabIndex = 2;
            this.pictureBoxAvatar_KAH.TabStop = false;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 264);
            this.Controls.Add(this.pictureBoxAvatar_KAH);
            this.Controls.Add(this.labelInfo_KAH);
            this.Controls.Add(this.buttonOk_KAH);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_KAH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelInfo_KAH;
        private System.Windows.Forms.Button buttonOk_KAH;
        private System.Windows.Forms.PictureBox pictureBoxAvatar_KAH;
    }
}