using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    //Programmer:Teddy T
    //Date:9/11/24
    //Program:Book Store
    public partial class Form1 : Form
    {
        private decimal totalpeople;
        private decimal totalsales;
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // step1: get desimiles
            decimal pricedesible;
            decimal quandesible;
            decimal extendesible;
            decimal discountdesible;
            decimal pricdiscountedesible;

            decimal avaragesaleprice;
            // step2: get get info from text boxes
            pricedesible = decimal.Parse(txtprice.Text);
            quandesible = decimal.Parse(txtquan.Text);
            // step3: calculations
            extendesible = pricedesible * quandesible;
            discountdesible = extendesible * (decimal)0.15;
            pricdiscountedesible = extendesible - discountdesible;

            totalpeople += 1;
            totalsales += pricdiscountedesible;
            avaragesaleprice = totalsales / totalpeople;
            // step4: display
            lblextpri.Text = extendesible.ToString();
            lbldisamo.Text = discountdesible.ToString();
            lbldispri.Text = pricdiscountedesible.ToString();

            lbltotalpe.Text = totalpeople.ToString();
            lbltotalsa.Text = totalsales.ToString();
            lblavargesa.Text = avaragesaleprice.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblextpri_Click(object sender, EventArgs e)
        {

        }

        private void lbldisamo_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbldispri_Click(object sender, EventArgs e)
        {

        }
    }
}
