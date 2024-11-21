using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crabs_Game
{   
    /*Programmer:Teddy T
    Program:Crap Game
    Date:10/14/24*/
    public partial class Form1 : Form
    {
        System.Random r1 = new System.Random((int)System.DateTime.Now.Ticks);
        System.Random r2 = new System.Random((int)System.DateTime.Now.Ticks);

        private decimal timesRolled = 0;
        private decimal point = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnrules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("On your first turn if you roll a 7 or 11 you win intantly and the game ends " +
                "and if you roll a 2, 3, or 12 you lose and a new round starts." +
                " If you roll a 4, 5, 6, 8, 9, or 10 the point is set to the corresponding roll. " +
                "from now on you keep rolling until you get your point number and win or you roll a 7 which means you lose.", "RULES", MessageBoxButtons.OK);
        }

        private void btnroll_Click(object sender, EventArgs e)
        {
            int random1 = r1.Next(1, 7);
            int random2 = r2.Next(1, 7);

            int sumroll = random1 + random2;
            lblsum.Text = sumroll.ToString();

            if (random1 == 1)
            {
                picdice1.Image = imgdice1.Image;
                lbldice1.Text = random1.ToString();
            }
            if (random1 == 2)
            {
                picdice1.Image = imgdice2.Image;
                lbldice1.Text = random1.ToString();
            }
            if (random1 == 3)
            {
                picdice1.Image = imgdice3.Image;
                lbldice1.Text = random1.ToString();
            }
            if (random1 == 4)
            {
                picdice1.Image = imgdice4.Image;
                lbldice1.Text = random1.ToString();
            }
            if (random1 == 5)
            {
                picdice1.Image = imgdice5.Image;
                lbldice1.Text = random1.ToString();
            }
            if (random1 == 6)
            {
                picdice1.Image = imgdice6.Image;
                lbldice1.Text = random1.ToString();
            }

            if (random2 == 1)
            {
                picdice2.Image = imgdice1.Image;
                lbldice2.Text = random2.ToString();
            }
            if (random2 == 2)
            {
                picdice2.Image = imgdice2.Image;
                lbldice2.Text = random2.ToString();
            }
            if (random2 == 3)
            {
                picdice2.Image = imgdice3.Image;
                lbldice2.Text = random2.ToString();
            }
            if (random2 == 4)
            {
                picdice2.Image = imgdice4.Image;
                lbldice2.Text = random2.ToString();
            }
            if (random2 == 5)
            {
                picdice2.Image = imgdice5.Image;
                lbldice2.Text = random2.ToString();
            }
            if (random2 == 6)
            {
                picdice2.Image = imgdice6.Image;
                lbldice2.Text = random2.ToString();
            }
            /*------------------------------------------------------*/
            if (timesRolled == 0)
            {
                timesRolled++;
                lbltimesrolled.Text = timesRolled.ToString();
                if (sumroll == 7 || sumroll == 11)
                {
                    win();
                }
                else if (sumroll == 2 || sumroll == 3 || sumroll == 12)
                {
                    lose();
                }
                else
                {
                    point = sumroll;
                    lblpoint.Text = point.ToString();
                }
            }
            else
            {
                timesRolled++;
                lbltimesrolled.Text = timesRolled.ToString();
                if (sumroll == point)
                {
                    win();
                }
                else if (sumroll == 7)
                {
                    lose();
                }

            }
        }
        public void win()
        {
            MessageBox.Show("Winner", "RESULTS", MessageBoxButtons.OK);
            timesRolled = 0;
            point = 0;
            lbldice1.Text = "";
            lbldice2.Text = "";
            lblpoint.Text = "";
            lblsum.Text = "";
            lbltimesrolled.Text = "";
        }
        public void lose()
        {
            MessageBox.Show("Loser", "RESULTS", MessageBoxButtons.OK);
            timesRolled = 0;
            point = 0;
            lbldice1.Text = "";
            lbldice2.Text = "";
            lblpoint.Text = "";
            lblsum.Text = "";
            lbltimesrolled.Text = "";
        }
    }
}
