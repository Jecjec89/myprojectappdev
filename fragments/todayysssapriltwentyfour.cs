using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            homeControl1.Show();
            homeControl1.BringToFront();

            loginUser1.Hide();
            regustrationUser1.Hide();


        }

        private void loginUser1_Load(object sender, EventArgs e)
        {

        }

        private void regustrationUser1_Load(object sender, EventArgs e)
        {

        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            regustrationUser1.Show();
            regustrationUser1.BringToFront();

            loginUser1.Hide();
            homeControl1.Hide();
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            loginUser1.Show();
            loginUser1.BringToFront();

            regustrationUser1.Hide();
            homeControl1.Hide();
        
        }
    }
}
