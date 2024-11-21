using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Goodbye_project
{
    // Programer:Teddy Todorov
    // Date:8/26/24
    // Program:Goodbye Project
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            // this closes the program
            this.Close();
        }

        private void lbltranslat_Click(object sender, EventArgs e)
        {

        }

        private void btnbulgaria_Click(object sender, EventArgs e)
        {
            // this changes label text to goodbye in bulgarian
            lbltranslat.Text = "довиждане";
        }

        private void btnkorean_Click(object sender, EventArgs e)
        {
            // this changes label text to goodbye in korean
            lbltranslat.Text = "안녕히가세요";
        }

        private void btnbrazilan_Click(object sender, EventArgs e)
        {
            // this changes label text to goodbye in brazilian
            lbltranslat.Text = "despedida";
        }

        private void btnarabic_Click(object sender, EventArgs e)
        {
            // this changes label text to goodbye in aribic
            lbltranslat.Text = "وداعاً";
        }
    }
}
