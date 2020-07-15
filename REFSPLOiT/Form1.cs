using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace REFSPLOiT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
        }

        string[] usernames = { "Casper" };
        string[] passwords = { "02932" };

        // osrp hash (by pedro)
        /*
        public static string GetSha256(string strData)
        {
            var message = Encoding.ASCII.GetBytes(strData);
            var hashString = new SHA256Managed();
            var hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (var x in hashValue)
                hex += string.Format("{0:x2}", x);
            return hex;
        }
        */

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox1.Text) && passwords.Contains(textBox2.Text))
            {
                MessageBox.Show("You are logged in! Welcome Casper");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();
            }
            else
            {
                MessageBox.Show("The username and/or password is incorrect");
            }
        }
    }
}
