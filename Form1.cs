using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Up && guard1.Top > 0)
            {
                guard1.Top -= 10;
            }
            else if (keyData == Keys.Down && guard1.Top < 300)
            {
                guard1.Top += 10;
            }
            
            return base.ProcessCmdKey(ref msg, keyData);
        }*/

        private int x = 1, y = 0, z = 0, score1 = 0, score2 = 0;
        private bool right = true, left = false, up = false, down = true,down1 = false,up1 = false,down2 = false, up2 = false;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            time.Text = x.ToString();
            time2.Text = y.ToString();
            time3.Text = z.ToString();
            if(z == 0)
            {
                if(x == 0 && y == 0)
                {
                    timer2.Enabled = false;
                    timer1.Enabled = false;
                    if (score2 > score1)
                    {
                        sc2.ForeColor = Color.Green;
                        sc1.ForeColor = Color.Red;
                    }else if (score1 > score2)
                    {
                        sc1.ForeColor = Color.Green;
                        sc2.ForeColor = Color.Red;
                    }else if(score1 == score2){
                        sc1.ForeColor = Color.Green;
                        sc2.ForeColor = Color.Green;
                    }
                    time.Text = "0";
                    time2.Text = "0";
                    time3.Text = "0";
                    
                }
                z = 9;
                if(y == 0)
                {
                    y = 5;
                    x--;
                }
                else
                {
                    y--;
                }
            }
            else
            {
                z--;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up1 = false;
            }else if(e.KeyCode == Keys.Down)
            {
                down1 = false;
            }else if(e.KeyCode == Keys.W)
            {
                up2 = false;
            }else if(e.KeyCode == Keys.S)
            {
                down2 = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                up1 = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                down1 = true;
            }
            else if (e.KeyCode == Keys.W)
            {
                up2 = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                down2 = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(up1 == true)
            {
                guard1.Top-=2;
            }
            if(up2 == true)
            {
                guard2.Top -= 2;
            }
            if(down1 == true)
            {
                guard1.Top += 2;
            }
            if(down2 == true)
            {
                guard2.Top += 2;
            }

            
            if(ball.Top < 5)
            {
                up = false;
                down = true;
            }
            if(ball.Top > 350)
            {
                up = true;
                down = false;
            }
            
            if((ball.Left + 20 == guard1.Left && ball.Top +20 > guard1.Top&&ball.Top<guard1.Top + 78)||(ball.Left < guard2.Left + 20 && ball.Top + 20 > guard2.Top && ball.Top < guard2.Top + 78))
            {
                if(right == true)
                {
                    right = false;
                    left = true;
                }else if(left == true)
                {
                    left = false;
                    right = true;
                }
            }
            if (ball.Left + 20 > 620)
            {
                score2++;
                right = true;
                down = true;
                left = false;
                up = false;
                ball.Left = 290;
                ball.Top = 150;
            }
            if(ball.Left < -20)
            {
                score1++;
                right = true;
                down = true;
                left = false;
                up = false;
                ball.Left = 290;
                ball.Top = 150;
            }

            if(left == true && down == true)
            {
                ball.Top += 3;
                ball.Left -= 3;
            }
            if(left == true && up == true)
            {
                ball.Top -= 3;
                ball.Left -= 3;
            }
            if(right == true&&down == true)
            {
                ball.Top += 3;
                ball.Left += 3;
            }
            if(right == true && up == true)
            {
                ball.Top -= 3;
                ball.Left += 3;
            }
            sc1.Text = score1.ToString();
            sc2.Text = score2.ToString();
        }
    }
}
