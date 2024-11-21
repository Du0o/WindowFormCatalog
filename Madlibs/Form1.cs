using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    //Programer:Teddy Todorov
    //Date:9/5/24
    //Program:Madlibs
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void make_story_Click(object sender, EventArgs e)
        {
            //this updates message text
            lblmessage.Text = "Once upon a time there was a " +
                txtadj1.Text+
                " "+
                txtnoun1.Text +
                " "+
                "named Mr. T. "+ "\n"+" He liked "+
                txtnoun2.Text +
                " and "+
                txtnoun3.Text +
                " and would do anything to get them. Mr. T divised a "+
                txtadj2.Text +
                " plan that would get all the "+
                txtnoun4.Text +
                ". He "+
                Txtadverb.Text +
                " put that plan into action. First he would "+
                txtverb1.Text +
                " the "+
                txtnoun5.Text +
                " until it "+
                txtverb2.Text +
                ". Finally he could have all the "+
                txtnoun6.Text +
                " and "+
                txtnoun7.Text +
                " he wanted.";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this closes the program
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //clears all text on screen
            txtadj1.Text = "";
            txtadj2.Text = "";
            txtnoun1.Text = "";
            txtnoun2.Text = "";
            txtnoun3.Text = "";
            txtnoun4.Text = "";
            txtnoun5.Text = "";
            txtnoun6.Text = "";
            txtnoun7.Text = "";
            txtverb1.Text = "";
            txtverb2.Text = "";
            Txtadverb.Text = "";
            lblmessage.Text = "";
        }
    }
}
