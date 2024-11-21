using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mailing_Label
{
    //Programer:Teddy_Todorov
    //Date:9/3/24
    //Program:Mailing_Label
    public partial class Form1 : Form
    {
        // integer for tracking how many times make label is pressed
        public int numlabels = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnmakelabel_Click(object sender, EventArgs e)
        {
            //makes the label text
            lblmessage.Text = txtfname.Text +" "+
                txtlname.Text+"\n"+
                txtSA.Text + "\n" +
                txtcity.Text + ",  " +
                txtstate.Text + " " +
                txtzip.Text;
            numlabels += 1;
            lblnum.Text =  numlabels.ToString();
        }

        private void lblmessage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            // this changes label text color
            colorDialog1.ShowDialog();
            lblmessage.ForeColor = colorDialog1.Color;
        }

        private void btnfont_Click(object sender, EventArgs e)
        {
            // this changes labels texts font
            fontDialog1.ShowDialog();
            lblmessage.Font = fontDialog1.Font;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // this clear text
            lblmessage.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtSA.Text = "";
            txtcity.Text = "";
            txtstate.Text = "";
            txtzip.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //this closes the program
            this.Close();
        }
    }
}
