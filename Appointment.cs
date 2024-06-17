﻿using MongoDB.Driver;
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
        public Appointment()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            appointmentsCollection = database.GetCollection<Appointments>("Appointments");
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

        }

        private void Appointment_Load(object sender, EventArgs e)
        {

        }
    }
}