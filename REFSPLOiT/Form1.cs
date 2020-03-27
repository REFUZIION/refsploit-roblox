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

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        string[] usernames = { "REFUZiON" };
        string[] passwords = { "123456" };

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernames.Contains(textBox1.Text) && passwords.Contains(textBox2.Text))
            {
                MessageBox.Show("You are logged in! Welcome REFUZiON");
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
