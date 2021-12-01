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
    public partial class Add_renter : Form
    {
        char[] t = { ' ' };
        public Add_renter()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            /*
            Who take the flat
            label + Text Box = Flat + flatText.
            label + Text Box = Owner + ownerText.
            label + Text Box = Mobile + mobileText.
            label + Text Box = Email + emailText.
            label + Text Box = FamNo + famNoText
            label + Text Box = Age + ageText
            label + Text Box = Work + workText
            label + Text Box = NID + nidText.
            Picture Box= pictureBox2
            MySQL code: CREATE TABLE `Renter` ( `Flat_no` varchar(15) NOT NULL, `Name` varchar(20) NOT NULL, `Mobile` varchar(11) NOT NULL, `Email` varchar(60) NOT NULL, `NID` varchar(15) NOT NULL, `No_Of_Fam_Mem` varchar(15) NOT NULL, `Occupation` varchar(15) NOT NULL, `Age` int(3) NOT NULL, PRIMARY KEY (`Flat_no`) )

            */
            /*
             Group box 1 (Family member info)
            MemNoName + memNoNameText + MemNoMobile + memNoMobileText + MemNoWork + memNoWorkText
            example: Mem1Name + mem1NameText + Mem1Mobile + mem1MobileText + Mem1Work + mem1WorkText
            */
            /*
             Group box 2 (other members)
            MemName + memNameText + MemMobile + memMobileText + MemAge + memAgeText
            SName + sNameText + SMobile + sMobileText + SAge + sAgeText
             */

            /*2nd sql
             CREATE TABLE `Renters_fam_mem` ( `Flat_no` varchar(15) NOT NULL, `M1Name` varchar(20), `M1Mobile` varchar(11), `M1Occupation` varchar(15), `M1Age` int(3), `M2Name` varchar(20), `M2Mobile` varchar(11), `M2Occupation` varchar(15), `M2Age` int(3), `M3Name` varchar(20), `M3Mobile` varchar(11), `M3Occupation` varchar(15), `M3Age` int(3), `M4Name` varchar(20), `M4Mobile` varchar(11), `M4Occupation` varchar(15), `M4Age` int(3), `M5Name` varchar(20), `M5Mobile` varchar(11), `M5Occupation` varchar(15), `M5Age` int(3), `SName` varchar(20), `SMobile` varchar(11), `SAge` int(3), `DName` varchar(20), `DMobile` varchar(11), `DAge` int(3), PRIMARY KEY (`Flat_no`) )
             */
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Main m1 = new Main();
            this.Hide();
            m1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "INSERT INTO abashon.renter(Flat_no,Name,Mobile,Email,No_Of_Fam_Mem,Age,Occupation,NID) Values(' " + flatText.Text.TrimStart(t) + "',' " +ownerText.Text + "','" + mobileText.Text + "',' " + emailText.Text + "',' " + famNoText.Text + "',' " + ageText.Text + "','" + workText.Text + "','" + nidText.Text + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Renters Info Saved Successfully!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection DBconnect = new MySqlConnection("datasource=localhost;port=3306;username=root;password=''");
            string InsertQuery = "INSERT INTO abashon.renters_fam_mem(Flat_no,M1Name,M1Occupation,M1Mobile,M1Age,M2Name,M2Occupation,M2Mobile,M2Age,M3Name,M3Occupation,M3Mobile,M3Age,M4Name,M4Occupation,M4Mobile,M4Age,M5Name,M5Occupation,M5Mobile,M5Age,SName,SMobile,SAge,DName,DMobile,DAge) Values(' " + flatText.Text + "',' " + mem1NameText.Text + "','" + mem1WorkText.Text + "',' " + mem1MobileText.Text + "',' " + mem1AgeText.Text + "',' " + mem2NameText.Text + "','" + mem2WorkText.Text + "','" + mem2MobileText.Text + "','" + mem2AgeText.Text + "',' " + mem3NameText.Text + "','" + mem3WorkTest.Text + "',' " + mem3MobileText.Text + "','" + mem3AgeText.Text + "',' " + mem4NameText.Text + "','" + mem4WorkText.Text + "',' " + mem4MobileText.Text + "','" + mem4AgeText.Text + "',' " + mem5NameText.Text + "','" + mem5WorkText.Text + "',' " + mem5MobileText.Text + "','" + mem5AgeText.Text + "',' " + sNameText.Text + "','" + sMobileText.Text + "',' " + sAgeText.Text + "','" + dNameText.Text + "',' " + dMobileText.Text + "','" + dAgeText.Text + "')";
            MySqlCommand command = new MySqlCommand(InsertQuery, DBconnect);
            MySqlDataReader mySqlData;
            DBconnect.Open();
            mySqlData = command.ExecuteReader();
            MessageBox.Show("Renters Info Saved Successfully!!!");
        }
    }
}
