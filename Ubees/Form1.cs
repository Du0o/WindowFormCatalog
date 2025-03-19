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
    //Program : Bee Simulator Upgrade
    //Date : 3/19/25
    public partial class Form1 : Form
    {
        // global variable setup
        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        List <PictureBox> BeeList = new List<PictureBox>();
        PictureBox[] FlowerArray = new PictureBox[3];
        int BeeCount = 0;
        int nectar = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // setting flower array
            FlowerArray[0] = Flower1;
            FlowerArray[1] = Flower2;
            FlowerArray[2] = Flower3;
            for (int i = 0; i < 3; i++)
            {
                
                switch (r.Next(1, 4))
                {
                    case 1:
                        FlowerArray[i].Image = Image.FromFile("Flower.png", true);
                        break;
                    case 2:
                        FlowerArray[i].Image = Image.FromFile("sonicFlower.png", true);
                        break;
                    case 3:
                        FlowerArray[i].Image = Image.FromFile("fireFlower.png", true);
                        break;
                }
                
            }
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
                    int beeType = r.Next(1, 4);
                    BeeList.Add(new PictureBox());
                    //put picture box on form
                    this.Controls.Add(BeeList.ElementAt(BeeCount));
                    BeeList.ElementAt(BeeCount).BringToFront();
                    BeeList.ElementAt(BeeCount).Left =
                    Hive.Left + 220 + r.Next(1,500);
                    BeeList.ElementAt(BeeCount).Top =
                    Hive.Top + 200 + r.Next(-300, 300);
                    BeeList.ElementAt(BeeCount).SizeMode =
                    PictureBoxSizeMode.StretchImage;
                    
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            BeeList.ElementAt(BeeCount).Image = Image.FromFile("Bee.png", true);
                            BeeList.ElementAt(BeeCount).Height = 50;
                            BeeList.ElementAt(BeeCount).Width = 50;
                            break;
                        case 2:
                            BeeList.ElementAt(BeeCount).Image = Image.FromFile("fireBee.png", true);
                            BeeList.ElementAt(BeeCount).Height = 75;
                            BeeList.ElementAt(BeeCount).Width = 75;
                            break;
                        case 3:
                            BeeList.ElementAt(BeeCount).Image = Image.FromFile("electroBee.png", true);
                            BeeList.ElementAt(BeeCount).Height = 100;
                            BeeList.ElementAt(BeeCount).Width = 100;
                            break;
                    }
                    switch (r.Next(1, 4))
                    {
                        case 1:
                            BeeList.ElementAt(BeeCount).Tag = 0;

                            break;
                        case 2:
                            BeeList.ElementAt(BeeCount).Tag = 1;
                            break;
                        case 3:
                            BeeList.ElementAt(BeeCount).Tag = 2;
                            break;
                    }
                    BeeCount++;
                }
            }
        }
        // code for bee func and movement
        private void moveBee()
        {
           // when hitting flower
            for (int m = 0; m < BeeList.Count; m++)
            {
                if (Flower1.Bounds.IntersectsWith(BeeList.ElementAt(m).Bounds) || Flower2.Bounds.IntersectsWith(BeeList.ElementAt(m).Bounds) || Flower3.Bounds.IntersectsWith(BeeList.ElementAt(m).Bounds))
                {
                    if (BeeList.ElementAt(m).Width == 50)
                    {
                        BeeList.ElementAt(m).Width = 51;
                    }
                    else if (BeeList.ElementAt(m).Width == 75)
                    {
                        BeeList.ElementAt(m).Width = 76;
                    }
                    else if (BeeList.ElementAt(m).Width == 100)
                    {
                        BeeList.ElementAt(m).Width = 101;
                    }
                }
            }
            // Bee movement
            for (int i = 0; i < BeeList.Count; i++)
            {
                if (BeeList.ElementAt(i).Width == 51)
                {
                    BeeList.ElementAt(i).Image = Image.FromFile("PBee.png", true);
                }
                else if (BeeList.ElementAt(i).Width == 76)
                {
                    BeeList.ElementAt(i).Image = Image.FromFile("fireBeeA.png", true);
                }
                else if (BeeList.ElementAt(i).Width == 101)
                {
                    BeeList.ElementAt(i).Image = Image.FromFile("electroBeeA.png", true);
                }
                if (BeeList.ElementAt(i).Width == 51 || BeeList.ElementAt(i).Width == 76 || BeeList.ElementAt(i).Width == 101)
                {
                    if (BeeList.ElementAt(i).Top > Hive.Top)
                    {
                        BeeList.ElementAt(i).Top -= 5;
                    }
                    if (BeeList.ElementAt(i).Left > Hive.Left)
                    {
                        BeeList.ElementAt(i).Left -= 5;
                    }

                    if (BeeList.ElementAt(i).Top < Hive.Top)
                    {
                        BeeList.ElementAt(i).Top += 5;
                    }
                    if (BeeList.ElementAt(i).Left < Hive.Left)
                    {
                        BeeList.ElementAt(i).Left += 5;
                    }
                }
                else
                {

                    switch (BeeList.ElementAt(i).Tag)
                    {
                        case 0:
                            if (BeeList.ElementAt(i).Top > Flower1.Top)
                            {
                                BeeList.ElementAt(i).Top -= 5;
                            }
                            if (BeeList.ElementAt(i).Left < Flower1.Left)
                            {
                                BeeList.ElementAt(i).Left += 5;
                            }

                            if (BeeList.ElementAt(i).Top < Flower1.Top)
                            {
                                BeeList.ElementAt(i).Top += 5;
                            }
                            if (BeeList.ElementAt(i).Left > Flower1.Left)
                            {
                                BeeList.ElementAt(i).Image =
                            Image.FromFile("PBee.png", true);
                                BeeList.ElementAt(i).Left -= 5;
                            }
                            break;
                        case 1:
                            if (BeeList.ElementAt(i).Top > Flower2.Top)
                            {
                                BeeList.ElementAt(i).Top -= 5;
                            }
                            if (BeeList.ElementAt(i).Left < Flower2.Left)
                            {
                                BeeList.ElementAt(i).Left += 5;
                            }

                            if (BeeList.ElementAt(i).Top < Flower2.Top)
                            {
                                BeeList.ElementAt(i).Top += 5;
                            }
                            if (BeeList.ElementAt(i).Left > Flower2.Left)
                            {
                                
                                BeeList.ElementAt(i).Left -= 5;
                            }
                            break;
                        case 2:
                            if (BeeList.ElementAt(i).Top > Flower3.Top)
                            {
                                BeeList.ElementAt(i).Top -= 5;
                            }
                            if (BeeList.ElementAt(i).Left < Flower3.Left)
                            {
                                BeeList.ElementAt(i).Left += 5;
                            }

                            if (BeeList.ElementAt(i).Top < Flower3.Top)
                            {
                                BeeList.ElementAt(i).Top += 5;
                            }
                            if (BeeList.ElementAt(i).Left > Flower3.Left)
                            {
                                BeeList.ElementAt(i).Image =
                            Image.FromFile("PBee.png", true);
                                BeeList.ElementAt(i).Left -= 5;
                            }
                            break;
                    }

                    
                }
                


            }
            // removing the bee when hitting hive
            for (int m = 0; m < BeeList.Count; m++)
            {
                if (Hive.Bounds.IntersectsWith
                (BeeList.ElementAt(m).Bounds))
                {
                    switch (BeeList.ElementAt(m).Tag)
                    {
                        case 0:
                            nectar += 100;
                            break;
                        case 1:
                            nectar += 250;
                            break;
                        case 2:
                            nectar += 500;
                            break;
                    }
                    lblnectar.Text = nectar.ToString();
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
