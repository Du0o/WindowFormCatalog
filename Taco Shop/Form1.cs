using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



/*
 Programmer:Teddy T
 Program: Taco shop
 Date:11/7/24
 */

namespace Taco_Shop
{
    public partial class Form1 : Form
    {
        // decaring constants for prices and tax
        const decimal FLOUR_PRICE = 1.25m;
        const decimal CORN_PRICE = 1.5m;
        const decimal SHELL_PRICE = 1.75m;
        const decimal BEEF_PRICE = 2.5m;
        const decimal CHICKEN_PRICE = 3m;
        const decimal FISH_PRICE = 3.5m;
        const decimal RICE_PRICE = 1.75m;
        const decimal CHEESE_PRICE = 1.5m;
        const decimal TOMATO_PRICE = 0.75m;
        const decimal LETTUCE_PRICE = 0.5m;
        const decimal GUAC_PRICE = 1m;
        const decimal TAX = 0.0755m;

        //global varibles for checkout
        private decimal selectionCost = 0m;
        private decimal totalCost = 0m;
        private decimal subTotal = 0m;


        //manager stats
        private decimal totalSales = 0m;
        private int totalCustomers  = 0;
        private decimal avarageSale = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // this closes program
            this.Close();
        }

        private void btnaddorder_Click(object sender, EventArgs e)
        {
            //calculate and display costs of purchase
            //step 1 declare the local variable
            decimal priceDecimal = 0m;
            decimal taxDecimal = 0m;
            int quantityInteger = 0;
            decimal itemAmount = 0m;
            try
            {
                quantityInteger = int.Parse(txtquantity.Text);
            }
            catch
            {

            }
            // tortilla
            if (radflour.Checked)
            {
                priceDecimal += FLOUR_PRICE;
            }
            else if (radcorn.Checked)
            {
                priceDecimal += CORN_PRICE;
            }
            else if (radshell.Checked)
            {
                priceDecimal += SHELL_PRICE;
            }
            // meat
            if (radbeef.Checked)
            {
                priceDecimal += BEEF_PRICE;
            }
            else if (radchicken.Checked)
            {
                priceDecimal += CHICKEN_PRICE;
            }
            else if (radfish.Checked)
            {
                priceDecimal += FISH_PRICE;
            }
            // addons
            if (cdlettuce.Checked)
            {
                priceDecimal += LETTUCE_PRICE;
            }
            if (cdrice.Checked)
            {
                priceDecimal += RICE_PRICE;
            }
            if (cbcheese.Checked)
            {
                priceDecimal += CHEESE_PRICE;
            }
            if (cbguac.Checked)
            {
                priceDecimal += GUAC_PRICE;
            }
            if (cbtomato.Checked)
            {
                priceDecimal += TOMATO_PRICE;
            }

            itemAmount = priceDecimal * quantityInteger;

            subTotal += itemAmount;
            //check for checkbox selected
            if (cbtax.Checked)
            {
                taxDecimal = subTotal * TAX;
            }
            else { taxDecimal = 0; }
            totalCost = subTotal + taxDecimal;

            lblselectcost.Text = priceDecimal.ToString("C");
            lbltotalcost.Text = totalCost.ToString("C");


        }

        private void radflour_CheckedChanged(object sender, EventArgs e)
        {
            pictortilla.Image = imgflour.Image;

        }

        private void btnclearorder_Click(object sender, EventArgs e)
        {
            //this clears order
            radflour.Checked = false;
            radbeef.Checked = false;
            radchicken.Checked = false;
            radcorn.Checked = false;
            radfish.Checked = false;
            radshell.Checked = false;

            cdlettuce.Checked = false;
            cdrice.Checked = false;
            cbcheese.Checked = false;
            cbguac.Checked = false;
            cbtomato.Checked = false;

            selectionCost = 0m;
            totalCost = 0m;
            subTotal = 0m;

            lblselectcost.Text = "";
            lbltotalcost.Text = "";
            picaddons.Image = imgclear.Image;
            picmeats.Image = imgclear.Image;
            pictortilla.Image = imgclear.Image;



        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
            if (radflour.Checked)
            {
                pictortilla.Image = imgflour.Image;
            }
            else if (radcorn.Checked)
            {
                pictortilla.Image = imgcorn.Image;
            }
            else if (radshell.Checked)
            {
                pictortilla.Image = imgshell.Image;
            }
        }

        private void radcorn_CheckedChanged(object sender, EventArgs e)
        {
            pictortilla.Image = imgcorn.Image;
        }

        private void radshell_CheckedChanged(object sender, EventArgs e)
        {
            pictortilla.Image = imgshell.Image;
        }

        private void radbeef_CheckedChanged(object sender, EventArgs e)
        {
            picmeats.Image = imgbeef.Image;
        }

        private void radchicken_CheckedChanged(object sender, EventArgs e)
        {
            picmeats.Image = imgchicken.Image;
        }

        private void radfish_CheckedChanged(object sender, EventArgs e)
        {
            picmeats.Image = imgfish.Image;
        }

        private void cbcheese_CheckedChanged(object sender, EventArgs e)
        {
            picaddons.Image = imgcheese.Image;
        }

        private void cbguac_CheckedChanged(object sender, EventArgs e)
        {
            picaddons.Image = imgguac.Image;
        }

        private void cdlettuce_CheckedChanged(object sender, EventArgs e)
        {
            picaddons.Image = lmglettuce.Image;
        }

        private void cbtomato_CheckedChanged(object sender, EventArgs e)
        {
            picaddons.Image = imgtomato.Image;
        }

        private void cdrice_CheckedChanged(object sender, EventArgs e)
        {
            picaddons.Image = imgrice.Image;
        }

        private void btncomplete_Click(object sender, EventArgs e)
        {
            //this reviews current order and sets up
            // for new order
            string name = txtname.Text;
            string ordernum = txtordernum.Text;

            DialogResult resultAnswer = DialogResult;
            string messageString = null;
            messageString = "Are you finished";
            resultAnswer = MessageBox.Show(messageString,

            "Final Order",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (resultAnswer == DialogResult.Yes)
            {
                totalSales += totalCost;
                totalCustomers++;
                avarageSale = totalSales / totalCustomers;
                messageString = "Your final order is:" + totalCost +". thank you for ordering "+name+"order #: "+ordernum;
                MessageBox.Show(messageString, "Check out",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                subTotal = 0;
                btnsummury.Enabled = true;
                btnclearorder_Click(sender, e);
            }
        }

        private void btnsummury_Click(object sender, EventArgs e)
        {
            //this shows the manager stats
            String anotherMessage = "Stores total sales: " +
            totalSales.ToString("C") + "\n" +
            "Total Customers: " + totalCustomers.ToString() +
            "\n" + "Average Sale: " + avarageSale.ToString("C");
            MessageBox.Show(anotherMessage, "Store Stats",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
