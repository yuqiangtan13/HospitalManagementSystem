﻿namespace Hospital_Management_System
{
    partial class Data_Analytics
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
            this.backToMainFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backToMainFormButton
            // 
            this.backToMainFormButton.Location = new System.Drawing.Point(483, 69);
            this.backToMainFormButton.Name = "backToMainFormButton";
            this.backToMainFormButton.Size = new System.Drawing.Size(109, 23);
            this.backToMainFormButton.TabIndex = 13;
            this.backToMainFormButton.Text = "Back to Main Form";
            this.backToMainFormButton.UseVisualStyleBackColor = true;
            this.backToMainFormButton.Click += new System.EventHandler(this.backToMainFormButton_Click);
            // 
            // Data_Analytics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backToMainFormButton);
            this.Name = "Data_Analytics";
            this.Text = "Data_Analytics";
            this.Load += new System.EventHandler(this.Data_Analytics_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button backToMainFormButton;
    }
}