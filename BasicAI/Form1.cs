using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicAI
{
    //programmer: Teddy T
    //Date:2/2/25
    //program: AI Chase
    public partial class Form1 : Form
    {
        // setting vars
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        private int xSpeed = 15;
        private int ySpeed = 15;
        private int dir;
        private int score = 0;
        private decimal timer = 45;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        // this code runs every 0.1 secs
        private void moveTarget()
        {
            // updating labels 
            lblscore.Text = score.ToString();
            timer -= 0.1m;
            lblTime.Text = timer.ToString();
            //move target horz and verts

            if (Player.Location.X > enemy.Location.X)
            {
                enemy.Left += xSpeed;
                enemy.Image = picGreenL.Image;
            }
            if (Player.Location.Y > enemy.Location.Y)
            {
                enemy.Top += ySpeed;
                enemy.Image = picGreenF.Image;
            }
            if (Player.Location.Y < enemy.Location.Y)
            {
                enemy.Top -= ySpeed;
                enemy.Image = picGreenB.Image;
            }
            if (Player.Location.X < enemy.Location.X)
            {
                enemy.Left -= xSpeed;
                enemy.Image = picGreenR.Image;
            }
            if (Player.Location.X == enemy.Location.X)
            {
                enemy.Left -= xSpeed;
                enemy.Image = picGreenR.Image;
            }
            // for ending game
            if (progressBar1.Value == 1 || timer == 0)
            {
                timer1.Enabled = false;
                lblGO.Visible = true;
                Player.Visible = false;
                enemy.Visible = false;
                projectile.Enabled = false;
                
            }
            if (enemy.Location.X > Player.Location.X - 60 && enemy.Location.X < Player.Location.X + 60 && enemy.Location.Y > Player.Location.Y - 60 && enemy.Location.Y < Player.Location.Y + 60)
            {
                progressBar1.Value -= 1;
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveTarget();
        }
        // ignore Form1_KeyDown onl Form1_KeyDown_1 works
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //this capture which key is pressed
            Player.Text = e.KeyValue.ToString();
            int whichKey = e.KeyValue;
            //left Arrow
            if (whichKey == 37)
            {
                Player.Left -= 10;
            }
            // right
            else if (whichKey == 39)
            {
                Player.Left += 10;
            }
            // up
            if (whichKey == 38)
            {
                Player.Top -= 10;
                Player.Image = null;
            }
            //down
            else if (whichKey == 40)
            {
                Player.Top += 10;
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            //this capture which key is pressed
            Player.Text = e.KeyValue.ToString();
            int whichKey = e.KeyValue;
            //left Arrow
            if (whichKey == 37)
            {
                Player.Left -= 10;
                Player.Image = picBlueL.Image;
            }
            //Right Arrow
            else if (whichKey == 39)
            {
                Player.Left += 10;
                Player.Image = picBlueR.Image;
            }
            //Up Arrow
            if (whichKey == 38)
            {
                Player.Top -= 10;
                Player.Image = picBlueB.Image;
            }
            //Down Arrow
            else if (whichKey == 40)
            {
                Player.Top += 10;
                Player.Image = picBlueF.Image;
            }
            //fix OOB
            if (Player.Location.X < 0)
            {
                Player.Left += 10;
            }
            if (Player.Location.X > 650)
            {
                Player.Left -= 10;
            }
            if (Player.Location.Y < 0)
            {
                Player.Top += 10;
            }
            if (Player.Location.Y > 370)
            {
                Player.Top -= 10;
            }
            // shooting controls
            if (whichKey == 32)
            {
                projectile.Left = Player.Left +
                    Player.Width / 2;
                projectile.Top = Player.Top + 50;
                timer2.Enabled = true;
                if (Player.Image == picBlueL.Image) { dir = 1; }
                if (Player.Image == picBlueR.Image) { dir = 2; }
                if (Player.Image == picBlueB.Image) { dir = 3; }
                if (Player.Image == picBlueF.Image) { dir = 4; }
            }
            
            if (timer2.Enabled == false)
            {
                projectile.Left = Player.Left +
                    Player.Width / 2;
                projectile.Top = Player.Top + 50;
            }
        }
        //every 0.1 secs
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            moveTarget();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            moveProjectile();
        }
        // for shooting mecs
        private void moveProjectile()
        {
            // left
            if (dir == 1)
            {
                projectile.Left -= 30;
            }
            //right
            if (dir == 2)
            {
                projectile.Left += 30;
            }
            //up
            if (dir == 3)
            {
                projectile.Top -= 30;
            }
            //down
            if (dir == 4)
            {
                projectile.Top += 30;
            }
            //fix OOB
            if (projectile.Location.X < 0)
            {
                timer2.Enabled = false;
            }
            if (projectile.Location.X > 650)
            {
                timer2.Enabled = false;
            }
            if (projectile.Location.Y < 0)
            {
                timer2.Enabled = false;
            }
            if (projectile.Location.Y > 370)
            {
                timer2.Enabled = false;
            }
            // when it hits enemy
            if (projectile.Bounds.IntersectsWith(enemy.Bounds))
            {
                timer2.Enabled = false;
                int NewX = r.Next(0, 650);
                int NewY = r.Next(0, 370);
                score += 1;
                enemy.Left = NewX;
                enemy.Top = NewY;
            }
        }
    }
}
