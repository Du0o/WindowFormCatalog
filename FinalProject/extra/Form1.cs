using System;
using System.Drawing;
using System.Windows.Forms;

namespace FinalProject
{
    // if you want to access the dev console you need to press "~"
    /*
     "gain" get equipment
     "move" skip 5 levels
     "print" prints hello world
     */

    /*
     Programmer: Teddy T
    Date:5/28/25
    Project: Final Project
     */
    public partial class Form1 : Form
    {
        
        // setup variables

        System.Random r = new System.Random((int)
        System.DateTime.Now.Ticks);
        PictureBox[,] tileMap = new PictureBox[7, 6];
        bool attacking = false;
        int totalNegate = 0;
        int negate = 0;
        int totalDamage = 0;
        int damage = 0;
        string consoleI = "1010101001010101001";
        int[,] intTileMap = new int[7, 6];
        int[,] tempTileMap = new int[7, 6];
        int[] playerPos = new int[2];
        int level = 0;
        int score = 0;
        int cash = 0;
        int lv = 1;
        int attacks = 5;
        int Eattacks = 1;
        int attack = 100;
        int Eattack = 100;
        string weapon = "dagger";
        int defence = 0;
        int Edefence = 0;
        string armor = "Boris";
        int health = 100;
        int Ehealth = 100;
        int speed = 100;
        int Espeed = 100;
        int dir = 1;
        bool inventory = false;
        bool ferry = false;
        string artifact1 = "None";
        string artifact2 = "None";

        // Static map blueprints for generating levels
        /*
        0 = nothing
        1 = wall
        2 = chest
        4 5 6 = door
        7 = ferryman
        8 = griffin
        10 = cyclops
        12 = centaur
        14 = minator
        16 = cerberus
        17 = typhon
        18 = medusa
        19 = hydra
        20 = tartarus
         */
        readonly int[,] resetLvl ={{0,0,0,0,0,0},
                                  { 0,0,0,0,0,0},
                                  { 0,0,0,0,0,0},
                                  { 0,0,0,0,0,0},
                                  { 0,0,0,0,0,0},
                                  { 0,0,0,0,0,0},
                                  { 0,0,0,0,0,0} };

        readonly int[,] basicLvl ={{1,1,1,1,1,1},
                                  { 1,0,0,0,0,1},
                                  { 1,0,0,0,0,1},
                                  { 0,0,0,0,0,4},
                                  { 1,0,0,0,0,1},
                                  { 1,0,0,0,0,1},
                                  { 1,1,1,1,1,1} };

        readonly int[,] basicLvl2={{1,1,1,1,1,1},
                                  { 1,2,8,8,2,1},
                                  { 1,1,0,0,1,1},
                                  { 0,0,0,0,0,4},
                                  { 1,1,0,0,1,1},
                                  { 1,2,8,8,2,1},
                                  { 1,1,1,1,1,1} };

        readonly int[,] basicLvl3={{1,1,1,1,1,1},
                                  { 1,1,0,10,2,1},
                                  { 1,1,0,1,1,1},
                                  { 0,0,0,1,0,4},
                                  { 1,1,0,1,0,1},
                                  { 1,1,0,0,0,1},
                                  { 1,1,1,1,1,1} };

        readonly int[,] basicLvl4={{1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 0,0,0,12,0,4},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1} };

        readonly int[,] basicLvl5={{1,1,1,6,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 0,0,0,14,0,4},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,5,1,1} };

        readonly int[,] basicLvl6={{1,1,1,6,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 0,0,0,10,1,1},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1} };
         
        readonly int[,] basicLvl7={{1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 1,1,1,1,1,1},
                                  { 0,0,0,8,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,5,1,1} };

        readonly int[,] basicLvl8={{1,1,1,6,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 0,0,0,12,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,0,1,1},
                                  { 1,1,1,5,1,1} };

        readonly int[,] basicLvl9={{1,1,1,1,1,1},
                                  { 1,1,0,0,0,1},
                                  { 1,1,0,1,0,1},
                                  { 0,0,0,1,0,4},
                                  { 1,1,0,1,1,1},
                                  { 1,1,0,14,7,1},
                                  { 1,1,1,1,1,1} };
        // right facing rooms
        readonly int[,] basicLvl6l={{1,1,1,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,0,4},
                                  {  1,1,2,8,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,5,1,1} };

        readonly int[,] basicLvl7l={{1,1,1,0,1,1},
                                  {  1,0,0,0,1,1},
                                  {  1,12,1,0,1,1},
                                  {  1,2,1,0,1,1},
                                  {  1,12,1,0,1,1},
                                  {  1,0,0,0,1,1},
                                  {  1,1,1,5,1,1} };

        readonly int[,] basicLvl8l={{1,1,1,0,1,1},
                                  {  1,0,0,0,1,1},
                                  {  1,10,1,1,1,1},
                                  {  1,0,0,0,0,4},
                                  {  1,1,1,1,1,1},
                                  {  1,1,1,1,1,1},
                                  {  1,1,1,1,1,1} };

        readonly int[,] basicLvl9l={{1,1,1,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,2,8,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,5,1,1} };
        // left facing rooms
        readonly int[,] basicLvl6r={{1,1,1,6,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,2,0,1,1},
                                  {  1,1,1,0,12,4},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,1,1}, 
                                  {  1,1,1,0,1,1} };

        readonly int[,] basicLvl7r={{1,1,1,6,1,1},
                                  {  1,2,8,0,0,1},
                                  {  1,1,1,1,0,1},
                                  {  1,0,0,0,0,1},
                                  {  1,0,1,1,1,1},
                                  {  1,0,0,0,1,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] basicLvl8r={{1,1,1,1,1,1},
                                  {  1,14,2,2,2,1},
                                  {  1,0,1,1,1,1},
                                  {  1,0,1,0,0,4},
                                  {  1,0,1,0,1,1},
                                  {  1,0,0,0,1,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] basicLvl9r={{1,1,1,6,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,2,0,1,1},
                                  {  1,1,1,0,2,1},
                                  {  1,1,2,0,1,1},
                                  {  1,1,1,0,1,1},
                                  {  1,1,1,0,1,1} };
        // boss rooms
        readonly int[,] bossroom1 ={{1,1,1,0,1,1},
                                  {  1,2,2,2,2,1},
                                  {  1,0,0,0,0,1},
                                  {  0,0,0,0,16,4},
                                  {  1,0,0,0,0,1},
                                  {  1,2,2,2,2,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] bossroom2 ={{1,1,1,0,1,1},
                                  {  1,2,2,2,2,1},
                                  {  1,0,0,0,0,1},
                                  {  0,0,0,0,17,4},
                                  {  1,0,0,0,0,1},
                                  {  1,2,2,2,2,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] bossroom3 ={{1,1,1,0,1,1},
                                  {  1,2,2,2,2,1},
                                  {  1,0,0,0,0,1},
                                  {  0,0,0,0,18,4},
                                  {  1,0,0,0,0,1},
                                  {  1,2,2,2,2,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] bossroom4 ={{1,1,1,0,1,1},
                                  {  1,2,2,2,2,1},
                                  {  1,0,0,0,0,1},
                                  {  0,0,0,0,19,4},
                                  {  1,0,0,0,0,1},
                                  {  1,2,2,2,2,1},
                                  {  1,1,1,0,1,1} };

        readonly int[,] bossroom5 ={{1,1,1,0,1,1},
                                  {  1,2,2,2,2,1},
                                  {  1,0,0,0,0,1},
                                  {  0,0,0,0,20,4},
                                  {  1,0,0,0,0,1},
                                  {  1,2,2,2,2,1},
                                  {  1,1,1,0,1,1} };
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        // setting up tilemap for use   
        tileMap[0, 0] = pictureBox1;
            tileMap[1, 0] = pictureBox2;
            tileMap[2, 0] = pictureBox3;
            tileMap[3, 0] = pictureBox4;
            tileMap[4, 0] = pictureBox5;
            tileMap[5, 0] = pictureBox6;
            tileMap[6, 0] = pictureBox7;

            tileMap[0, 1] = pictureBox8;
            tileMap[1, 1] = pictureBox9;
            tileMap[2, 1] = pictureBox10;
            tileMap[3, 1] = pictureBox11;
            tileMap[4, 1] = pictureBox12;
            tileMap[5, 1] = pictureBox13;
            tileMap[6, 1] = pictureBox14;

            tileMap[0, 2] = pictureBox15;
            tileMap[1, 2] = pictureBox16;
            tileMap[2, 2] = pictureBox17;
            tileMap[3, 2] = pictureBox18;
            tileMap[4, 2] = pictureBox19;
            tileMap[5, 2] = pictureBox20;
            tileMap[6, 2] = pictureBox21;

            tileMap[0, 3] = pictureBox22;
            tileMap[1, 3] = pictureBox23;
            tileMap[2, 3] = pictureBox24;
            tileMap[3, 3] = pictureBox25;
            tileMap[4, 3] = pictureBox26;
            tileMap[5, 3] = pictureBox27;
            tileMap[6, 3] = pictureBox28;

            tileMap[0, 4] = pictureBox29;
            tileMap[1, 4] = pictureBox30;
            tileMap[2, 4] = pictureBox31;
            tileMap[3, 4] = pictureBox32;
            tileMap[4, 4] = pictureBox33;
            tileMap[5, 4] = pictureBox34;
            tileMap[6, 4] = pictureBox35;

            tileMap[0, 5] = pictureBox36;
            tileMap[1, 5] = pictureBox37;
            tileMap[2, 5] = pictureBox38;
            tileMap[3, 5] = pictureBox39;
            tileMap[4, 5] = pictureBox40;
            tileMap[5, 5] = pictureBox41;
            tileMap[6, 5] = pictureBox42;

            // Render the tilemap / spawn player
            renderGrid(basicLvl);
            spawnPlayer();
        }
        private void renderGrid(int[,] Lvl)
        {
            // update labels
            lbllevel.Text = level.ToString();
            lblscore.Text = score.ToString();
            tempTileMap = resetLvl;
            // override for boss rooms
            if (level == 20)
            {
                Lvl = bossroom1;
            }
            else if (level == 40)
            {
                Lvl = bossroom2;
            }
            else if (level == 60)
            {
                Lvl = bossroom3;
            }
            else if (level == 80)
            {
                Lvl = bossroom4;
            }
            else if (level == 100)
            {
                Lvl = bossroom5;
            }
            tempTileMap = Lvl;
            // setting images for tiles
            for (int i = 0; i < 7; i++)
            {
                for (int o = 0; o < 6; o++)
                {
                    switch (tempTileMap[i,o])
                    {
                        case 0:
                            tileMap[i, o].Image = null;
                            break;
                        case 1:
                            tileMap[i, o].Image = Image.FromFile("tiles/basaltTile.png", true);
                            break;
                        case 2:
                            tileMap[i, o].Image = Image.FromFile("GoldChest.png", true);
                            break;
                        case 3:
                            tileMap[i, o].Image = Image.FromFile("GoldChest.png", true);
                            tempTileMap[i, o] = 2;
                            break;
                        case 4:
                            tileMap[i, o].Image = Image.FromFile("door.png", true);
                            break;
                        case 5:
                            tileMap[i, o].Image = Image.FromFile("door.png", true);
                            break;
                        case 6:
                            tileMap[i, o].Image = Image.FromFile("door.png", true);
                            break;
                        case 7:
                            tileMap[i, o].Image = Image.FromFile("FerryMan.png", true);
                            break;
                        case 8:
                            tileMap[i, o].Image = Image.FromFile("Griffin.png", true);
                            break;
                        case 9:
                            tileMap[i, o].Image = Image.FromFile("Griffin.png", true);
                            tempTileMap[i, o] = 8;
                            break;
                        case 10:
                            tileMap[i, o].Image = Image.FromFile("Cyclops.png", true);
                            break;
                        case 11:
                            tileMap[i, o].Image = Image.FromFile("Cyclops.png", true);
                            tempTileMap[i, o] = 10;
                            break;
                        case 12:
                            tileMap[i, o].Image = Image.FromFile("Centaur.png", true);
                            break;
                        case 13:
                            tileMap[i, o].Image = Image.FromFile("Centaur.png", true);
                            tempTileMap[i, o] = 12;
                            break;
                        case 14:
                            tileMap[i, o].Image = Image.FromFile("minator.png", true);
                            break;
                        case 15:
                            tileMap[i, o].Image = Image.FromFile("minator.png", true);
                            tempTileMap[i, o] = 14;
                            break;
                        case 16:
                            tileMap[i, o].Image = Image.FromFile("Cerberus.png", true);
                            break;
                        case 17:
                            tileMap[i, o].Image = Image.FromFile("Typhon.png", true);
                            break;
                        case 18:
                            tileMap[i, o].Image = Image.FromFile("Medusa.png", true);
                            break;
                        case 19:
                            tileMap[i, o].Image = Image.FromFile("Hydra.png", true);
                            break;
                        case 20:
                            tileMap[i, o].Image = Image.FromFile("Tartarus.png", true);
                            break;
                    }
                    
                }
            }
        }
        // setting the players pos
        private void spawnPlayer()
        {
            // fixes player spawning in right position
            if (dir == 1)
            {
                tileMap[3, 0].Image = Image.FromFile(armor+".png", true);
                playerPos[0] = 3;
                playerPos[1] = 0;
               
            }
            else if (dir == 2)
            {
                tileMap[0, 3].Image = Image.FromFile(armor+".png", true);
                playerPos[0] = 0;
                playerPos[1] = 3;
            }
            else if (dir == 3)
            {
                tileMap[6, 3].Image = Image.FromFile(armor+".png", true);
                playerPos[0] = 6;
                playerPos[1] = 3;
            }


        }
        private void board_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void UI_Enter(object sender, EventArgs e)
        {

        }
        // for getting equipment
        private void gain()
        {
            switch (r.Next(1, 14))
            {
                case 1:
                    if (!LBWeapon.Items.Contains("Axe")){
                        LBWeapon.Items.Add("Axe");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received an Axe!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 2:
                    if (!LBArmor.Items.Contains("CoastalArmor"))
                    {
                        LBArmor.Items.Add("CoastalArmor");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received some Coastal Armor";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 3:
                    if (!LBArtifact1.Items.Contains("MedusaH"))
                    {
                        LBArtifact1.Items.Add("MedusaH");
                        LBArtifact2.Items.Add("MedusaH");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You got the head of Medusa!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 4:
                    if (!LBWeapon.Items.Contains("B_A"))
                    {
                        LBWeapon.Items.Add("B_A");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Bow and Arrow!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 5:
                    break;
                case 6:
                    if (!LBArmor.Items.Contains("GoldArmor"))
                    {
                        LBArmor.Items.Add("GoldArmor");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received some Gold Armor!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 7:
                    if (!LBWeapon.Items.Contains("Hammer"))
                    {
                        LBWeapon.Items.Add("Hammer");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Hammer!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 8:
                    if (!LBWeapon.Items.Contains("Lightning"))
                    {
                        LBWeapon.Items.Add("Lightning");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received Zeus's Lightning!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 9:
                    if (!LBWeapon.Items.Contains("Mace"))
                    {
                        LBWeapon.Items.Add("Mace");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Mace!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 10:
                    if (!LBWeapon.Items.Contains("Shield"))
                    {
                        LBWeapon.Items.Add("Shield");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Shield!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 11:
                    if (!LBWeapon.Items.Contains("Spear"))
                    {
                        LBWeapon.Items.Add("Spear");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Spear!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 12:
                    if (!LBWeapon.Items.Contains("sword"))
                    {
                        LBWeapon.Items.Add("sword");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a sword!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
                case 13:
                    if (!LBWeapon.Items.Contains("Trident"))
                    {
                        LBWeapon.Items.Add("Trident");
                        lblmsg.Visible = true;
                        lblmsg.Text = "You received a Trident!";
                    }
                    else
                    {
                        gain();
                    }
                    break;
            }
        }
        // keyboard controlls
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int whichKey = e.KeyValue;
            // to activate the dev console
            if (whichKey == 192)
            {
                devBox.BringToFront();
                if(devBox.Visible == true)
                {
                    devBox.Visible = false;
                }
                else
                {
                    devBox.Visible = true;
                }
            }

            if (!InventoryBox.Enabled || !battle.Visible || !Ferry.Visible) { 
            
            int[] tempPos = { playerPos[0], playerPos[1] };

            
            
            //left Arrow
            if (whichKey == 37)
            {
                playerPos[0] -= 1;
            }
            // right
            if (whichKey == 39)
            {
                
                playerPos[0] += 1;
            }
            // up
            if (whichKey == 38)
            {
                playerPos[1] -= 1;
            }
            //down
            if (whichKey == 40)
            {
                playerPos[1] += 1;
            }
            // tile properties
            switch (tempTileMap[playerPos[0], playerPos[1]])
            {
                case 0:
                    tileMap[tempPos[0], tempPos[1]].Image = null;
                    tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor+".png", true);
                    break;
                case 1:
                    playerPos = tempPos;
                    break;
                case 2:
                    if(tileMap[tempPos[0], tempPos[1]].Image != null)
                    {
                        cash += 100;
                        lblcash.Text = cash.ToString();
                    }
                    switch (r.Next(1, 11))
                    {
                        case 1:
                            gain();
                        break;
                    }
                    
                    tileMap[tempPos[0], tempPos[1]].Image = null;
                    tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor+".png", true);
                    
                    tempTileMap[playerPos[0], playerPos[1]] = 3;
                    break;
                case 3:
                    tileMap[tempPos[0], tempPos[1]].Image = null;
                    tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                    break;
                case 4:
                    // bottom door
                    dir = 1;
                    level++;
                    renderGrid(resetLvl);
                    switch (r.Next(1,10))
                    {
                        case 1:
                            renderGrid(basicLvl);
                            break;
                        case 2:
                            renderGrid(basicLvl2);
                            break;
                        case 3:
                            renderGrid(basicLvl3);
                            break;
                        case 4:
                            renderGrid(basicLvl4);
                            break;
                        case 5:
                            renderGrid(basicLvl5);
                            break;
                        case 6:
                            renderGrid(basicLvl6);
                            break;
                        case 7:
                            renderGrid(basicLvl7);
                            break;
                        case 8:
                            renderGrid(basicLvl8);
                            break;
                        case 9:
                            renderGrid(basicLvl9);
                            break;
                    }
                    
                    spawnPlayer();
                    break;
                case 5:
                    // right door
                    dir = 2;
                    level++;
                    renderGrid(resetLvl);
                    switch (r.Next(1, 5))
                    {
                        case 1:
                            renderGrid(basicLvl6l);
                            break;
                        case 2:
                            renderGrid(basicLvl7l);
                            break;
                        case 3:
                            renderGrid(basicLvl8l);
                            break;
                        case 4:
                            renderGrid(basicLvl9l);
                            break;
                    }

                    spawnPlayer();
                    break;
                case 6:
                    // left door
                    dir = 3;
                    level++;
                    renderGrid(resetLvl);
                    switch (r.Next(1, 5))
                    {
                        case 1:
                            renderGrid(basicLvl6r);
                            break;
                        case 2:
                            renderGrid(basicLvl7r);
                            break;
                        case 3:
                            renderGrid(basicLvl8r);
                            break;
                        case 4:
                            renderGrid(basicLvl9r);
                            break;
                    }

                    spawnPlayer();
                    break;
                        // enemys 
                    case 7:
                        playerPos = tempPos;
                        Ferry.Enabled = true;
                        Ferry.Visible = true;
                        ferry = true;
                        break;
                    case 8:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        Battle(1);
                        tempTileMap[playerPos[0], playerPos[1]] = 9;
                        break;
                    case 9:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        break;
                    case 10:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        Battle(2);
                        tempTileMap[playerPos[0], playerPos[1]] = 11;
                        break;
                    case 11:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        break;
                    case 12:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        Battle(3);
                        tempTileMap[playerPos[0], playerPos[1]] = 13;
                        break;
                    case 13:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        break;
                    case 14:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        Battle(4);
                        tempTileMap[playerPos[0], playerPos[1]] = 15;
                        break;
                    case 15:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        break;
                    case 16:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        tempTileMap[playerPos[0], playerPos[1]] = 21;
                        Battle(5);
                        break;
                    case 17:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        tempTileMap[playerPos[0], playerPos[1]] = 21;
                        Battle(6);
                        break;
                    case 18:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        tempTileMap[playerPos[0], playerPos[1]] = 21;
                        Battle(7);
                        break;
                    case 19:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        tempTileMap[playerPos[0], playerPos[1]] = 21;
                        Battle(8);
                        break;
                    case 20:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        tempTileMap[playerPos[0], playerPos[1]] = 21;
                        Battle(9);
                        break;
                    case 21:
                        tileMap[tempPos[0], tempPos[1]].Image = null;
                        tileMap[playerPos[0], playerPos[1]].Image = Image.FromFile(armor + ".png", true);
                        break;
                }
            
            }
        }

        
        // inventory button
        private void btnInventory_Click(object sender, EventArgs e)
        {
            
            

            btnInventory.TabStop = false;
            if (inventory)
            {
                InventoryBox.Enabled = false;
                InventoryBox.Visible = false;
                inventory = false;
            }
            else
            {
                InventoryBox.Enabled = true;
                InventoryBox.Visible = true;
                inventory = true;
            }
            picArmor.Image = Image.FromFile(armor + ".png", true);
            picWeapon.Image = Image.FromFile(weapon + ".png", true);
            picArtifact1.Image = Image.FromFile(artifact1 + ".png", true);
            picArtifact2.Image = Image.FromFile(artifact2 + ".png", true);

            label3.Focus();

        }
        // bug fixing
        protected override bool ShowFocusCues
        {
            get
            {
                return false;
            }
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            
        }
        // ending game
        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

        }
        // updateing armor
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            armor = LBArmor.SelectedItem.ToString();
            picArmor.Image = Image.FromFile(armor + ".png", true);

            switch (armor)
            {
                case "Boris":
                    defence = 0;
                    break;
                case "GoldArmor":
                    defence = 100;
                    break;
            }

            lblDefence.Text = "Defence: " + defence.ToString();
            lblAttack.Text = "Attack: " + attack.ToString();
            lblSpeed.Text = "Speed: " + speed.ToString();
        }
        // updating weapon
        private void LBWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            weapon = LBWeapon.SelectedItem.ToString();
            picWeapon.Image = Image.FromFile(weapon + ".png", true);

            lblDefence.Text = "Defence: " + defence.ToString();
            lblAttack.Text = "Attack: " + attack.ToString();
            lblSpeed.Text = "Speed: " + speed.ToString();
        }
        // bug fixing
        private void UI_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = false;
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }
        // more bug fixing
        private void btnInventory_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
        
        // more bug fixing
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            this.Focus();
        }

        // updating aftifacts
        private void LBArtifact1_SelectedIndexChanged(object sender, EventArgs e)
        {
            artifact1 = LBArtifact1.SelectedItem.ToString();
            picArtifact1.Image = Image.FromFile(artifact1 + ".png", true);

            lblDefence.Text = "Defence: " + defence.ToString();
            lblAttack.Text = "Attack: " + attack.ToString();
            lblSpeed.Text = "Speed: " + speed.ToString();
        }

        private void LBArtifact2_SelectedIndexChanged(object sender, EventArgs e)
        {
            artifact2 = LBArtifact2.SelectedItem.ToString();
            picArtifact2.Image = Image.FromFile(artifact2 + ".png", true);

            lblDefence.Text = "Defence: " + defence.ToString();
            lblAttack.Text = "Attack: " + attack.ToString();
            lblSpeed.Text = "Speed: " + speed.ToString();
        }

        private void lblMsg_Click(object sender, EventArgs e)
        {
           
        }
        // message label
        private void lblmsg_Click_1(object sender, EventArgs e)
        {
           lblmsg.Visible = false;
        }
        // shop code
        private void btnBuy_Click(object sender, EventArgs e)
        {
            if(cash >= 1000)
            {
                cash -= 1000;
                gain();
            }
            lblcash.Text = cash.ToString();
        }
        // combat code
        private void Battle(int enemy)
        {
            btnAttack.Visible = true;
            btnStop.Visible = false;

            battle.Visible = true;
            // setting enemy stats
            switch (enemy)
            {
                case 1:
                    Eattack = 30;
                    Eattacks = 3;
                    Edefence = 100;
                    Ehealth = 30;
                    Espeed = 150;
                    picEnemy.Image = Image.FromFile("Griffin.png", true);
                    break;
                case 2:
                    Eattack = 150;
                    Eattacks = 1;
                    Edefence = 150;
                    Ehealth = 60;
                    Espeed = 50;
                    picEnemy.Image = Image.FromFile("Cyclops.png", true);
                    break;
                case 3:
                    Eattack = 75;
                    Eattacks = 2;
                    Edefence = 100;
                    Ehealth = 50;
                    Espeed = 200;
                    picEnemy.Image = Image.FromFile("Centaur.png", true);
                    break;
                case 4:
                    Eattack = 200;
                    Eattacks = 1;
                    Edefence = 150;
                    Ehealth = 70;
                    Espeed = 200;
                    picEnemy.Image = Image.FromFile("minator.png", true);
                    break;
                case 5:
                    Eattack = 50;
                    Eattacks = 3;
                    Edefence = 75;
                    Ehealth = 100;
                    Espeed = 150;
                    picEnemy.Image = Image.FromFile("Cerberus.png", true);
                    break;
                case 6:
                    Eattack = 40;
                    Eattacks = 5;
                    Edefence = 75;
                    Ehealth = 130;
                    Espeed = 300;
                    picEnemy.Image = Image.FromFile("Typhon.png", true);
                    break;
                case 7:
                    Eattack = 60;
                    Eattacks = 4;
                    Edefence = 75;
                    Ehealth = 160;
                    Espeed =  150;
                    picEnemy.Image = Image.FromFile("Medusa.png", true);
                    break;
                case 8:
                    Eattack = 75;
                    Eattacks = 5;
                    Edefence = 75;
                    Ehealth = 200;
                    Espeed = 250;
                    picEnemy.Image = Image.FromFile("Hydra.png", true);
                    break;
                case 9:
                    Eattack = 75;
                    Eattacks = 5;
                    Edefence = 75;
                    Ehealth = 200;
                    Espeed = 250;
                    picEnemy.Image = Image.FromFile("Tartarus.png", true);
                    break;
                
            }
            enemyHealth.Value = 0;
            enemyHealth.Maximum = Ehealth;
            enemyHealth.Value = Ehealth;
            
        }
        // attacking
        private void Attack()
        {
            btnAttack.Visible = false;
            btnStop.Visible = true;
            lblAbar.Left = 0;
            AttackTimer.Enabled = true;
            
        }
        // defending
        private void defend()
        {
            btnAttack.Visible = false;
            btnStop.Visible = true;
            lblDbar.Left = 696;
            DefenceTimer.Enabled = true;

        }

        private void DefenceTimer_Tick(object sender, EventArgs e)
        {
            lblDbar.Left -= 10;
            if (lblDbar.Left <= 0)
            {
                if (lblDbar.Left > lblRbar.Left)
                {
                    negate = lblDbar.Left - lblRbar.Left;
                }
                else
                {
                    negate = lblRbar.Left - lblDbar.Left;
                }

                totalNegate = negate / Eattack;
                health -= totalNegate * 20;
                if (health <= 0)
                {
                    health = 0;
                    this.Close();
                }
                PlayerHP.Value = health;

                DefenceTimer.Enabled = false;
                btnAttack.Visible = true;
                btnStop.Visible = false;
            }
        }
        // more shop code
        private void btnFerryExit_Click(object sender, EventArgs e)
        {
            Ferry.Enabled = false;
            Ferry.Visible = false;
            ferry = false;
        }

        private void battle_Enter(object sender, EventArgs e)
        {

        }
        // freeing battle
        private void btnFlee_Click(object sender, EventArgs e)
        {
            battle.Visible = false;

        }
        // attack button
        private void btnAttack_Click(object sender, EventArgs e)
        {
            attacking = true;
            for (int i = 0; i < attacks; i++)
            {
                Attack();
            }
                
        }
        // attack timer
        private void AttackTimer_Tick(object sender, EventArgs e)
        {
            lblAbar.Left += 10;
            if(lblAbar.Left >= 696)
            {
               



                AttackTimer.Enabled = false;
                btnAttack.Visible = true;
                btnStop.Visible = false;
            }
        }
        // stop button
        private void btnStop_Click(object sender, EventArgs e)
        {
            // attacking turn
            if (attacking)
            {
                if (lblAbar.Left > lblRbar.Left)
                {
                    damage = lblAbar.Left - lblRbar.Left;
                }
                else
                {
                    damage = lblRbar.Left - lblAbar.Left;
                }
                totalDamage = attack / damage;
                Ehealth -= totalDamage;
                if (Ehealth <= 0)
                {
                    Ehealth = 0;
                    battle.Visible = false;
                    score += 100;
                    cash += 50;
                    lblscore.Text = score.ToString();
                    lblcash.Text = cash.ToString();
                }
                else
                {
                    attacking = false;
                    defend();
                }
            }
            // defeding turn
            else
            {
                if (lblDbar.Left > lblRbar.Left)
                {
                    negate = lblDbar.Left - lblRbar.Left;
                }
                else
                {
                    negate = lblRbar.Left - lblDbar.Left;
                }

                totalNegate = negate / Eattack;
                health -= totalNegate * 20;
                lblHealth.Text = "Health: "+health+"/100";
                if (health <= 0)
                {
                    health = 0;
                    this.Close();
                }
                PlayerHP.Value = health;
                

                DefenceTimer.Enabled = false;
                btnAttack.Visible = true;
                btnStop.Visible = false;

            }
            enemyHealth.Value = Ehealth;

            AttackTimer.Enabled = false;
            
            
        }
        // dev console
        private void btnDev_Click(object sender, EventArgs e)
        {
            
            consoleI = txtDev.Text;
            txtDev.Text = "";

            if (consoleI == "")
            {
                consoleI = "e";
            }

            if (consoleI[0] == 'g')
            {
                gain();
            }
            else if (consoleI[0] == 'p')
            {
                lblmsg.Text = "Hello World";
                lblmsg.Visible = true;
            }
            else if (consoleI[0] == 'm')
            {
                level += 5;
                lblmsg.Text = "Moved up 5 levels";
                lblmsg.Visible = true;
            }
            else
            {
                lblmsg.Text = "Not A valide command";
                lblmsg.Visible = true;
            }
        }
        // restart button
        private void btnRestart_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}
