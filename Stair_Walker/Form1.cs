using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stair_Walker
{
    /*
     Programmer:Teddy T
     Program:Stair Walker
     Date:12/5/24
     */
    public partial class Form1 : Form
    {
        //set up or global variables
        int monsters = 0;
        int ghosts = 0;
        int steps = 0;
        //Declare an array pictureboxes
        PictureBox[] Stairs = new PictureBox[6];
        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        int CPPos = 0;
        //create a switch variable
        Boolean onOff = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Stairs[0] = stepPic0;
            Stairs[1] = stepPic1;
            Stairs[2] = stepPic2;
            Stairs[3] = stepPic3;
            Stairs[4] = stepPic4;
            Stairs[5] = stepPic5;
            CPPos = r.Next(0, 6);
            Stairs[CPPos].Image = imgpenR.Image;

            
        }
        private void moveCP()
        {
            int NCPPos;
            //randomly move penguin up or down 1 step
            Stairs[CPPos].Image = null;
            NCPPos = r.Next(-1, 2);
            CPPos += NCPPos;
            // check for index range
            if(CPPos < 0)
            {
                CPPos = 0;
            }
            if (CPPos > 5)
            {
                CPPos = 5;
            }
            // change direction
            if(NCPPos == -1)
            {
                Stairs[CPPos].Image = imgpenL.Image;
            }
            if (NCPPos == 1)
            {
                Stairs[CPPos].Image = imgpenR.Image;
            }
            if (NCPPos == 0)
            {
                Stairs[CPPos].Image = imgpenR.Image;
            }
            // makes doors open
            if (CPPos == 0)
            {
                imgMon.Visible = true;
                monsters++;
            } else
            {
                imgMon.Visible = false;
            }

            if (CPPos == 5)
            {
                imgGhost.Visible = true;
                ghosts++;
            }
            else
            {
                imgGhost.Visible = false;
            }
            // update labels
            steps++;
            lblMon.Text = monsters.ToString();
            lblGho.Text = ghosts.ToString();
            lblSteps.Text = steps.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            // activate function on tick
            moveCP();
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // ends the program
            this.Close();
        }

        private void imgGhost_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //turn timer on or off
            if (onOff == false)
            {
                timer1.Enabled = true;
                onOff = true;
            }
            else if (onOff == true)
            {
                timer1.Enabled = false;
                onOff = false;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // activate function on click
            moveCP();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            // activate function on tick
            moveCP();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // sets timer interval to trackbar value
            timer1.Interval = trackBar1.Value;
        }
    }
}
