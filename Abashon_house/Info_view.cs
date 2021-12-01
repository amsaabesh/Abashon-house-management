using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Abashon_house
{
    public partial class Bill_view : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=abashon; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;
        public Bill_view()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Bill_view_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = renterList();
        }
        private DataTable renterList()
        {
            DataTable rent = new DataTable();

            string conString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using(MySqlConnection con= new MySqlConnection(conString))
            {
                using(MySqlCommand cmd=new MySqlCommand("Select * From renter", con))
                {
                    con.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    rent.Load(reader);
                }
            }

            return rent;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
