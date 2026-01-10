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
    public partial class Form_ManageLoan : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dtloanlist = new DataTable();
        public Form_ManageLoan()
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
                dtloanlist.Clear();
                conn.Open();

                string sql = "SELECT d.id_users, d.id_books, b.booktitle AS 'Book Title', u.username AS 'Username', " +
                            "d.loandate AS 'Date Borrowed', d.duedate AS 'Due Date', d.returndate AS 'Return Date' " +
                            "FROM `details` d " +
                            "INNER JOIN `Users` u ON d.id_users = u.id_users " +
                            "INNER JOIN `Books` b ON d.id_books = b.id_books " +
                            "WHERE d.status_del = 'F' AND u.status_del = 'F' AND b.status_del = 'F'";
                cmd = new MySqlCommand(sql, conn);
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dtloanlist);

                dgv_loanlist.DataSource = dtloanlist;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
        private void lbl_booktitle_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_MainMenu mainmenu = new Form_MainMenu();
            mainmenu.Show();
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            GetDataFromSQL();

            dtp_return.ShowCheckBox = true;         
            dtp_return.Checked = false;
            if (dgv_loanlist.Columns["id_users"] != null)
                dgv_loanlist.Columns["id_users"].Visible = false;

            if (dgv_loanlist.Columns["id_books"] != null)
                dgv_loanlist.Columns["id_books"].Visible = false;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "")
            {
                MessageBox.Show("Please enter the borrowing member's username!");
                return;
            }

            if (txtbox_title.Text == "")
            {
                MessageBox.Show("Please enter the book title!");
                return;
            }

            try
            {
                conn.Open();

                string sqlUser = "SELECT id_users FROM Users WHERE username = '" + txtbox_username.Text + "' AND status_del = 'F'";
                cmd = new MySqlCommand(sqlUser, conn);
                object userResult = cmd.ExecuteScalar();

                if (userResult == null)
                {
                    MessageBox.Show("User not found!");
                    conn.Close();
                    return;
                }
                int userId = Convert.ToInt32(userResult);

                string sqlBook = "SELECT id_books FROM Books WHERE booktitle = '" + txtbox_title.Text + "' AND status_del = 'F'";
                cmd = new MySqlCommand(sqlBook, conn);
                object bookResult = cmd.ExecuteScalar();

                if (bookResult == null)
                {
                    MessageBox.Show("Book not found!");
                    conn.Close();
                    return;
                }
                int bookId = Convert.ToInt32(bookResult);

                string sqlCheck = "SELECT * FROM details WHERE id_users = " + userId + " AND id_books = " + bookId + " AND returndate IS NULL AND status_del = 'F'";
                cmd = new MySqlCommand(sqlCheck, conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("This book is already borrowed by this user and not returned yet!");
                    reader.Close();
                    conn.Close();
                    return;
                }
                reader.Close();

                DateTime loanDate = dtp_borrow.Value;
                DateTime dueDate = loanDate.AddDays(7);
                string sqlInsert;

                if (dtp_return.Checked)
                {
                    DateTime returnDate = dtp_return.Value;
                    sqlInsert = "INSERT INTO details (id_users, id_books, loandate, duedate, returndate) " +
                                "VALUES (" + userId + ", " + bookId + ", '" +
                                loanDate.ToString("yyyy-MM-dd") + "', '" +
                                dueDate.ToString("yyyy-MM-dd") + "', '" +
                                returnDate.ToString("yyyy-MM-dd") + "')";
                }
                else 
                {
                    sqlInsert = "INSERT INTO details (id_users, id_books, loandate, duedate, returndate) " +
                                "VALUES (" + userId + ", " + bookId + ", '" +
                                loanDate.ToString("yyyy-MM-dd") + "', '" +
                                dueDate.ToString("yyyy-MM-dd") + "', NULL)";
                }


                cmd = new MySqlCommand(sqlInsert, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Loan recorded successfully! Due date: " + dueDate.ToShortDateString());
                conn.Close();
                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void dtp_return_ValueChanged(object sender, EventArgs e)
        {
            dtp_return.CustomFormat = "dd MMMM yyy";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "")
            {
                MessageBox.Show("Please enter the borrowing member's username!");
                return;
            }

            if (txtbox_title.Text == "")
            {
                MessageBox.Show("Please enter the book title!");
                return;
            }


            try
            {
                conn.Open();
                int userId = Convert.ToInt32(dgv_loanlist.CurrentRow.Cells["id_users"].Value);
                int bookId = Convert.ToInt32(dgv_loanlist.CurrentRow.Cells["id_books"].Value);

                DateTime loanDate = dtp_borrow.Value;
                DateTime dueDate = loanDate.AddDays(7);

                string sqlUpdate;

                if (dtp_return.Checked) 
                {
                    DateTime returnDate = dtp_return.Value;
                    sqlUpdate = "UPDATE details SET " +
                                "loandate = '" + loanDate.ToString("yyyy-MM-dd") + "', " +
                                "duedate = '" + dueDate.ToString("yyyy-MM-dd") + "', " +
                                "returndate = '" + returnDate.ToString("yyyy-MM-dd") + "' " +
                                "WHERE id_users = " + userId + " AND id_books = " + bookId;
                }
                else 
                {
                    sqlUpdate = "UPDATE details SET " +
                                "loandate = '" + loanDate.ToString("yyyy-MM-dd") + "', " +
                                "duedate = '" + dueDate.ToString("yyyy-MM-dd") + "', " +
                                "returndate = NULL " +
                                "WHERE id_users = " + userId + " AND id_books = " + bookId;
                }

                cmd = new MySqlCommand(sqlUpdate, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Loan record updated successfully!");
                conn.Close();

                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (txtbox_username.Text == "" || txtbox_title.Text == "")
            {
                MessageBox.Show("Please enter both username and book title to delete a loan!");
                return;
            }

            try
            {
                conn.Open();

                string sqlUser = "SELECT id_users FROM Users WHERE username = '" + txtbox_username.Text + "' AND status_del = 'F'";
                cmd = new MySqlCommand(sqlUser, conn);
                object userResult = cmd.ExecuteScalar();

                if (userResult == null)
                {
                    MessageBox.Show("User not found!");
                    conn.Close();
                    return;
                }
                int userId = Convert.ToInt32(userResult);

                string sqlBook = "SELECT id_books FROM Books WHERE booktitle = '" + txtbox_title.Text + "' AND status_del = 'F'";
                cmd = new MySqlCommand(sqlBook, conn);
                object bookResult = cmd.ExecuteScalar();

                if (bookResult == null)
                {
                    MessageBox.Show("Book not found!");
                    conn.Close();
                    return;
                }
                int bookId = Convert.ToInt32(bookResult);
                string sqlDelete = "UPDATE details SET status_del = 'T' " +
                                   "WHERE id_users = " + userId + " AND id_books = " + bookId;

                cmd = new MySqlCommand(sqlDelete, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Loan record deleted successfully!");
                conn.Close();

                GetDataFromSQL();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtloanlist.Clear();
            txtbox_username.ResetText();
            txtbox_title.ResetText();
            dtp_borrow.Value = DateTime.Now;
            dtp_return.Checked = false;
            GetDataFromSQL();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DataTable dtloansearched = dtloanlist.Clone();
            bool found = false;

            for (int i = 0; i < dtloanlist.Rows.Count; i++)
            {
                bool match = true;

                if (txtbox_username.Text != "" && txtbox_username.Text != dtloanlist.Rows[i]["Username"].ToString())
                {
                    match = false;
                }

                if (txtbox_title.Text != "" && txtbox_title.Text != dtloanlist.Rows[i]["Book Title"].ToString())
                {
                    match = false;
                }

                if (dtp_borrow.Checked)
                {
                    object borrowObj = dtloanlist.Rows[i]["Date Borrowed"];
                    if (borrowObj == DBNull.Value || dtp_borrow.Value.ToString("yyyy-MM-dd") != Convert.ToDateTime(borrowObj).ToString("yyyy-MM-dd"))
                        match = false;
                }

                if (dtp_return.Checked)
                {
                    object returnObj = dtloanlist.Rows[i]["Return Date"];
                    if (returnObj == DBNull.Value || dtp_return.Value.ToString("yyyy-MM-dd") != Convert.ToDateTime(returnObj).ToString("yyyy-MM-dd"))
                        match = false;
                }

                if (match)
                {
                    dtloansearched.ImportRow(dtloanlist.Rows[i]);
                    found = true;
                }
            }

            if (found)
            {
                dgv_loanlist.DataSource = dtloansearched;
            }
            else
            {
                if (txtbox_title.Text != "")
                    MessageBox.Show("Book doesn't exist or invalid");
                else if (txtbox_username.Text != "")
                    MessageBox.Show("Username doesn't exist or invalid");
                else if (dtp_borrow.Checked)
                    MessageBox.Show("Date Borrowed is invalid");
                else if (dtp_return.Checked)
                    MessageBox.Show("Return Date is invalid");
                else
                    MessageBox.Show("Please enter a value to search");
            }
        }

        private void dgv_loanlist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtbox_username.Text = dgv_loanlist.Rows[e.RowIndex].Cells["Username"].Value.ToString();
                txtbox_title.Text = dgv_loanlist.Rows[e.RowIndex].Cells["Book Title"].Value.ToString();
                object borrowValue = dgv_loanlist.Rows[e.RowIndex].Cells["Date Borrowed"].Value;
                dtp_borrow.Value = Convert.ToDateTime(borrowValue);
                object returnValue = dgv_loanlist.Rows[e.RowIndex].Cells["Return Date"].Value;
                if (returnValue != DBNull.Value)
                {
                    dtp_return.Value = Convert.ToDateTime(returnValue);
                    dtp_return.Checked = true;
                }
                else
                {
                    dtp_return.Checked = false; 
                }
            }
        }
    }
}
