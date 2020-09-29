using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Procejt_cargame
{
    public partial class CarGame : Form
    {
        public CarGame()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveLine(gamespeed);
            enemy(gamespeed);
            gameover();
            condom(gamespeed);
            collectcondomm();
        }
        int collectcondom = 0;
        Random r = new Random();
        int x, y;
        void enemy(int speed)
        {
            if (Enemy2.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                Enemy2.Location = new Point(x, 0);

                
            }
            else { Enemy2.Top += speed; }


            if (enemy3.Top >= 500)
            {
                x = r.Next(0, 300);
                y = r.Next(0, 350);
                enemy3.Location = new Point(x, 0);


            }

            else { enemy3.Top += speed; }

            if (enemy4.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                enemy4.Location = new Point(x, 0);


            }

            else { enemy4.Top += speed; }

            if (enemy5.Top >= 500)
            {
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                enemy5.Location = new Point(x, 0);


            }

            else { enemy5.Top += speed; }

            if (enemy6.Top >= 500)
            {
                x = r.Next(0, 270);
                y = r.Next(0, 210);
                enemy6.Location = new Point(x, 0);


            }

            else { enemy6.Top += speed; }

            if (enemy7.Top >= 500)
            {
                x = r.Next(0, 77);
                y = r.Next(0, 28);
                enemy7.Location = new Point(x, 0);


            }

            else { enemy7.Top += speed; }


        }

        void condom(int speed)
        {
            if (condom1.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                condom1.Location = new Point(x, 0);


            }
            else { condom1.Top += speed; }


            if (condom2.Top >= 500)
            {
                x = r.Next(0, 300);
                y = r.Next(0, 350);
                condom2.Location = new Point(x, 0);


            }

            else { condom2.Top += speed; }

            if (condom3.Top >= 500)
            {
                x = r.Next(0, 200);
                y = r.Next(0, 400);
                condom3.Location = new Point(x, 0);


            }

            else { condom3.Top += speed; }

            if (condom4.Top >= 500)
            {
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom4.Location = new Point(x, 0);


            }

            else { condom4.Top += speed; }

            if (condom5.Top >= 500)
            {
                x = r.Next(0, 270);
                y = r.Next(0, 210);
                condom5.Location = new Point(x, 0);


            }
            else { condom5.Top += speed; }

        }




            void gameover()
        {
            if (martin.Bounds.IntersectsWith(Enemy2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (martin.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (martin.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (martin.Bounds.IntersectsWith(enemy5.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (martin.Bounds.IntersectsWith(enemy6.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
            if (martin.Bounds.IntersectsWith(enemy7.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
            }
        }

        void moveLine(int speed)
        {
            if(pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else { pictureBox1.Top += speed; }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else { pictureBox2.Top += speed; }

            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else { pictureBox3.Top += speed; }

            if (pictureBox4.Top >= 500)
            {
                pictureBox4.Top = 0;
            }
            else { pictureBox4.Top += speed; }

            

        }

        void collectcondomm()
        {
            if (martin.Bounds.IntersectsWith(condom1.Bounds))
            {
                collectcondom++;
                label1.Text = "condoms" + collectcondom.ToString();
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom1.Location = new Point(x, 0);
            }
            if (martin.Bounds.IntersectsWith(condom2.Bounds))
            {
                collectcondom++;
                label1.Text = "condoms" + collectcondom.ToString();
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom2.Location = new Point(x, 0);
            }
            if (martin.Bounds.IntersectsWith(condom3.Bounds))
            {
                collectcondom++;
                label1.Text = "condoms" + collectcondom.ToString();
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom3.Location = new Point(x, 0);
            }
            if (martin.Bounds.IntersectsWith(condom4.Bounds))
            {
                collectcondom++;
                label1.Text = "condoms" + collectcondom.ToString();
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom4.Location = new Point(x, 0);
            }
            if (martin.Bounds.IntersectsWith(condom5.Bounds))
            {
                collectcondom++;
                label1.Text = "condoms" + collectcondom.ToString();
                x = r.Next(0, 315);
                y = r.Next(0, 121);
                condom5.Location = new Point(x, 0);
            }
        }



        int gamespeed = 0;
        private void CarGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                if(martin.Left > 0 )
                martin.Left += -8;
            }
            if(e.KeyCode == Keys.Right)
            {
                if(martin.Right < 290)
                martin.Left += gamespeed;
            }
            if (e.KeyCode == Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                { gamespeed--; }
            }
        }
    }
}
