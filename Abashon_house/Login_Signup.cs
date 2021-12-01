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
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace Abashon_house
{
    public partial class Login_Signup : Form
    {
        int i=6;
        string un, pas;
        char[] tc = { ' ' };
        public Login_Signup()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox5.PasswordChar = '*';
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            un = ' ' + textBox1.Text;
            pas = textBox2.Text;
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pas));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            String password1 = strBuilder.ToString();

            MySqlConnection DBconnect1 = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            DBconnect1.Open();
            MySqlCommand command1 = new MySqlCommand("select * from abashon.registration where User_Name='" + un + "' and Password= '" + password1 + "';", DBconnect1);
            MySqlDataReader myreader1;
            myreader1 = command1.ExecuteReader();
            int counter = 0;
            while (myreader1.Read())
            {
                counter = counter + 1;
            }

            if (counter == 1 && i != 1)
            {
                i = 3;
                Main m = new Main();
                this.Hide();
                m.Show();
            }
            else if (counter > 1 && i != 1)
            {
                MessageBox.Show("Duplicate");
            }
            else if (i != 1)
            {
                i -= 1;
                MessageBox.Show("Wrong Password\nYou have "+i+" Chance(s)");
            }
            else
            {
                MessageBox.Show("Too many Failed Attempt. So you were kicked out.");
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MD5 md5 = new MD5CryptoServiceProvider();

            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(textBox5.Text));
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                strBuilder.Append(result[i].ToString("x2"));
            }
            String password2 = strBuilder.ToString();

            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "INSERT INTO abashon.registration(NID,Name,Email,Phone,Password,User_Name) Values(' " + textBox6.Text + "',' " + textBox3.Text + "','" + textBox7.Text + "',' " + textBox8.Text + "',' " + password2 + "',' " + textBox4.Text + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Account Created.");
            /*String fromAddress = "shoaibaabesh@gmail.com";
            String toAddress = textBox7.Text;
            String password = "A@besh.1";
            MailMessage mail = new MailMessage();
            mail.Subject = "Abashon";
            mail.From = new MailAddress(fromAddress);
            mail.Body = "আবাসন ব্যাবহারের জন্য আপনাকে ধন্যবাদ। ঘরে থাকুন নিরাপদ থাকুন।";
            mail.To.Add(new MailAddress(toAddress));

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            NetworkCredential nec = new NetworkCredential(fromAddress, password);
            smtp.Credentials = nec;
            smtp.Send(mail);
            MessageBox.Show("Account created. A confirmation mail is send on your email.");*/
        }

        /*private void button3_Click(object sender, EventArgs e)//image add
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Choose Image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(opf.FileName);
            }
        }*/

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '\0')
            {
                pictureBox5.BringToFront();
                textBox2.PasswordChar = '*';
            }

            
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                pictureBox2.BringToFront();
                textBox2.PasswordChar = '\0';
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (textBox5.PasswordChar == '\0')
            {
                pictureBox7.BringToFront();
                textBox5.PasswordChar = '*';
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (textBox5.PasswordChar == '*')
            {
                pictureBox6.BringToFront();
                textBox5.PasswordChar = '\0';
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
