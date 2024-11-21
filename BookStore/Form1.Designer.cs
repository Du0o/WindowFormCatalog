
namespace BookStore
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttitle = new System.Windows.Forms.TextBox();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.txtquan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblextpri = new System.Windows.Forms.Label();
            this.lbldisamo = new System.Windows.Forms.Label();
            this.lbldispri = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.lblavargesa = new System.Windows.Forms.Label();
            this.lbltotalsa = new System.Windows.Forms.Label();
            this.lbltotalpe = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 85);
            this.label2.TabIndex = 1;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 85);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quanity";
            // 
            // txttitle
            // 
            this.txttitle.Location = new System.Drawing.Point(138, 37);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(154, 23);
            this.txttitle.TabIndex = 3;
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(138, 107);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(154, 23);
            this.txtprice.TabIndex = 4;
            // 
            // txtquan
            // 
            this.txtquan.Location = new System.Drawing.Point(193, 162);
            this.txtquan.Name = "txtquan";
            this.txtquan.Size = new System.Drawing.Size(154, 23);
            this.txtquan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Turquoise;
            this.label4.Location = new System.Drawing.Point(-2, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1009, 8);
            this.label4.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 85);
            this.label5.TabIndex = 7;
            this.label5.Text = "Extended Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(323, 85);
            this.label6.TabIndex = 8;
            this.label6.Text = "Discount Amount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(275, 85);
            this.label7.TabIndex = 9;
            this.label7.Text = "Discount Price";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblextpri
            // 
            this.lblextpri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblextpri.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblextpri.Location = new System.Drawing.Point(323, 209);
            this.lblextpri.Name = "lblextpri";
            this.lblextpri.Size = new System.Drawing.Size(275, 34);
            this.lblextpri.TabIndex = 10;
            this.lblextpri.Click += new System.EventHandler(this.lblextpri_Click);
            // 
            // lbldisamo
            // 
            this.lbldisamo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldisamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisamo.Location = new System.Drawing.Point(353, 247);
            this.lbldisamo.Name = "lbldisamo";
            this.lbldisamo.Size = new System.Drawing.Size(275, 34);
            this.lbldisamo.TabIndex = 11;
            this.lbldisamo.Click += new System.EventHandler(this.lbldisamo_Click);
            // 
            // lbldispri
            // 
            this.lbldispri.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbldispri.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldispri.Location = new System.Drawing.Point(294, 296);
            this.lbldispri.Name = "lbldispri";
            this.lbldispri.Size = new System.Drawing.Size(275, 34);
            this.lbldispri.TabIndex = 12;
            this.lbldispri.Click += new System.EventHandler(this.lbldispri_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncalculate.Location = new System.Drawing.Point(749, 137);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(231, 46);
            this.btncalculate.TabIndex = 13;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // lblavargesa
            // 
            this.lblavargesa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblavargesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblavargesa.Location = new System.Drawing.Point(583, 451);
            this.lblavargesa.Name = "lblavargesa";
            this.lblavargesa.Size = new System.Drawing.Size(275, 34);
            this.lblavargesa.TabIndex = 19;
            // 
            // lbltotalsa
            // 
            this.lbltotalsa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotalsa.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalsa.Location = new System.Drawing.Point(535, 406);
            this.lbltotalsa.Name = "lbltotalsa";
            this.lbltotalsa.Size = new System.Drawing.Size(275, 34);
            this.lbltotalsa.TabIndex = 18;
            // 
            // lbltotalpe
            // 
            this.lbltotalpe.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbltotalpe.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalpe.Location = new System.Drawing.Point(550, 366);
            this.lbltotalpe.Name = "lbltotalpe";
            this.lbltotalpe.Size = new System.Drawing.Size(275, 34);
            this.lbltotalpe.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(313, 447);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(275, 85);
            this.label11.TabIndex = 16;
            this.label11.Text = "Avarege Sale";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(313, 400);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 85);
            this.label12.TabIndex = 15;
            this.label12.Text = "Total Sales";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(315, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(291, 85);
            this.label13.TabIndex = 14;
            this.label13.Text = "Total people";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1000, 499);
            this.Controls.Add(this.lblavargesa);
            this.Controls.Add(this.lbltotalsa);
            this.Controls.Add(this.lbltotalpe);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.lbldispri);
            this.Controls.Add(this.lbldisamo);
            this.Controls.Add(this.lblextpri);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtquan);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Book Store";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttitle;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.TextBox txtquan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblextpri;
        private System.Windows.Forms.Label lbldisamo;
        private System.Windows.Forms.Label lbldispri;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Label lblavargesa;
        private System.Windows.Forms.Label lbltotalsa;
        private System.Windows.Forms.Label lbltotalpe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

