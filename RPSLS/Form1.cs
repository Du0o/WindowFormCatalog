using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSLS
{
    /*
     Programmer:Teddy T
     Program:RPSLS
     Date:10/20/24
     */
    public partial class Form1 : Form
    {
        //global vars
        private int p1wins = 0;
        private int p2wins = 0;

        private int p1choise = 0;
        private int p2choise = 0;
        public Form1()
        {
            InitializeComponent();
        }
        // closes program
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // for setting image when selecting
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            imgP1.Image = picrockL.Image;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            imgP1.Image = picpaperL.Image;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            imgP1.Image = picsissiorsL.Image;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            imgP1.Image = piclizardR.Image;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            imgP1.Image = picspockL.Image;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            imgP2.Image = picrockR.Image;

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            imgP2.Image = picpaperR.Image;

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            imgP2.Image = picsissoirR.Image;

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            imgP2.Image = piclizardL.Image;

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            imgP2.Image = picspockR.Image;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // reveals and desides which player wins match
        private void btnreveal_Click(object sender, EventArgs e)
        {
            // resets for next match
            btnreset_Click(sender, e);

            if (p1choise == p2choise)
            {
                MessageBox.Show("TIE", "TIE");

            }
            else if (p1choise == 1 && (p2choise == 3 || p2choise == 5) || p1choise == 2 && (p2choise == 1 || p2choise == 4) || p1choise == 3 && (p2choise == 2 || p2choise == 5) || p1choise == 4 && (p2choise == 1 || p2choise == 3) || p1choise == 5 && (p2choise == 2 || p2choise == 4))
            {
                MessageBox.Show("Player1", "WINNER");
                p1wins++;
            }
            else
            {
                MessageBox.Show("Player2", "WINNER");
                p2wins++;
            }
            // updates win counters
            lblwins1.Text = p1wins.ToString();
            lblwins2.Text = p2wins.ToString();
        }

        private void btnselect1_Click(object sender, EventArgs e)
        {
            // sets player1's choise for match
            if (rbrock.Checked)
            {
                p1choise = 1;
            }
            else if (rbpaper.Checked)
            {
                p1choise = 2;
            }
            else if (rbsissers.Checked)
            {
                p1choise = 3;
            }
            else if (rbspock.Checked)
            {
                p1choise = 4;
            }
            else
            {
                p1choise = 5;
            }
            //updates to player2's turn
            groupBox1.Enabled = false;
            groupBox2.Enabled = true;

            btnselect1.Enabled = false;
            btnselect2.Enabled = true;

            imgP1.Image = picWclangLjava.Image;
        }

        private void btnselect2_Click(object sender, EventArgs e)
        {
            // sets player1's choise for match
            if (rbrock2.Checked)
            {
                p2choise = 1;
            }
            else if (rbpaper2.Checked)
            {
                p2choise = 2;
            }
            else if (rbsissers2.Checked)
            {
                p2choise = 3;
            }
            else if (rbspock2.Checked)
            {
                p2choise = 4;
            }
            else
            {
                p2choise = 5;
            }
            // all turns are done (waiting for reveal or reset)
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;

            btnselect1.Enabled = false;
            btnselect2.Enabled = false;


            imgP2.Image = picWclangLjava.Image;



        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // resets match (clears choices and images)
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;

            btnselect1.Enabled = true;
            btnselect2.Enabled = false;

            imgP1.Image = null;
            imgP2.Image = null;


        }
    }
}
