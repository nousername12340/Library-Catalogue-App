using System;                      //used to make datatypes
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;              //used to make database
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;     //used to make winform
using MySql.Data.MySqlClient; //used to connect SQL


namespace Library_Catalogue_App
{
    public partial class Form_Login : Form
    {
        MySqlConnection conn;       //An object that represents a connection to a MySQL database. (open and close)
        MySqlCommand cmd;           //An object that represents a SQL command. (select, insert, update, delete)
        MySqlDataAdapter adapter;   //A bridge between the database and in-memory data (DataTable or DataSet).
        MySqlDataReader reader;     //Reading rows one at a time
        string connectionstring;
        string sqlquery;
        string connection;
        public Form_Login()
        {
            InitializeComponent(); //creates and sets up the UI
            try
            {
                connection = "server=localhost;user=root;database=db_LibraryCatalogueApp;password=;";
                conn = new MySqlConnection(connection);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_show_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Form_MainMenu formmainmenu = new Form_MainMenu();   //call form_mainmenu

            adapter = new MySqlDataAdapter(cmd);
            DataTable dtusers = new DataTable();

            dtusers.Clear();
            conn.Open();

            connectionstring = "server=localhost;user=root;database=db_LibraryCatalogueApp;password=;";
            sqlquery = "SELECT username, passwords, user_role FROM `Users`";
            cmd = new MySqlCommand(sqlquery, conn);

            adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dtusers);

            bool loginsuccess = false;
            bool isStaff = false;

            for (int i = 0; i < dtusers.Rows.Count; i++)
            {
                if (txtbox_username.Text == dtusers.Rows[i]["username"].ToString() &&
                    txtbox_pass.Text == dtusers.Rows[i]["passwords"].ToString())
                {
                    loginsuccess = true;

                    if (dtusers.Rows[i]["user_role"].ToString() == "Staff")
                    {
                        isStaff = true;
                    }

                    break;
                }
            }

            if (loginsuccess == true)
            {
                UserCheck.loginhistory.Add(txtbox_username.Text);
                formmainmenu.Show();
                this.Hide();

                if (isStaff == true)
                {
                    UserCheck.IsStaff = true;
                    formmainmenu.setButtonVisible(true);
                }
                else
                {
                    UserCheck.IsStaff = false;
                    formmainmenu.setButtonVisible(false);
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password!");
            }

            conn.Close();
        }
    }
}
