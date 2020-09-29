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
using System.IO;

namespace Bolig.GUI
{
    public partial class EstateEditor : Form
    {

        private Form1 f1;
        private List<Seller> sellers;
        private List<Agent> agents;
        public EstateEditor(Form1 f1)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.f1 = f1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Estate est = new Estate();
            est.Adress = txtAdressCreate.Text;
            est.City = txtCityCreate.Text;
            est.Postal = int.Parse(txtPostalCreate.Text);
            est.SpaceM2 = int.Parse(txtSpaceCreate.Text);
            est.Price = int.Parse(txtPriceCreate.Text);
            est.Image = txtImageCreate.Text;

            Boolean success = EstateController.CreateEstate(GetSellerID(comboBox1.Text),GetAgentID(comboBox2.Text), est);
            if (!success)
                MessageBox.Show("An error has occured");
            else
                MessageBox.Show("Changes created");
           
            UpdateData();
        }

        private void EstateEditor_Load(object sender, EventArgs e)
        {
            UpdateData();

            sellers = UserController.GetSellerDBAsList();
            
            foreach (Seller s in sellers)
            {
                comboBox1.Items.Add(s.Name);
            }

            agents = UserController.GetAgentDBAsList();

            foreach(Agent a in agents)
            {
                comboBox2.Items.Add(a.Name);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            var Row = GetDataRow(table_Estate);
            if (Row == null)
                return;
            var s = Row.Cells[0].Value;
            //label8.Text = s.ToString();
        }

        private void button4_Click(object sender, EventArgs ev)
        {
            try
            {
                Estate e = new Estate();
                e.Adress = txtAdressUpdate.Text;
                e.Postal = int.Parse(txtPostalUpdate.Text);
                e.City = txtCityUpdate.Text;
                e.Image = txtImageUpdate.Text;
                e.SpaceM2 = int.Parse(txtSpaceUpdate.Text);
                e.Price = int.Parse(txtPriceUpdate.Text);
                e.isSold = checkIsSold.Checked;

                EstateController.UpdateEstate(int.Parse(lblIDUpdate.Text), e);
                UpdateData();
            }catch
            {
                MessageBox.Show("Either a DB connection failure or an input value wasn't a whole number");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(table_Estate);
            if(Row == null)
                return;
            txtAdressUpdate.Text = Row.Cells[1].Value.ToString();
            txtPostalUpdate.Text = Row.Cells[2].Value.ToString();
            txtCityUpdate.Text = Row.Cells[3].Value.ToString();
            txtSpaceUpdate.Text = Row.Cells[4].Value.ToString();
            if(Row.Cells[5].Value.ToString() == "False")
            {
                checkIsSold.Checked = false;
            }
            else
            {
                checkIsSold.Checked = true;
            }
            txtPriceUpdate.Text = Row.Cells[6].Value.ToString();
            txtImageUpdate.Text = Row.Cells[7].Value.ToString();
            lblIDUpdate.Text = Row.Cells[0].Value.ToString();
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


        private void button5_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(table_Estate);
            Boolean success = EstateController.DeleteEstate(int.Parse(Row.Cells[0].Value.ToString()));
            if (!success)
                MessageBox.Show("Delete failed");
            else
                UpdateData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                int price = EstateController.GetPrice(txtCityGetPrice.Text, int.Parse(txtSpaceGetPrice.Text));
                
                lblPrice.Text = price.ToString();
            }catch
            {
                MessageBox.Show("Numeric values wasn't numeric, or no simular estates found");
            }
        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_Estate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void UpdateData()
        {
            table_Estate.DataSource = EstateController.GetEstatesAsList();
        }
        private int GetSellerID(string name)
        {
            int ID = -1;
            foreach (Seller s in sellers)
            {
                if (s.Name == name)
                {
                    ID = s.ID;
                }
            }
            return ID;
        }
        private int GetAgentID(string name)
        {
            int ID = -1;
            foreach (Agent a in agents)
            {
                ID = a.ID;
            }
            return ID;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           
            {
                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string folderName = @"\DataFromDB\";

                if(!Directory.Exists(filePath + folderName))
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


                    for (int r = 0; r <= table_Estate.Rows.Count - 1; r++)
                    {

                        for (int c = 0; c <= table_Estate.Columns.Count - 1; c++)
                        {

                            sLine = sLine + table_Estate.Rows[r].Cells[c].Value;
                            if (c != table_Estate.Columns.Count - 1)
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

        private void button7_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(table_Estate);
            if (Row == null)
                return;

            Form f = new EstateViewer(null, Row.Cells[1].Value.ToString(), "view", null);
            f.ShowDialog();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
