using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class RegistrationControl : UserControl
    {
        public RegistrationControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            var emailInput = this.emailInput.Text;
            var usernameOutput = this.usernameInput.Text;
            var passwordInput = this.passwordInput.Text;

            //Parent
            var parent = this.Parent as Form1;
            parent.registrationEmailInput = emailInput;
     
        }
    }
}
