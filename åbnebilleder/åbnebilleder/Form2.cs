using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace åbnebilleder
{
    public partial class Form2 : Form
    {
        int i = 0;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (i <= 6)
            {
                i++;
                switch (i)
                {
                    case 1:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._1;
                        break;
                    case 2:

                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._2;
                        break;

                    case 3:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._3;
                        break;

                    case 4:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._4;
                        break;

                    case 5:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._5;
                        break;

                    case 6:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._6;
                        break;
                }
            }
         

           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i > 0)
            {
                i--;
                switch (i)
                {
                    case 1:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._1;
                        break;
                    case 2:

                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._2;
                        break;

                    case 3:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._3;
                        break;

                    case 4:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._4;
                        break;

                    case 5:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._5;
                        break;

                    case 6:
                        pictureBox1.Visible = true;
                        pictureBox1.BackgroundImage = Properties.Resources._6;
                        break;
                }



                    
            }

        }

      

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Properties.Resources._0;
        }

      

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int d1 = dateTimePicker2.Value.Day;
            int M1 = dateTimePicker2.Value.Month;
            int y1 = dateTimePicker2.Value.Year;

            textBox1.Text = d1.ToString();
            textBox2.Text = M1.ToString();
            textBox3.Text = y1.ToString();


        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int d2 = dateTimePicker1.Value.Day;
            int m2 = dateTimePicker1.Value.Month;
            int y2 = dateTimePicker1.Value.Year;

            textBox4.Text = d2.ToString();
            textBox5.Text = m2.ToString();
            textBox6.Text = y2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lorte opgave");


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
