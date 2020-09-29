using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolig.GUI;
using Bolig.Actions;

namespace Bolig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form f2 = new ManageDB();
            f2.TopLevel = false;
            f2.AutoScroll = true;
            pnlContent.Controls.Add(f2);
            f2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form EstateForm = new EstateEditor(this);
            EstateForm.TopLevel = false;
            EstateForm.AutoScroll = false;
            pnlContent.Controls.Add(EstateForm);
            EstateForm.Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form IsSoldForm = new Sell(this);
            IsSoldForm.TopLevel = false;
            IsSoldForm.AutoScroll = false;
            pnlContent.Controls.Add(IsSoldForm);
            IsSoldForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Cleaner.CleanDB();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            Form u = new UserActions();
            u.TopLevel = false;
            u.AutoScroll = false;
            pnlContent.Controls.Add(u);
            u.Show();
        }
    }
}
