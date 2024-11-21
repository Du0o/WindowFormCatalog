
namespace Mailing_Label
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtSA = new System.Windows.Forms.TextBox();
            this.txtcity = new System.Windows.Forms.TextBox();
            this.txtstate = new System.Windows.Forms.TextBox();
            this.txtzip = new System.Windows.Forms.TextBox();
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnmakelabel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btncolor = new System.Windows.Forms.Button();
            this.btnfont = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblnum = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(36, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(36, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(36, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Street Adress";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(36, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "City";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(36, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "State";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(36, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Zip Code";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(129, 37);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(135, 20);
            this.txtfname.TabIndex = 6;
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(114, 57);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(150, 20);
            this.txtlname.TabIndex = 7;
            // 
            // txtSA
            // 
            this.txtSA.Location = new System.Drawing.Point(128, 77);
            this.txtSA.Name = "txtSA";
            this.txtSA.Size = new System.Drawing.Size(136, 20);
            this.txtSA.TabIndex = 8;
            this.txtSA.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(82, 97);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(182, 20);
            this.txtcity.TabIndex = 9;
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(82, 117);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(182, 20);
            this.txtstate.TabIndex = 10;
            this.txtstate.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtzip
            // 
            this.txtzip.Location = new System.Drawing.Point(114, 137);
            this.txtzip.Name = "txtzip";
            this.txtzip.Size = new System.Drawing.Size(150, 20);
            this.txtzip.TabIndex = 11;
            // 
            // lblmessage
            // 
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.Image = ((System.Drawing.Image)(resources.GetObject("lblmessage.Image")));
            this.lblmessage.Location = new System.Drawing.Point(269, 64);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(512, 266);
            this.lblmessage.TabIndex = 13;
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblmessage.Click += new System.EventHandler(this.lblmessage_Click);
            // 
            // btnmakelabel
            // 
            this.btnmakelabel.BackColor = System.Drawing.Color.Aqua;
            this.btnmakelabel.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmakelabel.Location = new System.Drawing.Point(36, 160);
            this.btnmakelabel.Name = "btnmakelabel";
            this.btnmakelabel.Size = new System.Drawing.Size(226, 55);
            this.btnmakelabel.TabIndex = 14;
            this.btnmakelabel.Text = "Make Label";
            this.btnmakelabel.UseVisualStyleBackColor = false;
            this.btnmakelabel.Click += new System.EventHandler(this.btnmakelabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(702, 72);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btncolor
            // 
            this.btncolor.BackColor = System.Drawing.Color.Aqua;
            this.btncolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncolor.Location = new System.Drawing.Point(530, 11);
            this.btncolor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncolor.Name = "btncolor";
            this.btncolor.Size = new System.Drawing.Size(123, 44);
            this.btncolor.TabIndex = 16;
            this.btncolor.Text = "COLOR";
            this.btncolor.UseVisualStyleBackColor = false;
            this.btncolor.Click += new System.EventHandler(this.btncolor_Click);
            // 
            // btnfont
            // 
            this.btnfont.BackColor = System.Drawing.Color.Aqua;
            this.btnfont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfont.Location = new System.Drawing.Point(657, 13);
            this.btnfont.Margin = new System.Windows.Forms.Padding(2);
            this.btnfont.Name = "btnfont";
            this.btnfont.Size = new System.Drawing.Size(123, 44);
            this.btnfont.TabIndex = 17;
            this.btnfont.Text = "FONT";
            this.btnfont.UseVisualStyleBackColor = false;
            this.btnfont.Click += new System.EventHandler(this.btnfont_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Aqua;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.Location = new System.Drawing.Point(11, 329);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(123, 44);
            this.btnclear.TabIndex = 19;
            this.btnclear.Text = "CLEAR";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(36, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Labels Made";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnum
            // 
            this.lblnum.Location = new System.Drawing.Point(114, 220);
            this.lblnum.Name = "lblnum";
            this.lblnum.Size = new System.Drawing.Size(51, 17);
            this.lblnum.TabIndex = 21;
            this.lblnum.Text = "0";
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(138, 329);
            this.btnexit.Margin = new System.Windows.Forms.Padding(2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(123, 44);
            this.btnexit.TabIndex = 22;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(790, 384);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.lblnum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnfont);
            this.Controls.Add(this.btncolor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnmakelabel);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.txtzip);
            this.Controls.Add(this.txtstate);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.txtSA);
            this.Controls.Add(this.txtlname);
            this.Controls.Add(this.txtfname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtSA;
        private System.Windows.Forms.TextBox txtcity;
        private System.Windows.Forms.TextBox txtstate;
        private System.Windows.Forms.TextBox txtzip;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnmakelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btncolor;
        private System.Windows.Forms.Button btnfont;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblnum;
        private System.Windows.Forms.Button btnexit;
    }
}

