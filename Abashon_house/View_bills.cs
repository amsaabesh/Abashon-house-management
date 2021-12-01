using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Abashon_house
{
    public partial class View_bills : Form
    {
        public View_bills()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private DataTable renterList()
        {
            DataTable rent = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(conString))
            {
                using (MySqlCommand cmd = new MySqlCommand("Select * From bill", con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    rent.Load(reader);
                }
            }

            return rent;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_bills_Load(object sender, EventArgs e)
        {
            billViewer.DataSource = renterList();
        }
    }
}
