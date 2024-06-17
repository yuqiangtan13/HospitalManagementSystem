namespace Hospital_Management_System
{
    partial class Patient_Management
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
            this.dataGridView_PatientData = new System.Windows.Forms.DataGridView();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_BackToMainForm = new System.Windows.Forms.Button();
            this.label_Name = new System.Windows.Forms.Label();
            this.label_MedicalHistory = new System.Windows.Forms.Label();
            this.label_PatientId = new System.Windows.Forms.Label();
            this.textBox_PatientId = new System.Windows.Forms.TextBox();
            this.label_Age = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.listBox_MedicalHistory = new System.Windows.Forms.ListBox();
            this.textBox_MedicalHistory = new System.Windows.Forms.TextBox();
            this.button_AddMedication = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientData)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_PatientData
            // 
            this.dataGridView_PatientData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_PatientData.Location = new System.Drawing.Point(12, 39);
            this.dataGridView_PatientData.Name = "dataGridView_PatientData";
            this.dataGridView_PatientData.RowHeadersWidth = 45;
            this.dataGridView_PatientData.Size = new System.Drawing.Size(528, 461);
            this.dataGridView_PatientData.TabIndex = 0;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(648, 87);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(169, 20);
            this.textBox_Name.TabIndex = 1;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(646, 332);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(169, 23);
            this.button_Add.TabIndex = 3;
            this.button_Add.Text = "Add Patient Record";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(646, 425);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(169, 23);
            this.button_Delete.TabIndex = 4;
            this.button_Delete.Text = "Delete Patient Record";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(646, 377);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(169, 23);
            this.button_Update.TabIndex = 5;
            this.button_Update.Text = "Update Patient Record";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_BackToMainForm
            // 
            this.button_BackToMainForm.Location = new System.Drawing.Point(646, 476);
            this.button_BackToMainForm.Name = "button_BackToMainForm";
            this.button_BackToMainForm.Size = new System.Drawing.Size(169, 23);
            this.button_BackToMainForm.TabIndex = 6;
            this.button_BackToMainForm.Text = "Hospital Management System";
            this.button_BackToMainForm.UseVisualStyleBackColor = true;
            this.button_BackToMainForm.Click += new System.EventHandler(this.button_BackToMainForm_Click);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(590, 94);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(35, 13);
            this.label_Name.TabIndex = 7;
            this.label_Name.Text = "Name";
            // 
            // label_MedicalHistory
            // 
            this.label_MedicalHistory.AutoSize = true;
            this.label_MedicalHistory.Location = new System.Drawing.Point(546, 181);
            this.label_MedicalHistory.Name = "label_MedicalHistory";
            this.label_MedicalHistory.Size = new System.Drawing.Size(79, 13);
            this.label_MedicalHistory.TabIndex = 8;
            this.label_MedicalHistory.Text = "Medical History";
            // 
            // label_PatientId
            // 
            this.label_PatientId.AutoSize = true;
            this.label_PatientId.Location = new System.Drawing.Point(576, 42);
            this.label_PatientId.Name = "label_PatientId";
            this.label_PatientId.Size = new System.Drawing.Size(49, 13);
            this.label_PatientId.TabIndex = 9;
            this.label_PatientId.Text = "PatientId";
            // 
            // textBox_PatientId
            // 
            this.textBox_PatientId.Location = new System.Drawing.Point(648, 39);
            this.textBox_PatientId.Name = "textBox_PatientId";
            this.textBox_PatientId.Size = new System.Drawing.Size(169, 20);
            this.textBox_PatientId.TabIndex = 10;
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Location = new System.Drawing.Point(599, 134);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(26, 13);
            this.label_Age.TabIndex = 11;
            this.label_Age.Text = "Age";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(648, 134);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(169, 20);
            this.textBox_Age.TabIndex = 12;
            // 
            // listBox_MedicalHistory
            // 
            this.listBox_MedicalHistory.FormattingEnabled = true;
            this.listBox_MedicalHistory.Location = new System.Drawing.Point(646, 256);
            this.listBox_MedicalHistory.Name = "listBox_MedicalHistory";
            this.listBox_MedicalHistory.Size = new System.Drawing.Size(168, 56);
            this.listBox_MedicalHistory.TabIndex = 13;
            // 
            // textBox_MedicalHistory
            // 
            this.textBox_MedicalHistory.Location = new System.Drawing.Point(646, 181);
            this.textBox_MedicalHistory.Name = "textBox_MedicalHistory";
            this.textBox_MedicalHistory.Size = new System.Drawing.Size(169, 20);
            this.textBox_MedicalHistory.TabIndex = 14;
            // 
            // button_AddMedication
            // 
            this.button_AddMedication.Location = new System.Drawing.Point(645, 217);
            this.button_AddMedication.Name = "button_AddMedication";
            this.button_AddMedication.Size = new System.Drawing.Size(169, 23);
            this.button_AddMedication.TabIndex = 15;
            this.button_AddMedication.Text = "Add Medical History";
            this.button_AddMedication.UseVisualStyleBackColor = true;
            this.button_AddMedication.Click += new System.EventHandler(this.button_AddMedication_Click);
            // 
            // Patient_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 512);
            this.Controls.Add(this.button_AddMedication);
            this.Controls.Add(this.textBox_MedicalHistory);
            this.Controls.Add(this.listBox_MedicalHistory);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.textBox_PatientId);
            this.Controls.Add(this.label_PatientId);
            this.Controls.Add(this.label_MedicalHistory);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.button_BackToMainForm);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.dataGridView_PatientData);
            this.Name = "Patient_Management";
            this.Text = "Patient_Management";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_PatientData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_PatientData;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_BackToMainForm;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label_MedicalHistory;
        private System.Windows.Forms.Label label_PatientId;
        private System.Windows.Forms.TextBox textBox_PatientId;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.ListBox listBox_MedicalHistory;
        private System.Windows.Forms.TextBox textBox_MedicalHistory;
        private System.Windows.Forms.Button button_AddMedication;
    }
}