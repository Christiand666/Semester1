using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lommeregner
{
    public partial class Form1 : Form
    {
        double resultvalue = 0;
        string operationsperformed = "";
        bool isoperationsperformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttom_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0")||(isoperationsperformed))
                textBox_result.Clear();
            isoperationsperformed = false;
            Button button = (Button)sender;
            if (button.Text==".")
            {
                if(textBox_result.Text.Contains("."))
                textBox_result.Text = textBox_result.Text + button.Text;
                textBox_result.Text = textBox_result.Text + button.Text;
            } 
            else
            textBox_result.Text = textBox_result.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                button18.PerformClick();
                operationsperformed = button.Text;

                Labelcurretoperation.Text = resultvalue + "" + operationsperformed;
                isoperationsperformed = true;
            }
            else
            {
                operationsperformed = button.Text;
                resultvalue = double.Parse(textBox_result.Text);
                Labelcurretoperation.Text = resultvalue + "" + operationsperformed;
                isoperationsperformed = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultvalue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operationsperformed)
            {
                case "+":
                    textBox_result.Text = (resultvalue + double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resultvalue - double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    textBox_result.Text = (resultvalue * double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    textBox_result.Text = (resultvalue / double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultvalue = double.Parse(textBox_result.Text);
            Labelcurretoperation.Text = "";
        }
    }
}
