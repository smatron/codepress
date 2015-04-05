using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CodePress
{
    public partial class ViewUpdate : Form
    {
        string _mySqlConnection;

        int _userId;
        string _gender;

        public ViewUpdate()
        {
            InitializeComponent();

            Logic dataLogic = new Logic();
            _mySqlConnection = dataLogic.MySqlConnection;

            // Set the Format type and the CustomFormat string.
            BirthdayDatepicker.Format = DateTimePickerFormat.Custom;
            BirthdayDatepicker.CustomFormat = "yyyy-MM-dd";

            // Add values to combobox
            ProfessionCombobox.Items.Add("Designer");
            ProfessionCombobox.Items.Add("Engineer");
            ProfessionCombobox.Items.Add("Testing");
            ProfessionCombobox.Items.Add("Operator");
            ProfessionCombobox.Items.Add("Administrator");

            LoadTable();
        }

        //Load the DataGridView and Populate it with the User Table Data
        void LoadTable()
        {
            string query = "SELECT id,firstname,lastname,gender,birthday,profession,email,username,password FROM user";
            MySqlConnection myConn = new MySqlConnection(_mySqlConnection);
            MySqlCommand insertCommand = new MySqlCommand(query, myConn);

            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = insertCommand;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();

                bSource.DataSource = dbdataset;
                UserTable.DataSource = bSource;
                sda.Update(dbdataset);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex);
            }
        }

        //When the DataGridView Cell is Clicked
        private void UserTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.UserTable.Rows[e.RowIndex];

                FirstNameTextbox.Text = row.Cells["firstname"].Value.ToString();
                LastNameTextbox.Text = row.Cells["lastname"].Value.ToString();
                _gender = row.Cells["gender"].Value.ToString();

                if (_gender == "Male")
                {
                    MaleRadio.Checked = true;
                }
                else if (_gender == "Female")
                {
                    FemaleRadio.Checked = true;
                }
                else if (_gender == "Others")
                {
                    OthersRadio.Checked = true;
                }

                BirthdayDatepicker.Text = row.Cells["birthday"].Value.ToString();
                ProfessionCombobox.Text = row.Cells["profession"].Value.ToString();
                EmailTextbox.Text = row.Cells["email"].Value.ToString();
                EmailAgainTexbox.Text = row.Cells["email"].Value.ToString();
                UsernameTextbox.Text = row.Cells["username"].Value.ToString();
                PasswordTextbox.Text = row.Cells["password"].Value.ToString();
                _userId = Int32.Parse(row.Cells["id"].Value.ToString());
                
            }
        }

        //Update the Values in the Record
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextbox.TextLength != 0 && _gender != "" && BirthdayDatepicker.Text != "" && UsernameTextbox.TextLength != 0 && PasswordTextbox.TextLength != 0 && EmailTextbox.TextLength != 0 && EmailTextbox.Text == EmailAgainTexbox.Text)
            {
                Logic dataLogic = new Logic();
                string query = "Update user set firstname='" +FirstNameTextbox.Text+ "',lastname='"+LastNameTextbox.Text+"', gender='"+_gender+"',birthday='"+BirthdayDatepicker.Text+"',profession='"+ProfessionCombobox.Text+"',email='"+EmailTextbox.Text+"',username='"+UsernameTextbox.Text+"', password='"+PasswordTextbox.Text+"' WHERE id='"+_userId+"'";
                    
                dataLogic.RunQuery(query);
                LoadTable();
            }
            else
            {
                MessageBox.Show("Please fill the required fields", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Delete the Record from the Table
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            Logic dataLogic = new Logic();
            dataLogic.DeleteRow(_userId);
            LoadTable();
        }
    }
}
