
namespace BMI
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
            this.txtpounds = new System.Windows.Forms.TextBox();
            this.txtinches = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbmi = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblavarage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblbmiscalculated = new System.Windows.Forms.Label();
            this.btncalculate = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtfeet = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(-1, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1065, 5);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(4, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1048, 73);
            this.label2.TabIndex = 1;
            this.label2.Text = "BMI Calculator";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(150, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight(in pounds)";
            // 
            // txtpounds
            // 
            this.txtpounds.Location = new System.Drawing.Point(150, 206);
            this.txtpounds.Name = "txtpounds";
            this.txtpounds.Size = new System.Drawing.Size(130, 22);
            this.txtpounds.TabIndex = 3;
            // 
            // txtinches
            // 
            this.txtinches.Location = new System.Drawing.Point(14, 206);
            this.txtinches.Name = "txtinches";
            this.txtinches.Size = new System.Drawing.Size(130, 22);
            this.txtinches.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(14, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Height(in inches)";
            // 
            // lblbmi
            // 
            this.lblbmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbmi.Location = new System.Drawing.Point(321, 331);
            this.lblbmi.Name = "lblbmi";
            this.lblbmi.Size = new System.Drawing.Size(192, 42);
            this.lblbmi.TabIndex = 6;
            this.lblbmi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(321, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 21);
            this.label5.TabIndex = 7;
            this.label5.Text = "BMI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(532, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "avarage BMI";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblavarage
            // 
            this.lblavarage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblavarage.Location = new System.Drawing.Point(532, 331);
            this.lblavarage.Name = "lblavarage";
            this.lblavarage.Size = new System.Drawing.Size(192, 42);
            this.lblavarage.TabIndex = 8;
            this.lblavarage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(321, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 21);
            this.label7.TabIndex = 11;
            this.label7.Text = "BMI\'s calculated";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblbmiscalculated
            // 
            this.lblbmiscalculated.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbmiscalculated.Location = new System.Drawing.Point(321, 415);
            this.lblbmiscalculated.Name = "lblbmiscalculated";
            this.lblbmiscalculated.Size = new System.Drawing.Size(192, 42);
            this.lblbmiscalculated.TabIndex = 10;
            this.lblbmiscalculated.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblbmiscalculated.Click += new System.EventHandler(this.lblbmiscalculated_Click);
            // 
            // btncalculate
            // 
            this.btncalculate.BackColor = System.Drawing.Color.YellowGreen;
            this.btncalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btncalculate.Location = new System.Drawing.Point(28, 339);
            this.btncalculate.Name = "btncalculate";
            this.btncalculate.Size = new System.Drawing.Size(213, 76);
            this.btncalculate.TabIndex = 12;
            this.btncalculate.Text = "Calculate";
            this.btncalculate.UseVisualStyleBackColor = false;
            this.btncalculate.Click += new System.EventHandler(this.btncalculate_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnexit.Location = new System.Drawing.Point(578, 429);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(213, 76);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(312, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(479, 214);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // txtfeet
            // 
            this.txtfeet.Location = new System.Drawing.Point(14, 256);
            this.txtfeet.Name = "txtfeet";
            this.txtfeet.Size = new System.Drawing.Size(130, 22);
            this.txtfeet.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Location = new System.Drawing.Point(14, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Height(in feet)";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.OliveDrab;
            this.label9.Location = new System.Drawing.Point(296, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(5, 682);
            this.label9.TabIndex = 17;
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.YellowGreen;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnclear.Location = new System.Drawing.Point(28, 431);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(213, 76);
            this.btnclear.TabIndex = 18;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtfeet);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btncalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblbmiscalculated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblavarage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblbmi);
            this.Controls.Add(this.txtinches);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "BMI Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtpounds;
        private System.Windows.Forms.TextBox txtinches;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbmi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblavarage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblbmiscalculated;
        private System.Windows.Forms.Button btncalculate;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtfeet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnclear;
    }
}

