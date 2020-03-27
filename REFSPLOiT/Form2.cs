using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;

namespace REFSPLOiT
{
    public partial class Form2 : Form
    {
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        readonly ExploitAPI api = new ExploitAPI();

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string script = fastColoredTextBox1.Text;
            api.SendLuaScript(script);
        }

        private void InjectBtn_Click(object sender, EventArgs e)
        {
            api.LaunchExploit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fastColoredTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void MainWindow_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
