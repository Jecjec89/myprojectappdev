using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string registrationEmailInput
        {
            set {
                outputEmail.Text = value;
            }
        
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            homeControl1.Show();
            homeControl1.BringToFront();

            loginControl1.Hide();
            registrationControl1.Hide();
            userdetailsPan.Hide();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            registrationControl1.Show();
            registrationControl1.BringToFront();

            homeControl1.Hide();
            loginControl1.Hide();
            userdetailsPan.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            loginControl1.Show();
            loginControl1.BringToFront();

            homeControl1.Hide();
            registrationControl1.Hide();
            userdetailsPan.Hide();
        }



        private void outputEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
