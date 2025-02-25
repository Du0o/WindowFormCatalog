using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fisher
{

    public partial class Form1 : Form
    {
        // startup varablies
        private int score = 0;
        private int fishCount = 20;
        private bool hooking = false;
        private int dir = 1;
        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        PictureBox[] DaSea = new PictureBox[20];
        PictureBox[] bubbles = new PictureBox[4];
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //when the program starts
        private void Form1_Load(object sender, EventArgs e)
        {
            // debuging
            Console.WriteLine(Hook.Top);
            Console.WriteLine(Chain1.Top);
            Console.WriteLine(Chain2.Top);

            // setting arrays for fish
            DaSea[0] = Fish0;
            DaSea[1] = Fish1;
            DaSea[2] = Fish2;
            DaSea[3] = Fish3;
            DaSea[4] = Fish4;
            DaSea[5] = Fish5;
            DaSea[6] = Fish6;
            DaSea[7] = Fish7;
            DaSea[8] = Fish8;
            DaSea[9] = Fish9;
            DaSea[10] = Fish10;
            DaSea[11] = Fish11;
            DaSea[12] = Fish12;
            DaSea[13] = Fish13;
            DaSea[14] = Fish14;
            DaSea[15] = Fish15;
            DaSea[16] = Fish16;
            DaSea[17] = Fish17;
            DaSea[18] = Fish18;
            DaSea[19] = Fish19;

            // setting arrays for bubbles
            bubbles[0] = bubble0;
            bubbles[1] = bubble1;
            bubbles[2] = bubble2;
            bubbles[3] = bubble3;
            // setting pos for fish
            for (int n = 0; n < DaSea.Length; n++)
            {
                int randomx = r.Next(0, this.Width);
                int randomy = r.Next(label1.Top, this.Height);
                DaSea[n].Left = randomx;
                DaSea[n].Top = randomy;
            }
        }
        // update timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            // bubble code
            for (int u = 0; u < bubbles.Length; u++)
            {
                bubbles[u].Top -= 15;
                if (bubbles[u].Top <= label1.Top)
                {
                    int randomxbub = r.Next(0, this.Width);
                    int randomybub = r.Next(label1.Top, label2.Top);
                    bubbles[u].Left = randomxbub;
                    bubbles[u].Top = randomybub;
                }
            }



            //boat movement
            if (dir == 0)
            {
                boat.Left -= 9;
                boat.Image = imgboatL.Image;
            }
            else
            {
                boat.Left += 9;
                boat.Image = imgboatR.Image;
            }

            if (boat.Left < 0)
            {
                dir = 1;
            }
            if (boat.Left > this.Width - 150)
            { 
                dir = 0;
            }
            Hook.Left = boat.Left;
            Chain1.Left = boat.Left;
            Chain2.Left = boat.Left;
            // hook func
            if (hooking)
            {
                Hook.Top += 9;
                Chain1.Top += 9;
                Chain2.Top += 9;
            }
            else
            {
                Hook.Top = 106;
                Chain1.Top = -64;
                Chain2.Top = 24;
            }

            if(Hook.Top >= 286)
            {
                hooking = false;
            }

            // fish movement
            int randomx = r.Next(0, 2);
            int randomy = r.Next(0, 2);
            for (int i = 0; i < DaSea.Length; i++)
            {
                randomx = r.Next(0, 2);
                randomy = r.Next(0, 2);
                if (DaSea[i].Image != imgFishDead.Image)
                {

                    if (randomx == 1)
                    {

                        DaSea[i].Image = imgFishAliveR.Image;
                        DaSea[i].Left += 9;

                    }
                    else
                    {

                        DaSea[i].Image = imgFishAliveL.Image;
                        DaSea[i].Left -= 9;

                    }

                    if (randomy == 1)
                    {
                        DaSea[i].Top += 9;
                    }
                    else
                    {
                        DaSea[i].Top -= 9;
                    }
                    // fix OOB
                    if (DaSea[i].Top < label1.Top)
                    {
                        DaSea[i].Top = label1.Top;
                    }
                    if (DaSea[i].Top > label2.Top)
                    {
                        DaSea[i].Top = label2.Top;
                    }

                    if (DaSea[i].Left < 0)
                    {
                        DaSea[i].Left = 0;
                    }
                    if (DaSea[i].Left > this.Width - 150)
                    {
                        DaSea[i].Left = this.Width - 150;
                    }
                    // collision func
                    if (DaSea[i].Bounds.IntersectsWith(Hook.Bounds))
                    {
                        if (hooking)
                        {
                            DaSea[i].Visible = false;
                            DaSea[i].Image = imgFishDead.Image;
                            fishCount -= 1;
                            score++;
                            lblscore.Text = score.ToString();
                        }
                    }
                    if (DaSea[i].Bounds.IntersectsWith(Shark.Bounds))
                    {
                        DaSea[i].Top = label2.Top;
                        DaSea[i].Image = imgFishDead.Image;
                        fishCount -= 1;
                    }
                }
            }
            
            // shark movement
            if (randomx == 1)
            {

                Shark.Image = imgSharkR.Image;
                Shark.Left += 9;

            }
            else
            {

                Shark.Image = imgSharkL.Image;
                Shark.Left -= 9;

            }

            if (randomy == 1)
            {
                Shark.Top += 9;
            }
            else
            {
                Shark.Top -= 9;
            }
            // fix OOB
            if (Shark.Top < label1.Top)
            {
                Shark.Top = label1.Top;
            }
            if (Shark.Top > label2.Top)
            {
                Shark.Top = label1.Top;
            }

            if (Shark.Left < 0)
            {
                Shark.Left = 0;
            }
            if (Shark.Left > this.Width - 150)
            {
                Shark.Left = this.Width - 150;
            }
            // message box func
            if(fishCount <= 0)
            {
                timer1.Enabled = false;
                DialogResult resultAnswer = DialogResult;
                string messageString = null;
                string msg = null;
                messageString = "Game Over ";
                msg = score.ToString();
                resultAnswer = MessageBox.Show("Your Score is " + msg + "\n Would You Like To Play Again?",
                messageString,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (resultAnswer == DialogResult.Yes)
                {
                    timer1.Enabled = true;
                    score = 0;
                    
                    lblscore.Text = "0";

                    for (int n = 0; n < DaSea.Length; n++)
                    {
                        randomx = r.Next(0, this.Width);
                        randomy = r.Next(label1.Top, this.Height);
                        DaSea[n].Left = randomx;
                        DaSea[n].Top = randomy;
                        DaSea[n].Image = imgFishAliveL.Image;
                        fishCount += 1;
                    }
                    

                }
                if (resultAnswer == DialogResult.No)
                {
                    this.Close();
                }
            }
            
        }

        private void Fish9_Click(object sender, EventArgs e)
        {

        }

        private void Hook_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }
        // keyboard controlls
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int whichKey = e.KeyValue;
            if (whichKey == 32)
            {
                if (hooking)
                {
                    hooking = false;
                }
                else
                {
                    hooking = true;
                }
            }
        }
    }
}
