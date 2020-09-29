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
    public partial class ManageDB : Form
    {
        public ManageDB()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Customers")
            {
                Customer c = new Customer();
                c.Email = txtEmail.Text;
                c.Name = txtName.Text;
                c.Phone = txtPhone.Text;

                Boolean success = UserController.CreateCustomer(c);
                if (!success)
                    MessageBox.Show("Phone or Email is already in use");
                else
                    MessageBox.Show("Customers Created");
            }else if (comboBox1.Text == "Agents")
            {
                Agent A = new Agent();
                A.Email = txtEmail.Text;
                A.Name = txtName.Text;
                A.Phone = txtPhone.Text;

                Boolean success = UserController.CreateAgent(A);
                if (!success)
                    MessageBox.Show("Phone or Email is already in use");
                else
                    MessageBox.Show("Agents Created");

            }else if (comboBox1.Text == "Sellers")
            {
                Seller s = new Seller();

                
                s.Email = txtEmail.Text;
                s.Name = txtName.Text;
                s.Phone = txtPhone.Text;

                Boolean success = UserController.CreateSeller(s);
                if (!success)
                    MessageBox.Show("Phone or Email is already in use");
                else
                    MessageBox.Show("Seller Created");

            }

            UpdateData();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            UpdateData();

            txtNameUpdate.Text = "";
            txtPhoneUpdate.Text = "";
            txtEmailUpdate.Text = "";
            lblID.Text = "";
        }

        private void Update_click_Click(object sender, EventArgs e)
        {
            if(lblID.Text == "")
            {
                MessageBox.Show("Please update data from the data view");
                return;
            }
            int ID = Convert.ToInt32(lblID.Text);
            if (comboBox1.Text == "Sellers")

            {
                Seller m = new Seller();

                m.Email = txtEmailUpdate.Text;
                m.Name = txtNameUpdate.Text;
                m.Phone = txtPhoneUpdate.Text;

                Boolean success = UserController.UpdateSeller(ID, m);
                if (!success)
                {
                    MessageBox.Show("Phone or Email is already in use");
                }
                else
                {
                    MessageBox.Show("Seller updated");
                }

            }
                if (comboBox1.Text == "Customer")

                {
                    Customer m = new Customer();

                    m.Email = txtEmailUpdate.Text;
                    m.Name = txtNameUpdate.Text;
                    m.Phone = txtPhoneUpdate.Text;

                    Boolean success = UserController.UpdateCustomer(ID, m);
                    if (!success)
                    {
                        MessageBox.Show("Phone or Email is already in use");
                    }
                    else
                    {
                        MessageBox.Show("Customer updated");
                    }

                }

                if (comboBox1.Text == "Agents")

               {
                Agent n = new Agent();

                n.Email = txtEmailUpdate.Text;
                n.Name = txtNameUpdate.Text;
                n.Phone = txtPhoneUpdate.Text;

                Boolean success = UserController.UpdateAgent(ID, n);
                if (!success)
                {
                    MessageBox.Show("Phone or Email is already in use");
                }
                else
                {
                    MessageBox.Show("Agent is updated");
                }
            }
            UpdateData();
        }


        private void Table_Main_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ManageDB_Load(object sender, EventArgs e)
        {
            //Set the default text of the combobox//
            comboBox1.Text = "Agents";
            UpdateData();
        }
        private void UpdateData()
        {
            switch (comboBox1.Text)
            {
                case "Agents":
                    table_Main.DataSource = UserController.GetAgentDBAsList();
                    break;
                case "Sellers":
                    table_Main.DataSource = UserController.GetSellerDBAsList();
                    break;
                case "Customers":
                    table_Main.DataSource = UserController.GetCostumerDBAsList();
                    break;
            }
            

        }

      

       

        
        private void Delete_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(table_Main);
            if (Row == null)
                return;

            int ID = int.Parse(Row.Cells[0].Value.ToString());
            Boolean success = false;
            if (comboBox1.Text == "Sellers")
                success = UserController.DeleteSeller(ID);
            else if (comboBox1.Text == "Agents")
                success = UserController.DeleteAgent(ID);
            else if (comboBox1.Text == "Customers")
                success = UserController.DeleteCustomer(ID);

            if (!success)
                MessageBox.Show("An error has occured");
            else
                MessageBox.Show("Data deleted");

            UpdateData();
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

        private void button1_Click(object sender, EventArgs e)
        {
            var Row = GetDataRow(table_Main);
            if (Row == null)
                return;

            lblID.Text = Row.Cells[0].Value.ToString();
            txtNameUpdate.Text = Row.Cells[1].Value.ToString();
            txtPhoneUpdate.Text = Row.Cells[2].Value.ToString();
            txtEmailUpdate.Text = Row.Cells[3].Value.ToString();
        }
    }
}

