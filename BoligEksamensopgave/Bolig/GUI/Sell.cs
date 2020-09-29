using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Bolig.Actions;

namespace Bolig.GUI
{
    public partial class Sell : Form
    {
        public Sell()
        {
            InitializeComponent();
        }

        private void IsSoldEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'realboligDataSet2.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter1.Fill(this.realboligDataSet2.Customers);
            // TODO: This line of code loads data into the 'realboligDataSet4.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.realboligDataSet4.Customers);

            List<Estate> estates = EstateController.GetNotSoldEstates();
            if(estates == null)
            {
                MessageBox.Show("");

            }
                
            foreach (var item in estates)
            {
                Adresses.Items.Add(item.Adress + " " + item.Postal.ToString() + " " + item.City);
            }

            List<Agent> agents = UserController.GetAgentDBAsList();

            foreach (Agent a in agents)
            {
                cBox_agents.Items.Add(a.Name);
            }

        }
        private Form1 f1;
        public Sell(Form1 f1)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.f1 = f1;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(dataGridView1);
            if (Row == null)
                return;

            var s = Row.Cells[0].Value;
            lbl_ID.Text = s.ToString();
           
        }

        private DataGridViewRow GetDataRow(DataGridView Data)
        {
            try
            {
                if (Data.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Please only choose one row");
                    return null;
                }
                int index = Data.SelectedRows[0].Index;

                var Row = Data.Rows[index];
                return Row;
            }
            catch
            {
                MessageBox.Show("Please select a whole row");
                return null;
            }
        }

        private void BuyNow_Click(object sender, EventArgs e)
        {
            if(lbl_ID.Text == string.Empty)
            {
                MessageBox.Show("ID not given");
                return;
            }
            if(Adresses.Text == string.Empty)
            {
                MessageBox.Show("Adress not given");
                return;
            }

            string[] ComboArray = Adresses.Text.Split(' ');
            Form f = new EstateViewer(int.Parse(lbl_ID.Text), ComboArray[0] + " " + ComboArray[1], "purchase", UserController.GetAgentByName(cBox_agents.Text).ID);
            f.ShowDialog();
        }
    }
}
