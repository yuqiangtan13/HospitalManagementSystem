namespace Hospital_Management_System
{
    partial class Registration
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
            this.label_Username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Register = new System.Windows.Forms.Button();
            this.label_Role = new System.Windows.Forms.Label();
            this.label_Patient = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.Location = new System.Drawing.Point(109, 64);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(57, 18);
            this.label_Username.TabIndex = 0;
            this.label_Username.Text = "Name:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(78, 134);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(88, 18);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password:";
            // 
            // textBox_Username
            // 
            this.textBox_Username.Location = new System.Drawing.Point(173, 62);
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(202, 20);
            this.textBox_Username.TabIndex = 2;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(173, 132);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(202, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // button_Register
            // 
            this.button_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Register.Location = new System.Drawing.Point(92, 234);
            this.button_Register.Name = "button_Register";
            this.button_Register.Size = new System.Drawing.Size(283, 30);
            this.button_Register.TabIndex = 5;
            this.button_Register.Text = "Register";
            this.button_Register.UseVisualStyleBackColor = true;
            this.button_Register.Click += new System.EventHandler(this.button_Register_Click);
            // 
            // label_Role
            // 
            this.label_Role.AutoSize = true;
            this.label_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Role.Location = new System.Drawing.Point(118, 184);
            this.label_Role.Name = "label_Role";
            this.label_Role.Size = new System.Drawing.Size(48, 18);
            this.label_Role.TabIndex = 6;
            this.label_Role.Text = "Role:";
            // 
            // label_Patient
            // 
            this.label_Patient.AutoSize = true;
            this.label_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Patient.Location = new System.Drawing.Point(172, 184);
            this.label_Patient.Name = "label_Patient";
            this.label_Patient.Size = new System.Drawing.Size(60, 18);
            this.label_Patient.TabIndex = 7;
            this.label_Patient.Text = "Patient";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 288);
            this.Controls.Add(this.label_Patient);
            this.Controls.Add(this.label_Role);
            this.Controls.Add(this.button_Register);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Name = "Registration";
            this.Text = "Patient Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Register;
        private System.Windows.Forms.Label label_Role;
        private System.Windows.Forms.Label label_Patient;
    }
}

