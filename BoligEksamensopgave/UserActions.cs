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
using System.IO;

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
            foreach (var item in UserController.GetAllCustomers())
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

                if (es.Count() == 0)
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
                if (numOfSold != 0)
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            {

                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderName = @"\DataFromDB\";

                if (!Directory.Exists(filePath + folderName))
                {
                    Directory.CreateDirectory(filePath + folderName);
                }

                string extension = ".txt";
                filePath += folderName + @"data" + extension;
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);

                }
                var fs = File.Create(filePath);
                fs.Close();
                StreamWriter file = new StreamWriter(filePath);
                try
                {
                    string sLine = "";

                    
                    for (int r = 0; r <= dataGridView1.Rows.Count - 1; r++)
                    {
                        
                        for (int c = 0; c <= dataGridView1.Columns.Count - 1; c++)
                        {

                            sLine = sLine + dataGridView1.Rows[r].Cells[c].Value;
                            if (c != dataGridView1.Columns.Count - 1)
                            {
                               

                                sLine = sLine + "\t|\t";
                            }
                        }
                        
                        file.WriteLine(sLine);
                        sLine = "";
                    }

                    file.Close();
                    MessageBox.Show("Export Complete.", "Program Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    file.Close();
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            History[,] houses = EstateController.ConvertListTo2DArray(EstateController.GetEstatedFromPeriod(dateTimePicker1.Value, dateTimePicker2.Value));

            List<History> histories = new List<History>();
            for(int i=0;i<houses.GetLength(0);i++)
            {
                for(int j=0; j<houses.GetLength(1);j++)
                {
                    if (houses[i,j]!=null)
                    {
                        if (houses[i,j].Paid>Int32.Parse(textBox1.Text))
                        {
                            histories.Add(houses[i, j]);
                        }
                    }
                }
            }

            dataGridView3.DataSource = histories;
        }
    }
}
