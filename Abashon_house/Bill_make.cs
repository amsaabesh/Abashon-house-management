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
    public partial class Bill_make : Form
    {
        /*  
            ct = care taker
            wat = water
            ser = servant
        */
        double gas, elect, other, ct, ser, cle, wat, n_grd, yard, total, flat=6.0;   //var declear for set value from text box and database

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "INSERT INTO abashon.bill(date,house_no,flat,electricity,water,other,gas,night_guard,yard,cleaner,servant,caretaker,total) Values(' " + dateText.Text + "',' " + add + "',' " + flat + "','" + textBox1.Text + "',' " + textBox2.Text + "',' " + textBox3.Text + "',' " + textBox4.Text + "',' " + textBox5.Text + "',' " + textBox6.Text + "',' " + textBox7.Text + "',' " + textBox8.Text + "',' " + textBox9.Text + "',' " + total + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Bill Saved in Database ");
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtb.Text, new Font("Times New Roman", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

       
        string add = "172/2 North Shyamoli, Dhaka-1207";//add=address
        public Bill_make()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)  //icon button
        {

            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)  //exti button
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)  //calculate button
        {
            gas = Convert.ToDouble(textBox4.Text);
            wat = Convert.ToDouble(textBox2.Text);
            elect = Convert.ToDouble(textBox1.Text);
            other = Convert.ToDouble(textBox3.Text);
            n_grd = Convert.ToDouble(textBox5.Text);
            yard = Convert.ToDouble(textBox6.Text);
            cle = Convert.ToDouble(textBox7.Text);
            ser = Convert.ToDouble(textBox8.Text);
            ct = Convert.ToDouble(textBox9.Text);
            total = (gas + wat + elect + other + n_grd + yard + cle + ser + ct)/flat;
            total += 100;
            
            //rtb=richtextbox1
            rtb.Clear();
            //Start Adding All info
            rtb.Text +="\n\n\t" +add + "\n\n";
            rtb.Text +="\tName:____________________________\n";
            rtb.Text +="\tDate:" +DateTime.Now+ "\n\n";
            rtb.Text += "\tBill\n";
            rtb.Text += "\tGas:            "+gas + "\n";
            rtb.Text += "\tElectricity:    " + elect + "\n";
            rtb.Text += "\tWater:          " + wat + "\n";
            rtb.Text += "\tYard+Roof+Road: " + yard + "\n";
            rtb.Text += "\tNight Guard:    " + n_grd + "\n";
            rtb.Text += "\tClean:          " + cle + "\n";
            rtb.Text += "\tServant:        " + ser + "\n";
            rtb.Text += "\tCare Taker:     " + ct + "\n";
            rtb.Text += "\tOthers:         " + gas + "\n";
            rtb.Text += "\t____________________________\n";
            rtb.Text += "\tTotal:          " + total + "\n";
        }
        
    }
}
