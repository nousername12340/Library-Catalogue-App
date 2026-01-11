using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Catalogue_App
{
    public partial class Form_ManageUsers : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dtuserlist = new DataTable();
        int selectedId = -1;
        public Form_ManageUsers()
        {
            InitializeComponent();
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
        private void GetDataFromSQL()
        {

            try
            {
                dtuserlist.Clear();


                conn.Open();

                connectionstring = "server=localhost;user=root;database=db_LibraryCatalogueApp;password=;";
                sqlquery = "SELECT id_users, username as 'Username' , passwords as 'Password', user_role as 'Role' FROM `Users` where status_del = 'F'";
                cmd = new MySqlCommand(sqlquery, conn);

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtuserlist);
                dgv_userlist.DataSource = dtuserlist;

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_MainMenu mainmenu = new Form_MainMenu();
            mainmenu.Show();
            this.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            dtuserlist.Clear();
            txtbox_username.ResetText();
            txtbox_pass.ResetText();
            comb_role.ResetText();
            GetDataFromSQL();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            GetDataFromSQL();

            this.dgv_userlist.Columns["id_users"].Visible = false;
            dgv_userlist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void dgv_userlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            DataGridViewRow row = dgv_userlist.Rows[e.RowIndex];
            object idValue = row.Cells["id_users"].Value;

            if (idValue == null || idValue == DBNull.Value || string.IsNullOrWhiteSpace(idValue.ToString()))
            {
                MessageBox.Show("This user does not have a valid ID. Cannot continue.");
                selectedId = 0;
                return;
            }
            selectedId = Convert.ToInt32(dgv_userlist.Rows[e.RowIndex].Cells["id_users"].Value);
            txtbox_username.Text = dgv_userlist.Rows[e.RowIndex].Cells["Username"].Value.ToString();
            txtbox_pass.Text = dgv_userlist.Rows[e.RowIndex].Cells["Password"].Value.ToString();
            comb_role.Text = dgv_userlist.Rows[e.RowIndex].Cells["Role"].Value.ToString();

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "" || txtbox_pass.Text == "" ||
               comb_role.Text == "" )
            {
                MessageBox.Show("Please fill all boxes");
                return;
            }
            bool userexist = false;
            for (int i = 0; i < dtuserlist.Rows.Count; i++)
            {
                if (txtbox_username.Text == dtuserlist.Rows[i]["Username"].ToString())
                {
                    userexist = true;
                    break;
                }
            }
            if (userexist == true)
            {
                MessageBox.Show("Username already existed!");
                return;
            }
            try
            {
                conn.Open();

                sqlquery =
                    "INSERT INTO `Users` (username, passwords, user_role) VALUES ('" +
                    txtbox_username.Text + "', '" +
                    txtbox_pass.Text + "', '" +
                    comb_role.Text + "')";

                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("User added successfully!");
                dtuserlist.Clear();
                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a user to update!");
                    return;
                }

                if (txtbox_username.Text == "" || txtbox_pass.Text == "" || comb_role.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes!");
                    return;
                }

                conn.Open();

                string sqlquery = "update `Users` set " +
                                  "username = '" + txtbox_username.Text + "', " +
                                  "passwords = '" + txtbox_pass.Text + "', " +
                                  "user_role = '" + comb_role.Text + "' " +
                                  "where id_users = " + selectedId;

                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("User updated successfully!");

                dtuserlist.Clear();
                GetDataFromSQL();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedId == -1)
                {
                    MessageBox.Show("Please select a user to update!");
                    return;
                }

                if (txtbox_username.Text == "" || txtbox_pass.Text == "" || comb_role.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes!");
                    return;
                }

                conn.Open();

                string sqlquery = "update `Users` set " +
                                  "status_del = 'T'"+
                                  "WHERE id_users = " + selectedId;

                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("User deleted successfully!");

                dtuserlist.Clear();
                GetDataFromSQL();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool userexist = false;
            DataTable dtusersearched = dtuserlist.Clone();
            for (int i = 0; i < dtuserlist.Rows.Count; i++)
            {
                bool match = true;
                if (txtbox_username.Text != "" && txtbox_username.Text != dtuserlist.Rows[i]["Username"].ToString())
                {
                    match = false;
                }
                if (txtbox_pass.Text != "" && txtbox_pass.Text != dtuserlist.Rows[i]["Password"].ToString())
                {
                    match = false;
                }
                if (comb_role.Text != "" && comb_role.Text != dtuserlist.Rows[i]["Role"].ToString())
                {
                    match = false;
                }
                if (match)
                {
                    dtusersearched.ImportRow(dtuserlist.Rows[i]);
                    userexist = true;
                }
            }
            if (userexist == true)
            {
                dgv_userlist.DataSource = dtusersearched;
            }
            else
            {
                if (txtbox_username.Text != "")
                {
                    MessageBox.Show("Username doesn't exist or invalid");
                }
                else if (txtbox_pass.Text != "")
                {
                    MessageBox.Show("Password doesn't exist or invalid");
                }
                else if (comb_role.Text != "")
                {
                    MessageBox.Show("Role doesn't exist or invalid");
                }
                else
                {
                    MessageBox.Show("Please enter a value");
                }
            }
        }

        private void dgv_userlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
