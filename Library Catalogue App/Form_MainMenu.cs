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
    public partial class Form_MainMenu : Form
    {
        public Form_MainMenu()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (UserCheck.IsStaff == true)
            {
                setButtonVisible(true);
            }
            else
            {
                setButtonVisible(false);
            }
        }
        public void setButtonVisible(Boolean cek)
        {
            this.btn_managecata.Visible = cek;
            this.btn_manageusers.Visible = cek;
            this.btn_manageloans.Visible = cek;
        }

        private void btn_libcata_Click(object sender, EventArgs e)
        {
            Form_LibraryCatalogue librarycatalogue = new Form_LibraryCatalogue();
            librarycatalogue.Show();
            this.Close();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Form_Login loginpage = new Form_Login();
            loginpage.Show();
            this.Close();
        }

        private void btn_managecata_Click(object sender, EventArgs e)
        {
            Form_ManageCatalogue managecatalogue = new Form_ManageCatalogue();
            managecatalogue.Show();
            this.Close();
        }

        private void btn_manageusers_Click(object sender, EventArgs e)
        {
            Form_ManageUsers manageusers = new Form_ManageUsers();
            manageusers.Show();
            this.Close();
        }

        private void btn_manageloans_Click(object sender, EventArgs e)
        {
            Form_ManageLoan manageloans = new Form_ManageLoan();
            manageloans.Show();
            this.Close();
        }
    }
}
