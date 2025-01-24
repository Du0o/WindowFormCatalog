using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sub2d
{
    
    /*
     * og submit
     programmer: teddy t
     date: 1/9/25
     project: 2d subs
     */
    /*
     * message box fix sub
     programmer: teddy t
     date: 1/15/25
     project: 2d subs
     */
    public partial class Form1 : Form
    {
        // setting global vars
        bool onOff = false;
        bool ship1col = false;
        bool ship2col = false;
        PictureBox[,] Ocean = new PictureBox[5, 7];
        System.Random r = new System.Random((int)System.DateTime.Now.Ticks);
        int subPosX = 1;
        int subPosY = 1;
        int sub2PosX = 1;
        int sub2PosY = 1;
        int mineX = 1;
        int mineY = 1;
        int mine2X = 1;
        int mine2Y = 1;
        int sharkX = 1;
        int sharkY = 1;
        private int subCount = 0;
        private int sub2Count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   // setting up rows/cols and assining them to picBoxs
            Ocean[0, 0] = cord1;
            Ocean[0, 1] = cord2;
            Ocean[0, 2] = cord3;
            Ocean[0, 3] = cord4;
            Ocean[0, 4] = cord5;
            Ocean[0, 5] = cord6;
            Ocean[0, 6] = cord7;

            Ocean[1, 0] = card8;
            Ocean[1, 1] = cord9;
            Ocean[1, 2] = cord10;
            Ocean[1, 3] = cord11;
            Ocean[1, 4] = cord12;
            Ocean[1, 5] = cord13;
            Ocean[1, 6] = cord14;

            Ocean[2, 0] = cord15;
            Ocean[2, 1] = cord16;
            Ocean[2, 2] = cord17;
            Ocean[2, 3] = cord18;
            Ocean[2, 4] = cord19;
            Ocean[2, 5] = cord20;
            Ocean[2, 6] = cord21;

            Ocean[3, 0] = cord22;
            Ocean[3, 1] = cord23;
            Ocean[3, 2] = cord24;
            Ocean[3, 3] = cord25;
            Ocean[3, 4] = cord26;
            Ocean[3, 5] = cord27;
            Ocean[3, 6] = cord28;


            Ocean[4, 0] = cord29;
            Ocean[4, 1] = cord30;
            Ocean[4, 2] = cord31;
            Ocean[4, 3] = cord32;
            Ocean[4, 4] = cord33;
            Ocean[4, 5] = cord34;
            Ocean[4, 6] = cord35;
            // places down all components on enviroment
            subPosX = r.Next(0, 5);
            subPosY = r.Next(0, 7);

            sub2PosX = r.Next(0, 5);
            sub2PosY = r.Next(0, 7);

            mineX = r.Next(0, 5);
            mineY = r.Next(0, 7);

            mine2X = r.Next(0, 5);
            mine2Y = r.Next(0, 7);

            sharkX = r.Next(0, 5);
            sharkY = r.Next(0, 7);


            
            Ocean[mineX, mineY].BackgroundImage = mine.BackgroundImage;
            Ocean[mine2X, mine2Y].BackgroundImage = mine.BackgroundImage;
            Ocean[sharkX, sharkY].BackgroundImage = shark.BackgroundImage;

            Ocean[subPosX, subPosY].BackgroundImage = ship1.BackgroundImage;
            Ocean[sub2PosX, sub2PosY].BackgroundImage = ship2.BackgroundImage;

        }
        private void newTurn()

        {   // setting vars
            Ocean[subPosX, subPosY].BackgroundImage = null;
            int tmpX = subPosX;
            int tmpY = subPosY;
            ship1col = false;
            ship2col = false;
            //randomizing steps
            int addsubPosX = r.Next(-1,2);
            int addsubPosY = r.Next(-1,2);

            subPosX += addsubPosX;
            subPosY += addsubPosY;
            // check for out of bounds
            if (subPosX < 0)
            {
                subPosX = 0;
            }
            if (subPosX > 4)
            {
                subPosX = 4;
            }

            if (subPosY < 0)
            {
                subPosY = 0;
            }
            if (subPosY > 6)
            {
                subPosY = 6;
            }
            // check for obstacles
            if (Ocean[subPosX, subPosY].BackgroundImage != null)
            {
                subCount++;
                subPosX = tmpX;
                subPosY = tmpY;
                ship1col = true;
                
            }

            Ocean[sub2PosX, sub2PosY].BackgroundImage = null;
            int tmpX2 = sub2PosX;
            int tmpY2 = sub2PosY;

            int addsub2PosX = r.Next(-1, 2);
            int addsub2PosY = r.Next(-1, 2);

            sub2PosX += addsub2PosX;
            sub2PosY += addsub2PosY;

            // check for out of bounds
            if (sub2PosX < 0)
            {
                sub2PosX = 0;
            }
            if (sub2PosX > 4)
            {
                sub2PosX = 4;
            }

            if (sub2PosY < 0)
            {
                sub2PosY = 0;
            }
            if (sub2PosY > 6)
            {
                sub2PosY = 6;
            }
            // check for obstacles
            if (Ocean[sub2PosX, sub2PosY].BackgroundImage != null)
            {

                sub2Count++;
                sub2PosX = tmpX2;
                sub2PosY = tmpY2;
                ship2col = true;
            }
            if(addsubPosY == 1)
            {
                Ocean[subPosX, subPosY].BackgroundImage = ship1.BackgroundImage;
            }
            else if (addsubPosY == -1)
            {
                Ocean[subPosX, subPosY].BackgroundImage = ship1other.BackgroundImage;
            }
            else
            {
                Ocean[subPosX, subPosY].BackgroundImage = ship1other.BackgroundImage;
            }

            if (ship1col == true) {
                Ocean[subPosX, subPosY].BackgroundImage = picexplotion.BackgroundImage;
            }
            if (addsub2PosY == 1)
            {
                Ocean[sub2PosX, sub2PosY].BackgroundImage = ship1.BackgroundImage;
            }
            else if (addsub2PosY == -1)
            {
                Ocean[sub2PosX, sub2PosY].BackgroundImage = ship1other.BackgroundImage;
            }
            else
            {
                Ocean[subPosX, subPosY].BackgroundImage = ship1other.BackgroundImage;
            }
            if (ship2col == true)
            {
                Ocean[sub2PosX, sub2PosY].BackgroundImage = picexplotion.BackgroundImage;
            }

            // updating labels
            lblp1.Text = subCount.ToString();
            lblp2.Text = sub2Count.ToString();
            // check for winner
            if (subCount >= 25)
            {
                timer1.Enabled = false;
                lblwinner.Text = "WINNER: P2";
                
                reset();
            }   
            if (sub2Count >= 25)
            {
                timer1.Enabled = false;
                lblwinner.Text = "WINNER: P1";

                reset();
            }
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            // triggers new turn
            newTurn();

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            // closes the program
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            // resets enviroment components
            reset();
        }
        private void reset()
        {
            // clear old components
            clear();
            //set vars
            subCount = 0;
            sub2Count = 0;
            // update labels
            lblp1.Text = subCount.ToString();
            lblp2.Text = sub2Count.ToString();
            // replacing componets
            subPosX = r.Next(0, 5);
            subPosY = r.Next(0, 7);

            sub2PosX = r.Next(0, 5);
            sub2PosY = r.Next(0, 7);

            mineX = r.Next(0, 5);
            mineY = r.Next(0, 7);

            mine2X = r.Next(0, 5);
            mine2Y = r.Next(0, 7);

            sharkX = r.Next(0, 5);
            sharkY = r.Next(0, 7);



            Ocean[mineX, mineY].BackgroundImage = mine.BackgroundImage;
            Ocean[mine2X, mine2Y].BackgroundImage = mine.BackgroundImage;
            Ocean[sharkX, sharkY].BackgroundImage = shark.BackgroundImage;

            Ocean[subPosX, subPosY].BackgroundImage = ship1.BackgroundImage;
            Ocean[sub2PosX, sub2PosY].BackgroundImage = ship2.BackgroundImage;
        }
        private void clear()
        {
            // clears all picBoxs in enviroment
            for (int i = 0; i < 5; i++)
            {
                for (int o = 0; o < 7; o++)
                {
                    Ocean[i, o].BackgroundImage = null;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // sets new turn every tick
            newTurn();
        }

        private void btn_auto_Click(object sender, EventArgs e)
        {
            // timer boolean logic
            
            if(onOff == false)
            {
                onOff = true;
            }
            else
            {
                onOff = false;
            }
            timer1.Enabled = onOff;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cord9_Click(object sender, EventArgs e)
        {

        }
    }
}
