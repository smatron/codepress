using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CodePress
{
    public class Logic {

        //MySQL Server Connection String
        public string MySqlConnection = "datasource=localhost;port=3306;database=codepress;username=root;password=";

        //Executes a SQL Statement
        public void RunQuery(string query)
        {
            MySqlConnection conn = new MySqlConnection(MySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();

            conn.Close();
        }

        //Authenticates user by checking the username and password record in the database
        public string Authenticate(string username, string password)
        {
            string result = "";
            string query = "SELECT * FROM user WHERE username='"+username+"' AND password='"+password+"'";
            MySqlConnection conn = new MySqlConnection(MySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            int count = 0;

            while (myReader.Read())
            {
                count = count + 1;
            }

            if (count == 1)
            {
                result = "True";
            }
            else if (count > 1)
            {
                result = "Duplicate";
            }
            else
            {
                result = "False";
            }

            conn.Close();

            return result;

        }

        //Validates the username and checks for exsistance & duplication
        public string Validate(string username)
        {
            string result = "";
            string query = "SELECT * FROM user WHERE username='" +username+"'";
            MySqlConnection conn = new MySqlConnection(MySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            int count = 0;

            while (myReader.Read())
            {
                count = count + 1;
            }

            if (count != 1)
            {
                result = "True";
            }
            else
            {
                result = "Duplicate";
            }

            conn.Close();

            return result;
        }

        //Create A User table with fields
        public void GenerateData()
        {
            try
            {
                string query = "CREATE TABLE IF NOT EXISTS user(id int not null auto_increment, " +
                               "firstname VARCHAR(50)," +
                               "lastname VARCHAR(50)," +
                               "gender VARCHAR(20)," +
                               "birthday DATE," +
                               "profession VARCHAR(50)," +
                               "email VARCHAR(60)," +
                               "username VARCHAR(50)," +
                               "password TEXT," +
                               "primary key(id))";
                MySqlConnection conn = new MySqlConnection(MySqlConnection);
                MySqlCommand command = new MySqlCommand(query, conn);
                conn.Open();

                MySqlDataReader myReader;
                myReader = command.ExecuteReader();
                conn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        //Delete a user record using id field
        public void DeleteRow(int id)
        {
            string query = "DELETE FROM user WHERE id ='"+id+"'";
            MySqlConnection conn = new MySqlConnection(MySqlConnection);
            MySqlCommand command = new MySqlCommand(query, conn);
            conn.Open();

            MySqlDataReader myReader;
            myReader = command.ExecuteReader();
            conn.Close();
        }
    }
}
