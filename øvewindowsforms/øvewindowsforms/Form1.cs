using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace øvewindowsforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            anumber.Value++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            anumber.Value = 100;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("det virker sku");
            }
        }

        private void aurl_TextChanged(object sender, EventArgs e)
        {
            try
            {
                aweb.Url = new Uri(aurl.Text);
            }
            catch { }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void anumber_ValueChanged(object sender, EventArgs e)
        {
            progressBar1.Minimum = (int) anumber.Minimum;
            progressBar1.Maximum = (int)anumber.Maximum;
            progressBar1.Value = (int)anumber.Value;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                panel1.BackColor = colorDialog1.Color;
            }
        }
    }
}
