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
    public partial class Form_LibraryCatalogue : Form
    {
        MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        string connectionstring;
        string sqlquery;
        string connection;
        DataTable dtbooklist = new DataTable();
        public Form_LibraryCatalogue()
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
                sqlquery = "select id_books, booktitle as 'Title' , bookauthors as 'Author', bookyear as 'Year' from `Books` where status_del = 'F'";
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
        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_MainMenu mainmenu = new Form_MainMenu();
            mainmenu.Show();
            this.Close();
        }
        
        private void Form3_Load(object sender, EventArgs e)
        {
            GetDataFromSQL();

            this.dgv_booklist.Columns["id_books"].Visible = false;
            dgv_booklist.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
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
                else
                {
                    MessageBox.Show("Please enter a value");
                }
            }
        }

        private void dgv_booklist_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtbox_title.Text = dgv_booklist.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtbox_author.Text = dgv_booklist.Rows[e.RowIndex].Cells["Author"].Value.ToString();
                txtbox_year.Text = dgv_booklist.Rows[e.RowIndex].Cells["Year"].Value.ToString();
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dtbooklist.Clear();
            txtbox_title.ResetText();
            txtbox_author.ResetText();
            txtbox_year.ResetText();
            GetDataFromSQL();
        }
    }
}
