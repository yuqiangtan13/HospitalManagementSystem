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
    public partial class Patient_Management : Form
    {
        IMongoCollection<Patients> PatientsCollection;
        public Patient_Management()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            PatientsCollection = database.GetCollection<Patients>("Patients");

            LoadPatientsData();
        }

        private void LoadPatientsData()
        {
            var filterDefinition = Builders<Patients>.Filter.Empty;
            var Patients = PatientsCollection.Find(filterDefinition).ToList();
            var displayList = Patients.Select(p => new
            {
                p.PatientId,
                p.Name,
                p.Age,
                MedicalHistory = p.MedicalHistoryString
            }).ToList();

            dataGridView_PatientData.DataSource = displayList;
        }

        private void button_BackToMainForm_Click(object sender, EventArgs e)
        {
            Hospital_Management_System mainForm = new Hospital_Management_System();
            mainForm.Show();
            this.Hide();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            var medicalHistory = listBox_MedicalHistory.Items.Cast<string>().ToList();
            var patients = new Patients
            {
                Name = textBox_Name.Text,
                PatientId = LoginState.GetLoggedInUserId,
                Age = Int32.Parse(textBox_Age.Text),
                MedicalHistory = medicalHistory
            };

            PatientsCollection.InsertOne(patients);
            LoadPatientsData();

        }

        private void button_AddMedication_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox_MedicalHistory.Text))
            {

                listBox_MedicalHistory.Items.Add(textBox_MedicalHistory.Text);
                textBox_MedicalHistory.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid medication.");
            }
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            var filterDefinition = Builders<Patients>.Filter.Eq("Name",textBox_Name.Text);
            PatientsCollection.DeleteOne(filterDefinition);

            MessageBox.Show("Deleted");
            LoadPatientsData();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            var medicalHistory = listBox_MedicalHistory.Items.Cast<string>().ToList();

            var filterDefinition = Builders<Patients>.Filter.Eq("Name", textBox_Name.Text);
            var patient = PatientsCollection.Find(filterDefinition).FirstOrDefault();
            var updateDefinition = Builders<Patients>.Update
                .Set("Name", textBox_Name.Text)
                .Set("PatientId", patient.PatientId)
                .Set("Age", Int32.Parse(textBox_Age.Text))
                .Set("MedicalHistory",medicalHistory);

            PatientsCollection.UpdateOne(filterDefinition, updateDefinition);
            MessageBox.Show("Updated!");
            LoadPatientsData() ;
        }
    }
}
