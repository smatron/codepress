using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodePress
{
    public partial class ViewSignUp : Form
    {

        public ViewSignUp()
        {
            InitializeComponent();

            Logic dataLogic = new Logic();
            dataLogic.GenerateData();

            // Set the Format type and the CustomFormat string.
            BirthdayDatepicker.Format = DateTimePickerFormat.Custom;
            BirthdayDatepicker.CustomFormat = "yyyy-MM-dd";

            // Add values to combobox
            ProfessionCombobox.Items.Add("Designer");
            ProfessionCombobox.Items.Add("Engineer");
            ProfessionCombobox.Items.Add("Testing");
            ProfessionCombobox.Items.Add("Operator");
            ProfessionCombobox.Items.Add("Administrator");
        }

        private void SignupButton_Click(object sender, EventArgs e)
        {
            string firstname = FirstNameTextbox.Text;
            string lastname = LastNameTextbox.Text;

            //Setting Radiobox values
            string gender = MaleRadio.Checked == true ? gender = "Male"
                    : FemaleRadio.Checked == true ? gender = "Female"
                    : OthersRadio.Checked == true ? gender = "Others"
                    : gender = "";
            
            string birthday = BirthdayDatepicker.Text;
            string profession = ProfessionCombobox.Text;
            string email = EmailTextbox.Text;
            string emailAgain = EmailAgainTexbox.Text;
            string username = UsernameTextbox.Text;
            string password = PasswordTextbox.Text;
            
            //Form Validation
            if(FirstNameTextbox.TextLength != 0 && gender != "" && BirthdayDatepicker.Text != "" && UsernameTextbox.TextLength != 0 && PasswordTextbox.TextLength != 0 && EmailTextbox.TextLength != 0 && EmailTextbox.Text == EmailAgainTexbox.Text)
            {
                Logic dataLogic = new Logic();

                //Validate the User: True, False, Duplication
                string result = dataLogic.Validate(username);

                //Form Validation
                if (AgreeCheckbox.Checked == true)
                {
                    if (result == "True") {
                        String insertQuery = "INSERT INTO user(firstname,lastname,gender,birthday,profession,email,username,password) VALUES ('" + firstname + "', '" + lastname + "','" + gender + "','" + birthday + "', '" + profession + "', '" + email + "', '" + username + "', '" + password + "')";
                        dataLogic.RunQuery(insertQuery);
                    }
                    else
                    {
                        MessageBox.Show("Choose a different Username", "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Please Check the i agree", "Agreement Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
   
            }
            else
            {
                MessageBox.Show("Please fill the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //Show ViewSignin Form
        private void SigninButton_Click(object sender, EventArgs e)
        {
            ViewSignin viewSignin = new ViewSignin();
            viewSignin.Show();

            this.Hide();
        }

    }
}
