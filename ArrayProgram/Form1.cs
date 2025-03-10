using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayProgram
{
    //Programmer: Teddy T
    //Program: Array Program
    //Date:3/5/25
    public partial class Form1 : Form
    {
        //set up random number generator
        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        int[] Num = new int[100];
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        // run button code
        private void btnRun_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            {
                timer1.Enabled = false;
            }
            else
            {
                timer1.Enabled = true;
            }
        }
        // happens every tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            string theNumbers = "";
            int highest = 0;
            int lowest = 50;
            int avarage = 0;
            int avaragetotal = 0;
            int odd = 0;
            int even = 0;
            //fill the array with random numbers
            for (int i = 0; i < Num.Length; i++)
            {
                Num[i] = r.Next(1, 101);
                avaragetotal += Num[i];
            }
            //find the highest number
            for (int j = 0; j < Num.Length; j++)
            {
                if (Num[j] > highest)
                {
                    highest = Num[j];
                }
            }
            for (int g = 0; g < Num.Length; g++)
            {
                if (Num[g] < lowest)
                {
                    lowest = Num[g];
                }
            }
            for (int r = 0; r < Num.Length; r++)
            {
                if(Num[r] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            // display to label
            for (int n = 0; n < Num.Length; n++)
            {
                theNumbers += Num[n] + " ";
            }
            avarage = avaragetotal / Num.Length;
            lbldisplay.Text = theNumbers + "\n" +
            "Highest= " + highest +
            "\nLowest= " + lowest +
            "\nOdds= " + odd +
            "\nEvens= " + even +
            "\nAvarage= " + avarage;
        }
    }
}
