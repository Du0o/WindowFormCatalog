using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI
{

    // Programmer: Teddy T
    // Date: 9/19/24
    // Program: BMI calculator
    public partial class Form1 : Form
    {
        private decimal avarage;
        private decimal timescalc;
        private decimal total;

        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("hehehehhahhah");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // this closes program
            this.Close();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // make variables
                decimal feet;
                decimal inches;
                decimal pounds;
                decimal meters;
                decimal kilograms;
                decimal bmi;
                // set variables
                feet = decimal.Parse(txtfeet.Text);
                inches = decimal.Parse(txtinches.Text);
                pounds = decimal.Parse(txtpounds.Text);
                // calculations
                meters = (feet * 12) + inches;
                meters = meters * (decimal)0.0254;
                kilograms = pounds * (decimal)0.454;
                bmi = kilograms / (meters * meters);
                timescalc++;
                total = total + bmi;
                avarage = total / timescalc;
                // set labels
                lblbmiscalculated.Text = timescalc.ToString();
                lblbmi.Text = Math.Ceiling(bmi).ToString();
                lblavarage.Text = Math.Ceiling(avarage).ToString();
            }
            catch
            {
                MessageBox.Show("you forgot data", "data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void lblbmiscalculated_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            // this clear all text
            txtfeet.Text = "";
            txtinches.Text = "";
            txtpounds.Text = "";
            lblavarage.Text = "";
            lblbmi.Text = "";
            lblbmiscalculated.Text = "";
        }
    }
}
