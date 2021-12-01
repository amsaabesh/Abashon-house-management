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

namespace Abashon_house
{
    public partial class Delete : Form
    {
        MySqlConnection connection = new MySqlConnection("Server = 127.0.0.1; port=3306; database=abashon; username=root; password=;");
        MySqlCommand command;
        MySqlDataAdapter adapter;
        MySqlDataReader mdr;
        public Delete()
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
            /*MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "delete from abashon.renter where Flat_no='" + this.textBox1.Text + "';";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Renters Info Delete Successfully!!!");*/
            string connectionString = "datasource=localhost; port=3306; username=root; password=''";
            string Query = "delete from abashon.renter where Flat_no='" + this.textBox1.Text + "';";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(Query, databaseConnection);
            MySqlDataReader myReader;
            try
            {
                

                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Done...");
                while (myReader.Read())
                {
                }
                //databaseConnection.Close();
               // ShowCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost; port=3306; username=root; password=''";
            string Query = "delete from abashon.renters_fam_mem where Flat_no='" + this.textBox1.Text + "';";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(Query, databaseConnection);
            MySqlDataReader myReader;
            try
            {


                databaseConnection.Open();
                myReader = commandDatabase.ExecuteReader();
                MessageBox.Show("Done...");
                while (myReader.Read())
                {
                }
                //databaseConnection.Close();
                // ShowCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
