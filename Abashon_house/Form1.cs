using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abashon_house
{
    public partial class Form1 : Form
    {
        int ng;//variable for random number;
        Random r = new Random();// random number generate
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void timer1_Tick(object sender, EventArgs e)//timer for show loading percentage
        {
            ng = r.Next(0, 5);//set random number in ng

            panel2.Width += ng;//use random number for show loading percentage randomly
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                Login_Signup l1 = new Login_Signup();
                this.Hide();
                l1.Show();
            }
        }
    }
}
