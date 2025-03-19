
namespace Bees
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
            this.Hive = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Flower2 = new System.Windows.Forms.PictureBox();
            this.Flower3 = new System.Windows.Forms.PictureBox();
            this.Flower1 = new System.Windows.Forms.PictureBox();
            this.NECTAR = new System.Windows.Forms.Label();
            this.lblnectar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Hive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower1)).BeginInit();
            this.SuspendLayout();
            // 
            // Hive
            // 
            this.Hive.BackColor = System.Drawing.Color.Transparent;
            this.Hive.Image = ((System.Drawing.Image)(resources.GetObject("Hive.Image")));
            this.Hive.Location = new System.Drawing.Point(-17, 119);
            this.Hive.Margin = new System.Windows.Forms.Padding(2);
            this.Hive.Name = "Hive";
            this.Hive.Size = new System.Drawing.Size(220, 254);
            this.Hive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Hive.TabIndex = 0;
            this.Hive.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Flower2
            // 
            this.Flower2.BackColor = System.Drawing.Color.Transparent;
            this.Flower2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Flower2.Location = new System.Drawing.Point(467, 256);
            this.Flower2.Margin = new System.Windows.Forms.Padding(2);
            this.Flower2.Name = "Flower2";
            this.Flower2.Size = new System.Drawing.Size(106, 188);
            this.Flower2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flower2.TabIndex = 2;
            this.Flower2.TabStop = false;
            // 
            // Flower3
            // 
            this.Flower3.BackColor = System.Drawing.Color.Transparent;
            this.Flower3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Flower3.Location = new System.Drawing.Point(589, 256);
            this.Flower3.Margin = new System.Windows.Forms.Padding(2);
            this.Flower3.Name = "Flower3";
            this.Flower3.Size = new System.Drawing.Size(106, 188);
            this.Flower3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flower3.TabIndex = 3;
            this.Flower3.TabStop = false;
            this.Flower3.Tag = "";
            // 
            // Flower1
            // 
            this.Flower1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Flower1.BackColor = System.Drawing.Color.Transparent;
            this.Flower1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Flower1.Location = new System.Drawing.Point(348, 256);
            this.Flower1.Margin = new System.Windows.Forms.Padding(2);
            this.Flower1.Name = "Flower1";
            this.Flower1.Size = new System.Drawing.Size(106, 188);
            this.Flower1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Flower1.TabIndex = 4;
            this.Flower1.TabStop = false;
            // 
            // NECTAR
            // 
            this.NECTAR.Location = new System.Drawing.Point(1, 0);
            this.NECTAR.Name = "NECTAR";
            this.NECTAR.Size = new System.Drawing.Size(56, 17);
            this.NECTAR.TabIndex = 5;
            this.NECTAR.Text = "NECTAR";
            // 
            // lblnectar
            // 
            this.lblnectar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblnectar.Location = new System.Drawing.Point(53, 0);
            this.lblnectar.Name = "lblnectar";
            this.lblnectar.Size = new System.Drawing.Size(56, 17);
            this.lblnectar.TabIndex = 6;
            this.lblnectar.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(730, 441);
            this.Controls.Add(this.lblnectar);
            this.Controls.Add(this.NECTAR);
            this.Controls.Add(this.Flower1);
            this.Controls.Add(this.Flower3);
            this.Controls.Add(this.Flower2);
            this.Controls.Add(this.Hive);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Bee Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Hive;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.PictureBox Flower2;
        private System.Windows.Forms.PictureBox Flower3;
        private System.Windows.Forms.PictureBox Flower1;
        private System.Windows.Forms.Label NECTAR;
        private System.Windows.Forms.Label lblnectar;
    }
}

