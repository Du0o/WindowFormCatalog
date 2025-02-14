using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Star_Field
{
    //programmer teddy t
    //date 2/14/25
    //program star-field
    public partial class Form1 : Form
    {
        //Declare our global variables
        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        Label[] Universe = new Label[8];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create our universe
            Universe[0] = star1;
            Universe[1] = star2;
            Universe[2] = star3;
            Universe[3] = star4;
            Universe[4] = star5;
            Universe[5] = star6;
            Universe[6] = star7;
            Universe[7] = star8;
            for (int n = 0; n < Universe.Length; n++)
            {
                int randomx = r.Next(0, this.Width);
                int randomy = r.Next(0, this.Height);
                Universe[n].Left = randomx;
                Universe[n].Top = randomy;
                int theWidth = r.Next(1, 11);
                Universe[n].Width = theWidth;
                Universe[n].Height = theWidth;
            }
            
        }
        private void growStars()
        {
            //grow the stars and randomly replace them
            for (int i = 0; i < Universe.Length; i++)
            {
                Universe[i].Width += 1;
                Universe[i].Height += 1;
                Universe[i].Top += 5;
                Universe[i].Left += 5;

                if (Universe[i].Width > 10 || Universe[i].Top > this.Height || Universe[i].Top < 0 || Universe[i].Left > this.Width || Universe[i].Left < 0)
                {
                    int randomx = r.Next(0, this.Width);
                    int randomy = r.Next(0, this.Height);
                    Universe[i].Left = randomx;
                    Universe[i].Top = randomy;
                    Universe[i].Width = 1;
                    Universe[i].Height = 1;
                }
            }
        }
        // every 0.1 sec // timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            growStars();
        }
    }
}
