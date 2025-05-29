using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    // this is form 2
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }

        private void lblHTP_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog(); // Shows Form2
        }
    }
}
