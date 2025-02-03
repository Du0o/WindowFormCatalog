
namespace BasicAI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.picGreenB = new System.Windows.Forms.PictureBox();
            this.picGreenF = new System.Windows.Forms.PictureBox();
            this.picGreenR = new System.Windows.Forms.PictureBox();
            this.picGreenL = new System.Windows.Forms.PictureBox();
            this.picBlueR = new System.Windows.Forms.PictureBox();
            this.picBlueL = new System.Windows.Forms.PictureBox();
            this.picBlueF = new System.Windows.Forms.PictureBox();
            this.picBlueB = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.enemy = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.projectile = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).BeginInit();
            this.SuspendLayout();
            // 
            // picGreenB
            // 
            this.picGreenB.BackColor = System.Drawing.Color.Transparent;
            this.picGreenB.Image = ((System.Drawing.Image)(resources.GetObject("picGreenB.Image")));
            this.picGreenB.Location = new System.Drawing.Point(18, 370);
            this.picGreenB.Name = "picGreenB";
            this.picGreenB.Size = new System.Drawing.Size(104, 112);
            this.picGreenB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenB.TabIndex = 0;
            this.picGreenB.TabStop = false;
            this.picGreenB.Visible = false;
            // 
            // picGreenF
            // 
            this.picGreenF.BackColor = System.Drawing.Color.Transparent;
            this.picGreenF.Image = ((System.Drawing.Image)(resources.GetObject("picGreenF.Image")));
            this.picGreenF.Location = new System.Drawing.Point(12, 308);
            this.picGreenF.Name = "picGreenF";
            this.picGreenF.Size = new System.Drawing.Size(104, 112);
            this.picGreenF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenF.TabIndex = 1;
            this.picGreenF.TabStop = false;
            this.picGreenF.Visible = false;
            // 
            // picGreenR
            // 
            this.picGreenR.BackColor = System.Drawing.Color.Transparent;
            this.picGreenR.Image = ((System.Drawing.Image)(resources.GetObject("picGreenR.Image")));
            this.picGreenR.Location = new System.Drawing.Point(12, 252);
            this.picGreenR.Name = "picGreenR";
            this.picGreenR.Size = new System.Drawing.Size(104, 112);
            this.picGreenR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenR.TabIndex = 2;
            this.picGreenR.TabStop = false;
            this.picGreenR.Visible = false;
            // 
            // picGreenL
            // 
            this.picGreenL.BackColor = System.Drawing.Color.Transparent;
            this.picGreenL.Image = ((System.Drawing.Image)(resources.GetObject("picGreenL.Image")));
            this.picGreenL.Location = new System.Drawing.Point(18, 206);
            this.picGreenL.Name = "picGreenL";
            this.picGreenL.Size = new System.Drawing.Size(104, 112);
            this.picGreenL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGreenL.TabIndex = 3;
            this.picGreenL.TabStop = false;
            this.picGreenL.Visible = false;
            // 
            // picBlueR
            // 
            this.picBlueR.BackColor = System.Drawing.Color.Transparent;
            this.picBlueR.Image = ((System.Drawing.Image)(resources.GetObject("picBlueR.Image")));
            this.picBlueR.Location = new System.Drawing.Point(122, 207);
            this.picBlueR.Name = "picBlueR";
            this.picBlueR.Size = new System.Drawing.Size(104, 112);
            this.picBlueR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueR.TabIndex = 7;
            this.picBlueR.TabStop = false;
            this.picBlueR.Visible = false;
            // 
            // picBlueL
            // 
            this.picBlueL.BackColor = System.Drawing.Color.Transparent;
            this.picBlueL.Image = ((System.Drawing.Image)(resources.GetObject("picBlueL.Image")));
            this.picBlueL.Location = new System.Drawing.Point(122, 269);
            this.picBlueL.Name = "picBlueL";
            this.picBlueL.Size = new System.Drawing.Size(104, 112);
            this.picBlueL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueL.TabIndex = 6;
            this.picBlueL.TabStop = false;
            this.picBlueL.Visible = false;
            // 
            // picBlueF
            // 
            this.picBlueF.BackColor = System.Drawing.Color.Transparent;
            this.picBlueF.Image = ((System.Drawing.Image)(resources.GetObject("picBlueF.Image")));
            this.picBlueF.Location = new System.Drawing.Point(122, 325);
            this.picBlueF.Name = "picBlueF";
            this.picBlueF.Size = new System.Drawing.Size(104, 112);
            this.picBlueF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueF.TabIndex = 5;
            this.picBlueF.TabStop = false;
            this.picBlueF.Visible = false;
            // 
            // picBlueB
            // 
            this.picBlueB.BackColor = System.Drawing.Color.Transparent;
            this.picBlueB.Image = ((System.Drawing.Image)(resources.GetObject("picBlueB.Image")));
            this.picBlueB.Location = new System.Drawing.Point(128, 387);
            this.picBlueB.Name = "picBlueB";
            this.picBlueB.Size = new System.Drawing.Size(104, 112);
            this.picBlueB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBlueB.TabIndex = 4;
            this.picBlueB.TabStop = false;
            this.picBlueB.Visible = false;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = ((System.Drawing.Image)(resources.GetObject("Player.Image")));
            this.Player.Location = new System.Drawing.Point(100, 60);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(120, 120);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 8;
            this.Player.TabStop = false;
            // 
            // enemy
            // 
            this.enemy.BackColor = System.Drawing.Color.Transparent;
            this.enemy.Image = ((System.Drawing.Image)(resources.GetObject("enemy.Image")));
            this.enemy.Location = new System.Drawing.Point(710, 340);
            this.enemy.Name = "enemy";
            this.enemy.Size = new System.Drawing.Size(120, 120);
            this.enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy.TabIndex = 9;
            this.enemy.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.progressBar1.ForeColor = System.Drawing.Color.LightCoral;
            this.progressBar1.Location = new System.Drawing.Point(804, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(167, 23);
            this.progressBar1.TabIndex = 10;
            this.progressBar1.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "ur health";
            // 
            // lblGO
            // 
            this.lblGO.AutoSize = true;
            this.lblGO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGO.Location = new System.Drawing.Point(374, 280);
            this.lblGO.Name = "lblGO";
            this.lblGO.Size = new System.Drawing.Size(223, 39);
            this.lblGO.TabIndex = 12;
            this.lblGO.Text = "GAME OVER";
            this.lblGO.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(784, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 83);
            this.label2.TabIndex = 13;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(639, 22);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(150, 39);
            this.lblTime.TabIndex = 15;
            this.lblTime.Text = "ggggggg";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // projectile
            // 
            this.projectile.AutoSize = true;
            this.projectile.BackColor = System.Drawing.Color.Red;
            this.projectile.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.projectile.Location = new System.Drawing.Point(775, 10);
            this.projectile.Name = "projectile";
            this.projectile.Size = new System.Drawing.Size(14, 12);
            this.projectile.TabIndex = 16;
            this.projectile.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(825, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "ur score";
            // 
            // lblscore
            // 
            this.lblscore.AutoSize = true;
            this.lblscore.Location = new System.Drawing.Point(879, 60);
            this.lblscore.Name = "lblscore";
            this.lblscore.Size = new System.Drawing.Size(60, 17);
            this.lblscore.TabIndex = 18;
            this.lblscore.Text = "ur score";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.lblscore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.projectile);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblGO);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.enemy);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.picBlueR);
            this.Controls.Add(this.picBlueL);
            this.Controls.Add(this.picBlueF);
            this.Controls.Add(this.picBlueB);
            this.Controls.Add(this.picGreenL);
            this.Controls.Add(this.picGreenR);
            this.Controls.Add(this.picGreenF);
            this.Controls.Add(this.picGreenB);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "AI Chase";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown_1);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picGreenB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreenL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlueB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picGreenB;
        private System.Windows.Forms.PictureBox picGreenF;
        private System.Windows.Forms.PictureBox picGreenR;
        private System.Windows.Forms.PictureBox picGreenL;
        private System.Windows.Forms.PictureBox picBlueR;
        private System.Windows.Forms.PictureBox picBlueL;
        private System.Windows.Forms.PictureBox picBlueF;
        private System.Windows.Forms.PictureBox picBlueB;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox enemy;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label projectile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblscore;
    }
}

