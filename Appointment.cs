using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Menu;

namespace Hospital_Management_System
{
    public partial class Appointment : Form
    {
        IMongoCollection<Appointments> appointmentsCollection;
        IMongoCollection<Patients> patientCollection;
        
        public Appointment()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            appointmentsCollection = database.GetCollection<Appointments>("Appointments");
            patientCollection = database.GetCollection<Patients>("Patients");
            LoadAppointmentData();
        }

        private void LoadAppointmentData()
        {
            var filterDefinition = Builders<Appointments>.Filter.Empty;
            var Appointments = appointmentsCollection.Find(filterDefinition).ToList();

            dataGridView_Appointment.DataSource = Appointments;
        }

        private void button_BackToMain_Click(object sender, EventArgs e)
        {
            Hospital_Management_System MainForm = new Hospital_Management_System();
            MainForm.Show();
            this.Hide();
        }

        private void button_AddAppointment_Click(object sender, EventArgs e)
        {
           
            var filter = Builders<Appointments>.Filter.Eq("PatientId", PatientState.GetLoggedInPatientId);
            var existAppointment = appointmentsCollection.Find(filter).FirstOrDefault();
            if(existAppointment == null)
            {
                var appointment = new Appointments
                {
                    PatientId = PatientState.GetLoggedInPatientId,
                    Doctor = comboBox_Doctor.Text,
                    Date = dateTimePicker1.Value,
                    Status = "Scheduled"
                };

                appointmentsCollection.InsertOne(appointment);
                MessageBox.Show("Appointment made successfully!");

                if (PatientState.GetLoggedInPatientId == null)
                {
                    throw new Exception("PatientId is null. Ensure GetLoggedInPatientId is returning a valid ID.");
                }

                if (PatientState.GetLoggedInPatientName == null)
                {
                    throw new Exception("PatientName is null. Ensure GetLoggedInPatientName is returning a valid name.");
                }
                var history = new List<string> { "None" };
                var patient = new Patients
                {
                    PatientId = PatientState.GetLoggedInPatientId,
                    Name = PatientState.GetLoggedInPatientName,
                    Age = 0,
                    MedicalHistory = history
                };
                patientCollection.InsertOne(patient);
                

                
                LoadAppointmentData();


            }
            else
            {
                MessageBox.Show("Appointment exist");
            }
            


        }

        private void Appointment_Load(object sender, EventArgs e)
        {
            textBox_Name.Text = PatientState.GetLoggedInPatientName;
        }

        private void button_CancelAppointment_Click(object sender, EventArgs e)
        {
            var filter = Builders<Appointments>.Filter.Eq("PatientId", PatientState.GetLoggedInPatientId);
            var existAppointment = appointmentsCollection.Find(filter).FirstOrDefault();
            if(existAppointment != null)
            {
                appointmentsCollection.DeleteOne(filter);
                MessageBox.Show("Appointed Cancel!");
                LoadAppointmentData();
            }
            else
            {
                MessageBox.Show("You don't have appointment");
            }

            
        }
    }
}
