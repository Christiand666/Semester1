using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bolig.Actions;
using DataAccess;

namespace Bolig.GUI
{
    public partial class UserActions : Form
    {
        public UserActions()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void UserActions_Load(object sender, EventArgs e)
        {
            foreach(var item in UserController.GetAllCustomers())
            {
                comboBox1.Items.Add(item.Name + " " + item.ID.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] selectedUserArray = comboBox1.Text.Split(' ');
            var Data = UserController.GetHistoryOfEstates(int.Parse(selectedUserArray[1]));
            dataGridView2.DataSource = Data;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtCitySearch.Text == "")
            {
                MessageBox.Show("No city was given");
                return;
            }
            if (txtSpaceSearch.Text == "")
            {
                MessageBox.Show("No space was given");
                return;
            }

            if (int.TryParse(txtSpaceSearch.Text, out int x))
            {
                List<Estate> es = EstateController.Search(txtCitySearch.Text, x);
                dataGridView1.DataSource = es;

                if(es.Count() == 0)
                {
                    MessageBox.Show("No estates with the given data were found");
                    return;
                }

                int totalPriceOfSold = 0;
                int totalPriceOfNotSold = 0;
                int numOfSold = 0;
                int numOfNotSold = 0;
                foreach (var item in es)
                {
                    if (item.isSold == true)
                    {
                        totalPriceOfSold = totalPriceOfSold + item.Price;
                        numOfSold++;
                    }
                    else
                    {
                        totalPriceOfNotSold = totalPriceOfNotSold + item.Price;
                        numOfNotSold++;
                    }
                }

                int avragePriceOfSold = 0;
                int avragePriceOfNotSold = 0;
                if (numOfNotSold != 0)
                {
                    avragePriceOfNotSold = totalPriceOfNotSold / numOfNotSold;
                }
                if(numOfSold != 0)
                {
                    avragePriceOfSold = totalPriceOfSold / numOfSold;
                }

                lblAvrPriceOfNotSold.Text = avragePriceOfNotSold.ToString();
                lblAvrPriceOfSold.Text = avragePriceOfSold.ToString();

            }
            else
            {
                MessageBox.Show("Please only use whole numbers for the space");
            }
        }
    }
}
