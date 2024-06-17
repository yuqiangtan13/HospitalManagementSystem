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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Hospital_Management_System
{
    public partial class Registration : Form
    {
        IMongoCollection<Users> userCollection;
        public Registration()
        {
            InitializeComponent();
            var connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnection"].ConnectionString;
            var databaseName = MongoUrl.Create(connectionString).DatabaseName;
            var mongoClient = new MongoClient(connectionString);
            var database = mongoClient.GetDatabase(databaseName);
            userCollection = database.GetCollection<Users>("Users");
        }

        private void button_Register_Click(object sender, EventArgs e)
        {
            //1.get info from user
            string username = textBox_Username.Text;
            string password = textBox_Password.Text;
            string role = label_Patient.Text;

            //2.check if the user already exixt
            if(textBox_Username.Text != string.Empty
                && textBox_Password.Text != string.Empty)
            {
                var filter = Builders<Users>.Filter.Eq("Username", username);
                var existingUser = userCollection.Find(filter);
                //3. Create an instance 
                if (existingUser != null)
                {
                    var user = new Users
                    {

                        Username = username,
                        Password = password,
                        Role = role
                    };

                    //4.add it to the database
                    userCollection.InsertOne(user);
                    MessageBox.Show("Registration Successful!");
                    //send them to main form
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    //user already exixt, show them the message
                    MessageBox.Show("Username already exist, Please choose a different one");


                }
            }
            else
            {
                MessageBox.Show("Please enter all data to register!");
            }
        }
    }
}
