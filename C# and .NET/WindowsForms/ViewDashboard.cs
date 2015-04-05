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
    public partial class ViewDashboard : Form
    {
        string _mySqlConnection;

        public ViewDashboard()
        {
            InitializeComponent();

            Logic dataLogic = new Logic();
            _mySqlConnection = dataLogic.MySqlConnection;

            UserList();
            LoadTable();
            LoadLineChart();
        }

        
        //Populate the Listbox with the Data taken From the User Table
        public void UserList()
        {
            string query = "SELECT * FROM user";
            MySqlConnection conn = new MySqlConnection(_mySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                string result = myReader.GetString("username");
                UserListbox.Items.Add(result); 
            }

            conn.Close();
        }

        //Load the DataGridView and Populate it with the User Table Data
        void LoadTable()
        {
            string query = "SELECT id,firstname,lastname,gender,birthday,profession,email,username,password FROM user";
            MySqlConnection conn = new MySqlConnection(_mySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);


            MySqlDataAdapter sda = new MySqlDataAdapter();
            sda.SelectCommand = command;
            DataTable dbdataset = new DataTable();
            sda.Fill(dbdataset);
            BindingSource bSource = new BindingSource();

            bSource.DataSource = dbdataset;
            UserTable.DataSource = bSource;
            sda.Update(dbdataset);

          }

        //Load the Charts
        public void LoadLineChart()
        {
            string query = "SELECT * FROM user";
            MySqlConnection conn = new MySqlConnection(_mySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;

            myReader = command.ExecuteReader();

            while (myReader.Read())
            {
                this.UserLineChart.Series["Series1"].Points.AddXY(myReader.GetString("firstname"), myReader.GetInt32("id"));
                this.UserPieChart.Series["Series1"].Points.AddXY(myReader.GetString("firstname"), myReader.GetInt32("id"));
            }
        }

        //View ViewUpdate Form
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ViewUpdate viewUpdate = new ViewUpdate();
            viewUpdate.Show();

            this.Hide();
        }


    }
}
