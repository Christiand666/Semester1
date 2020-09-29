using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using Bolig.Actions;

namespace Bolig.GUI
{
    public partial class EstateViewer : Form
    {
        public EstateViewer(int? customerID, string adress, string type, int? agentID)
        {
            InitializeComponent();
            this.customerID = customerID;
            this.adress = adress;
            this.type = type;
            this.agentID = agentID;

            var Context = new Entities();
            this.current = Context.Estates.Where(X => X.Adress == adress).FirstOrDefault();
            if (this.current == null)
            {
                MessageBox.Show("Given Adress not found");
            }

            if(type == "purchase")
            {
                btnAction.Text = "Complete purchase";
            }else if (type == "view")
            {
                btnAction.Text = "Close";
            }
        }

        private int? customerID { get; }
        private string adress { get; }
        private int? agentID { get; }
        string type;

        Estate current;
        Bitmap imageBitmap = null;

        private void EstateViewer_Load(object sender, EventArgs e)
        {
            lblAdress.Text = adress;
            lblCity.Text = current.City;
            lblPostal.Text = current.Postal.ToString();
            lblSpace.Text = current.SpaceM2.ToString();

            pictureBox1.ImageLocation = current.Image;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            Boolean success = false;
            if (type == "purchase")
            {
                success = EstateController.SellEstate(adress, customerID ?? default(int), agentID ?? default(int));
                if(success)
                {
                    MessageBox.Show("Estate sold");
                }else
                {
                    MessageBox.Show("Something went wrong");
                }
            }else if (type == "view")
            {
                this.Close();
            }
        }

       
    }
}
