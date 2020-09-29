using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("them");
        }
        private void button1_ClickAlternative(object sender, EventArgs e)
        {
            //textBox1.Text = "Hej: " + DateTime.Now;

            MessageBox.Show(textBox1.Text + " will now be saved. ");

            listBox1.Items.Add("Hej: " + DateTime.Now);
        }

        private void Kundenavn_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form2()).Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            (new Form2()).Show();
        }
    }
}
