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

namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        IMongoCollection<Users> userCollection;
        public Login()
        {
            InitializeComponent();
            
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            userCollection = database.GetCollection<Users>("Users");
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            //1. get info from the user

            string username = textBox_Username_Login.Text;
            string password = textBox_Password_Login.Text;

            //2. check user info against the database to see if it exists
            var filter = Builders<Users>.Filter.Eq("Username", username) &
                Builders<Users>.Filter.Eq("Password", password);

            var user = userCollection.Find(filter).FirstOrDefault();


            //if user exist, send them to main form, otherwise show them the error message
            if (user != null)
            {
                LoginState.GetLoggedInUserId = user.UserId;
                MessageBox.Show("Login Sucessful!");
                LoginState.IsLoggedIn = true;
                //Check if Patient

                if (user.Role == "Patient")
                {
                    LoginState.IsPatient = true;
                    MessageBox.Show("Patient Login");
                }
                //send them to main form
                Hospital_Management_System mainForm = new Hospital_Management_System();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                //error, Login failed
                MessageBox.Show("Invalid username or password");
            }


            
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }
    }
}
