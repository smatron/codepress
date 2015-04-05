using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodePress
{
    public partial class ViewSignin : Form
    {
        public ViewSignin()
        {
            InitializeComponent();
        }

        //Authenticate the User based on Username & Password
        private void SigninButton_Click(object sender, EventArgs e)
        {
            Logic dataLogic = new Logic();

            //Returns True if the Username & Password matched with the user input 
            string result = dataLogic.Authenticate(UsernameTextbox.Text, PasswordTextbox.Text);

            if(result == "True") {
                ViewDashboard viewDashboard = new ViewDashboard();
                viewDashboard.Show();
            } else
            {              
                MessageBox.Show("Username & Password is Not Correct");
            }
        }

        //View ViewSignUp Form
        private void SignupButton_Click(object sender, EventArgs e)
        {
            ViewSignUp viewSignup = new ViewSignUp();
            viewSignup.Show();

            this.Hide();
        }
    }
}
