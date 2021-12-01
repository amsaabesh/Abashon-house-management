using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Abashon_house
{
    public partial class Main : Form
    {
        int x = 255, y = 80;//var for label possition
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)//timer for moving text of label1 (আবাসনে আপনাকে...)
        {
            label2.SetBounds(x, y, 1, 1);
            x+=2;//increment x's value for moving text 
            if (x > 800) {
                x = -282;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)//exit button
        {
            Application.Exit();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//download the renter information form
        {
            Process.Start("https://drive.google.com/file/d/1t-Z0fajqY8u_0fWP6RdaPQkMKqN4MTb_/view?usp=sharing");
        }

        private void pictureBox2_Click(object sender, EventArgs e)//home page button
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//going to the bill making page
        {
            Bill_make bm = new Bill_make();
            this.Hide();
            bm.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_renter ar = new Add_renter();
            this.Hide();
            ar.Show();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete d = new Delete();
            this.Hide();
            d.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login_Signup ls = new Login_Signup();
            this.Hide();
            ls.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Delete_bill dbi = new Delete_bill();
            this.Hide();
            dbi.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bill_view bv = new Bill_view();
            this.Hide();
            bv.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            View_bills vb = new View_bills();
            this.Hide();
            vb.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)//developer's fb profile
        {
            Process.Start("https://www.facebook.com/shoaib.aabesh");
        }
    }
}
