using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bees
{
    //Programmer : Teddy T
    //Program : Bee Simulator
    //Date : 3/10/25
    public partial class Form1 : Form
    {
        // global variable setup
        List<PictureBox> BeeList = new List<PictureBox>();
        int BeeCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        // when spacebar pressed
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyEventArgs key = e;
            //dynamically make bees
            if (key.KeyValue == 32)
            {
                if (BeeCount < 11)
                {
                    // making a bee
                    BeeList.Add(new PictureBox());
                    //put picture box on form
                    this.Controls.Add(BeeList.ElementAt(BeeCount));
                    BeeList.ElementAt(BeeCount).Height = 50;
                    BeeList.ElementAt(BeeCount).Width = 50;
                    BeeList.ElementAt(BeeCount).Image =
                    Image.FromFile("Bee.png", true);
                    BeeList.ElementAt(BeeCount).Left =
                    Hive.Left + 220;
                    BeeList.ElementAt(BeeCount).Top =
                    Hive.Top + 200;
                    BeeList.ElementAt(BeeCount).SizeMode =
                    PictureBoxSizeMode.StretchImage;
                    BeeCount++;
                }
            }
        }
        // code for bee func and movement
        private void moveBee()
        {
           // when jitting flower
            for (int m = 0; m < BeeList.Count; m++)
            {
                if (Flower.Bounds.IntersectsWith
                (BeeList.ElementAt(m).Bounds))
                {
                    BeeList.ElementAt(m).Image =
                    Image.FromFile("PBee.png", true);
                    BeeList.ElementAt(m).Width = 51;
                }
            }
            // Bee movement
            for (int i = 0; i < BeeList.Count; i++)
            {
                if (BeeList.ElementAt(i).Width == 51)
                {
                    if (BeeList.ElementAt(i).Top > Hive.Top)
                    {
                        BeeList.ElementAt(i).Top -= 10;
                    }
                    if (BeeList.ElementAt(i).Left > Hive.Left)
                    {
                        BeeList.ElementAt(i).Left -= 10;
                    }
                }
                else
                {
                    
                    
                    if (BeeList.ElementAt(i).Top > Flower.Top)
                    {
                        BeeList.ElementAt(i).Top -= 10;
                    }
                    if (BeeList.ElementAt(i).Left < Flower.Left)
                    {
                        BeeList.ElementAt(i).Left += 10;
                    }
                }
                


            }
            // removing the bee when hitting hive
            for (int m = 0; m < BeeList.Count; m++)
            {
                if (Hive.Bounds.IntersectsWith
                (BeeList.ElementAt(m).Bounds))
                {
                    this.Controls.Remove(BeeList.ElementAt(m));
                    BeeList.Remove(BeeList.ElementAt(m));
                    BeeCount--;
                    if (BeeCount <= 0)
                    {
                        BeeList = new List<PictureBox>();
                        BeeCount = 0;
                        break;
                    }
                }
            }
        }
        // timer tick
        private void timer1_Tick(object sender, EventArgs e)
        {
            moveBee();
        }
    }
}
