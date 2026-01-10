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
    public partial class Form_ManageCatalogue : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dtbooklist = new DataTable();
        int selectedid = -1;

        public Form_ManageCatalogue()
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
                adapter = new MySqlDataAdapter(cmd);


                conn.Open();

                connectionstring = "server=localhost;user=root;database=db_LibraryCatalogueApp;password=;";
                sqlquery = "select id_books, booktitle as 'Title' , bookauthors as 'Author', bookyear as 'Year', book_qty as 'Quantity' FROM `Books` where status_del = 'F'";
                cmd = new MySqlCommand(sqlquery, conn);

                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtbooklist);
                dgv_booklist.DataSource = dtbooklist;

                conn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void Form4_Load(object sender, EventArgs e)
        {
            GetDataFromSQL();

            this.dgv_booklist.Columns["id_books"].Visible = false;
            dgv_booklist.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_MainMenu mainmenu = new Form_MainMenu();
            mainmenu.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_title.Text == "" || txtbox_author.Text == "" ||
                txtbox_year.Text == "" || txtbox_qty.Text == "")
            {
                MessageBox.Show("Please fill all textboxes");
                return;
            }
            bool bookexist = false;
            for (int i = 0; i < dtbooklist.Rows.Count; i++)
            {
                if (txtbox_title.Text == dtbooklist.Rows[i]["Title"].ToString() &&
                    txtbox_author.Text == dtbooklist.Rows[i]["Author"].ToString())
                {
                    bookexist = true;
                    break;
                }
            }
            if (bookexist == true)
            {
                MessageBox.Show("Book already existed!");
                return;
            }
            try
            {
                conn.Open();

                sqlquery =
                    "insert into `Books` (booktitle, bookauthors, bookyear, book_qty) values ('" +
                    txtbox_title.Text + "', '" +
                    txtbox_author.Text + "', '" +
                    txtbox_year.Text + "', '" +
                    txtbox_qty.Text + "')";

                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Book added successfully!");
                dtbooklist.Clear();
                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtbooklist.Clear();
            txtbox_title.ResetText();
            txtbox_author.ResetText();
            txtbox_year.ResetText();
            txtbox_qty.ResetText();
            GetDataFromSQL();
        }

        private void dgv_booklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedid = Convert.ToInt32(dgv_booklist.Rows[e.RowIndex].Cells["id_books"].Value);
                txtbox_title.Text = dgv_booklist.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtbox_author.Text = dgv_booklist.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                txtbox_year.Text = dgv_booklist.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                txtbox_qty.Text = dgv_booklist.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                    if (selectedid == -1)
                    {
                        MessageBox.Show("Please select a user to update!");
                        return;
                    }

                    if (txtbox_title.Text == "" || txtbox_author.Text == "" || txtbox_year.Text == "" || txtbox_qty.Text == "")
                    {
                        MessageBox.Show("Please fill all textboxes!");
                        return;
                    }


                    conn.Open();

                string sqlquery = "update `Books` set " +
                                  "booktitle = '" + txtbox_title.Text + "', " +
                                  "bookauthors = '" + txtbox_author.Text + "', " +
                                  "bookyear = '" + txtbox_year.Text + "', " +
                                  "book_qty = '" + txtbox_qty.Text + "' " +
                                  "where id_books = " + selectedid;

                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Book updated successfully!");

                dtbooklist.Clear();
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
                if (selectedid == -1)
                {
                    MessageBox.Show("Please select a user to update!");
                    return;
                }

                if (txtbox_title.Text == "" || txtbox_author.Text == "" || txtbox_year.Text == "" || txtbox_qty.Text == "")
                {
                    MessageBox.Show("Please fill all textboxes!");
                    return;
                }

                conn.Open();
                string sqlquery = "update `Books` SET status_del = 'T' where id_books = " + selectedid;
                cmd = new MySqlCommand(sqlquery, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show("Book deleted successfully!");

                dtbooklist.Clear();
                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            bool bookexist = false;
            DataTable dtbooksearched = dtbooklist.Clone();
            for (int i = 0; i < dtbooklist.Rows.Count; i++)
            {
                bool match = true;
                if (txtbox_title.Text != "" && txtbox_title.Text != dtbooklist.Rows[i]["Title"].ToString())
                {
                    match = false;
                }
                if (txtbox_author.Text != "" && txtbox_author.Text != dtbooklist.Rows[i]["Author"].ToString())
                {
                    match = false;
                }
                if (txtbox_year.Text != "" && txtbox_year.Text != dtbooklist.Rows[i]["Year"].ToString())
                {
                    match = false;
                }
                if (txtbox_qty.Text != "" && txtbox_qty.Text != dtbooklist.Rows[i]["Quantity"].ToString())
                {
                    match = false;
                }
                if (match)
                {
                    dtbooksearched.ImportRow(dtbooklist.Rows[i]);
                    bookexist = true;
                }
            }
            if (bookexist == true)
            {
                dgv_booklist.DataSource = dtbooksearched;
            }
            else
            {
                if (txtbox_title.Text != "")
                {
                    MessageBox.Show("Book doesn't exist or invalid");
                }
                else if (txtbox_author.Text != "")
                {
                    MessageBox.Show("Author doesn't exist or invalid");
                }
                else if (txtbox_year.Text != "")
                {
                    MessageBox.Show("Book Year doesn't exist or invalid");
                }
                else if (txtbox_qty.Text != "" || txtbox_qty.Text == "0")
                {
                    MessageBox.Show("Book Quantity is too many or invalid");
                }
                else
                {
                    MessageBox.Show("Please enter a value");
                }
            }
        }

        private void dgv_booklist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtbox_year_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtbox_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
