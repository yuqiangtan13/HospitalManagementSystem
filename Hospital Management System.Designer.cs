namespace Hospital_Management_System
{
    partial class Hospital_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_PatientManagement = new System.Windows.Forms.Button();
            this.button_AppointmentScheduling = new System.Windows.Forms.Button();
            this.button_MedicalInventory = new System.Windows.Forms.Button();
            this.button_DataAnalytics = new System.Windows.Forms.Button();
            this.button_Communication = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hospital Management System";
            // 
            // button_PatientManagement
            // 
            this.button_PatientManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_PatientManagement.Location = new System.Drawing.Point(137, 131);
            this.button_PatientManagement.Name = "button_PatientManagement";
            this.button_PatientManagement.Size = new System.Drawing.Size(175, 36);
            this.button_PatientManagement.TabIndex = 1;
            this.button_PatientManagement.Text = "Patient Management";
            this.button_PatientManagement.UseVisualStyleBackColor = true;
            this.button_PatientManagement.Click += new System.EventHandler(this.button_PatientManagement_Click);
            // 
            // button_AppointmentScheduling
            // 
            this.button_AppointmentScheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AppointmentScheduling.Location = new System.Drawing.Point(137, 199);
            this.button_AppointmentScheduling.Name = "button_AppointmentScheduling";
            this.button_AppointmentScheduling.Size = new System.Drawing.Size(175, 36);
            this.button_AppointmentScheduling.TabIndex = 2;
            this.button_AppointmentScheduling.Text = "Appointment Scheduling";
            this.button_AppointmentScheduling.UseVisualStyleBackColor = true;
            this.button_AppointmentScheduling.Click += new System.EventHandler(this.button_AppointmentScheduling_Click);
            // 
            // button_MedicalInventory
            // 
            this.button_MedicalInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_MedicalInventory.Location = new System.Drawing.Point(137, 275);
            this.button_MedicalInventory.Name = "button_MedicalInventory";
            this.button_MedicalInventory.Size = new System.Drawing.Size(175, 36);
            this.button_MedicalInventory.TabIndex = 3;
            this.button_MedicalInventory.Text = "Medical Inventory Management";
            this.button_MedicalInventory.UseVisualStyleBackColor = true;
            this.button_MedicalInventory.Click += new System.EventHandler(this.button_MedicalInventory_Click);
            // 
            // button_DataAnalytics
            // 
            this.button_DataAnalytics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DataAnalytics.Location = new System.Drawing.Point(479, 131);
            this.button_DataAnalytics.Name = "button_DataAnalytics";
            this.button_DataAnalytics.Size = new System.Drawing.Size(175, 36);
            this.button_DataAnalytics.TabIndex = 4;
            this.button_DataAnalytics.Text = "Data Analytics";
            this.button_DataAnalytics.UseVisualStyleBackColor = true;
            this.button_DataAnalytics.Click += new System.EventHandler(this.button_DataAnalytics_Click);
            // 
            // button_Communication
            // 
            this.button_Communication.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Communication.Location = new System.Drawing.Point(479, 199);
            this.button_Communication.Name = "button_Communication";
            this.button_Communication.Size = new System.Drawing.Size(175, 36);
            this.button_Communication.TabIndex = 5;
            this.button_Communication.Text = "Communication";
            this.button_Communication.UseVisualStyleBackColor = true;
            // 
            // button_Logout
            // 
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(479, 275);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(175, 36);
            this.button_Logout.TabIndex = 6;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // Hospital_Management_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 398);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.button_Communication);
            this.Controls.Add(this.button_DataAnalytics);
            this.Controls.Add(this.button_MedicalInventory);
            this.Controls.Add(this.button_AppointmentScheduling);
            this.Controls.Add(this.button_PatientManagement);
            this.Controls.Add(this.label1);
            this.Name = "Hospital_Management_System";
            this.Text = "Hospital_Management_System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_PatientManagement;
        private System.Windows.Forms.Button button_AppointmentScheduling;
        private System.Windows.Forms.Button button_MedicalInventory;
        private System.Windows.Forms.Button button_DataAnalytics;
        private System.Windows.Forms.Button button_Communication;
        private System.Windows.Forms.Button button_Logout;
    }
}