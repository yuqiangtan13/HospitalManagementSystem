namespace Hospital_Management_System
{
    partial class Appointment
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
            this.dataGridView_Appointment = new System.Windows.Forms.DataGridView();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_AddAppointment = new System.Windows.Forms.Button();
            this.button_CancelAppointment = new System.Windows.Forms.Button();
            this.button_BackToMain = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_Date = new System.Windows.Forms.Label();
            this.label_Doctor = new System.Windows.Forms.Label();
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Appointment
            // 
            this.dataGridView_Appointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Appointment.Location = new System.Drawing.Point(27, 39);
            this.dataGridView_Appointment.Name = "dataGridView_Appointment";
            this.dataGridView_Appointment.RowHeadersWidth = 45;
            this.dataGridView_Appointment.Size = new System.Drawing.Size(430, 365);
            this.dataGridView_Appointment.TabIndex = 0;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(571, 55);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(171, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(571, 122);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button_AddAppointment
            // 
            this.button_AddAppointment.Location = new System.Drawing.Point(571, 232);
            this.button_AddAppointment.Name = "button_AddAppointment";
            this.button_AddAppointment.Size = new System.Drawing.Size(171, 23);
            this.button_AddAppointment.TabIndex = 3;
            this.button_AddAppointment.Text = "Schedule Appointment";
            this.button_AddAppointment.UseVisualStyleBackColor = true;
            this.button_AddAppointment.Click += new System.EventHandler(this.button_AddAppointment_Click);
            // 
            // button_CancelAppointment
            // 
            this.button_CancelAppointment.Location = new System.Drawing.Point(571, 310);
            this.button_CancelAppointment.Name = "button_CancelAppointment";
            this.button_CancelAppointment.Size = new System.Drawing.Size(171, 23);
            this.button_CancelAppointment.TabIndex = 4;
            this.button_CancelAppointment.Text = "Cancel Appointment";
            this.button_CancelAppointment.UseVisualStyleBackColor = true;
            // 
            // button_BackToMain
            // 
            this.button_BackToMain.Location = new System.Drawing.Point(571, 381);
            this.button_BackToMain.Name = "button_BackToMain";
            this.button_BackToMain.Size = new System.Drawing.Size(171, 23);
            this.button_BackToMain.TabIndex = 5;
            this.button_BackToMain.Text = "Hospital Management System";
            this.button_BackToMain.UseVisualStyleBackColor = true;
            this.button_BackToMain.Click += new System.EventHandler(this.button_BackToMain_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(498, 58);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 6;
            this.label_Name.Text = "Name";
            // 
            // label_Date
            // 
            this.label_Date.AutoSize = true;
            this.label_Date.Location = new System.Drawing.Point(498, 129);
            this.label_Date.Name = "label_Date";
            this.label_Date.Size = new System.Drawing.Size(30, 13);
            this.label_Date.TabIndex = 7;
            this.label_Date.Text = "Date";
            // 
            // label_Doctor
            // 
            this.label_Doctor.AutoSize = true;
            this.label_Doctor.Location = new System.Drawing.Point(498, 182);
            this.label_Doctor.Name = "label_Doctor";
            this.label_Doctor.Size = new System.Drawing.Size(39, 13);
            this.label_Doctor.TabIndex = 8;
            this.label_Doctor.Text = "Doctor";
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Items.AddRange(new object[] {
            "Dr. John",
            "Dr. Jane"});
            this.comboBox_Doctor.Location = new System.Drawing.Point(571, 179);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(171, 21);
            this.comboBox_Doctor.TabIndex = 9;
            // 
            // Appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_Doctor);
            this.Controls.Add(this.label_Doctor);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_BackToMain);
            this.Controls.Add(this.button_CancelAppointment);
            this.Controls.Add(this.button_AddAppointment);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.dataGridView_Appointment);
            this.Name = "Appointment";
            this.Text = "Appointment";
            this.Load += new System.EventHandler(this.Appointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Appointment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Appointment;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_AddAppointment;
        private System.Windows.Forms.Button button_CancelAppointment;
        private System.Windows.Forms.Button button_BackToMain;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.Label label_Doctor;
        private System.Windows.Forms.ComboBox comboBox_Doctor;
    }
}