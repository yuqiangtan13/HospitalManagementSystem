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
    public partial class Data_Analytics : Form
    {
        public Data_Analytics()
        {
            InitializeComponent();
        }

        private void Data_Analytics_Load(object sender, EventArgs e)
        {

        }

        private void backToMainFormButton_Click(object sender, EventArgs e)
        {

            Hospital_Management_System MainForm = new Hospital_Management_System();
            MainForm.Show();
            this.Hide();

        }
    }
}
