using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class Hospital_Management_System : Form
    {
        public Hospital_Management_System()
        {
            InitializeComponent();
        }

        private void button_PatientManagement_Click(object sender, EventArgs e)
        {
            if(LoginState.IsPatient == true)
            {
                MessageBox.Show("You don't have access to this form");
            }
            else
            {
                Patient_Management patient_Management = new Patient_Management();
                patient_Management.Show();
                this.Hide();
            }
            
        }

        private void button_AppointmentScheduling_Click(object sender, EventArgs e)
        {
            
            if(LoginState.IsPatient == true)
            {
                Appointment AppointmentForm = new Appointment();
                AppointmentForm.Show();
                this.Hide();
               
            }
            else
            {
                MessageBox.Show("You don't have access to this form");
            }
            
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            LoginState.IsLoggedIn = false;
            LoginState.IsPatient = false;
            LoginState.GetLoggedInUserId = string.Empty;
            PatientState.GetLoggedInPatientId = string.Empty;
            PatientState.GetLoggedInPatientName = string.Empty;
            
            
            MessageBox.Show("Logout Sucessful!");
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void button_MedicalInventory_Click(object sender, EventArgs e)
        {
            InventoryForm inventoryForm = new InventoryForm();
            inventoryForm.Show();
        }

        private void button_DataAnalytics_Click(object sender, EventArgs e)
        {
            Data_Analytics dataAnalyticsForm = new Data_Analytics();
            dataAnalyticsForm.Show();
        }



    }
}
