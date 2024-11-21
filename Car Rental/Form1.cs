using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental
{
    // _________________
    //|# :           : #|
    //|  :           :  |
    //|  :    :)     :  |
    //|  :           :  |
    //|  :___________:  |
    //|     _________   |
    //|    | __      |  |
    //|    ||  |     |  |
    //\____||__|_____|__|
    //
    //Programmer:Teddy Todorov
    //Date:N/A
    //Program:Car Rental
    public partial class Form1 : Form
    {

        private decimal totalearning;
        private decimal cars;
        private decimal avarage;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            // step1: set variables
            decimal startodo;
            decimal endodo;
            decimal miles;
            decimal days;
            decimal finalprice;
            decimal mileprice;
            decimal dayprice;
            //step2: set text boxes
            endodo = decimal.Parse(txtendingodo.Text);
            startodo = decimal.Parse(txtstartodo.Text);
            days = decimal.Parse(txtnumday.Text);
            //step3: calculations
            miles = endodo - startodo;
            mileprice = miles * (decimal)1.25;
            dayprice = days * 150;
            finalprice = dayprice + mileprice + (decimal)1.25;
            totalearning += finalprice;
            cars++;
            avarage = totalearning / cars;
            //step4: set labels
            lblprice.Text = "$"+finalprice.ToString();
            lblTR.Text = "$"+totalearning.ToString();
            lblmiles.Text = miles.ToString();
            lblcar.Text = cars.ToString();
            lblavarage.Text = avarage.ToString();
            lblCI.Text = txtfname.Text +", "+txtlname.Text + "\n" +txtstreet.Text+"\n"+txtcity.Text +", "+txtstate.Text+ "\n" + txtzip.Text;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            //this clears text
            lblavarage.Text = "";
            lblcar.Text = "";
            lblCI.Text = "";
            lblmiles.Text = "";
            lblprice.Text = "";
            lblTR.Text = "";
            txtcity.Text = "";
            txtendingodo.Text = "";
            txtfname.Text = "";
            txtlname.Text = "";
            txtnumday.Text = "";
            txtstartodo.Text = "";
            txtstate.Text = "";
            txtstreet.Text = "";
            txtzip.Text = "";
        }
    }
}
