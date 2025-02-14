
namespace Star_Field
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
            this.star1 = new System.Windows.Forms.Label();
            this.star2 = new System.Windows.Forms.Label();
            this.star3 = new System.Windows.Forms.Label();
            this.star4 = new System.Windows.Forms.Label();
            this.star5 = new System.Windows.Forms.Label();
            this.star6 = new System.Windows.Forms.Label();
            this.star7 = new System.Windows.Forms.Label();
            this.star8 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // star1
            // 
            this.star1.BackColor = System.Drawing.SystemColors.Info;
            this.star1.Location = new System.Drawing.Point(103, 97);
            this.star1.Name = "star1";
            this.star1.Size = new System.Drawing.Size(67, 73);
            this.star1.TabIndex = 0;
            // 
            // star2
            // 
            this.star2.BackColor = System.Drawing.SystemColors.Info;
            this.star2.Location = new System.Drawing.Point(221, 97);
            this.star2.Name = "star2";
            this.star2.Size = new System.Drawing.Size(67, 73);
            this.star2.TabIndex = 1;
            // 
            // star3
            // 
            this.star3.BackColor = System.Drawing.SystemColors.Info;
            this.star3.Location = new System.Drawing.Point(353, 97);
            this.star3.Name = "star3";
            this.star3.Size = new System.Drawing.Size(67, 73);
            this.star3.TabIndex = 2;
            // 
            // star4
            // 
            this.star4.BackColor = System.Drawing.SystemColors.Info;
            this.star4.Location = new System.Drawing.Point(103, 224);
            this.star4.Name = "star4";
            this.star4.Size = new System.Drawing.Size(67, 73);
            this.star4.TabIndex = 3;
            // 
            // star5
            // 
            this.star5.BackColor = System.Drawing.SystemColors.Info;
            this.star5.Location = new System.Drawing.Point(221, 224);
            this.star5.Name = "star5";
            this.star5.Size = new System.Drawing.Size(67, 73);
            this.star5.TabIndex = 4;
            // 
            // star6
            // 
            this.star6.BackColor = System.Drawing.SystemColors.Info;
            this.star6.Location = new System.Drawing.Point(353, 233);
            this.star6.Name = "star6";
            this.star6.Size = new System.Drawing.Size(67, 73);
            this.star6.TabIndex = 5;
            // 
            // star7
            // 
            this.star7.BackColor = System.Drawing.SystemColors.Info;
            this.star7.Location = new System.Drawing.Point(103, 341);
            this.star7.Name = "star7";
            this.star7.Size = new System.Drawing.Size(67, 73);
            this.star7.TabIndex = 6;
            // 
            // star8
            // 
            this.star8.BackColor = System.Drawing.SystemColors.Info;
            this.star8.Location = new System.Drawing.Point(221, 341);
            this.star8.Name = "star8";
            this.star8.Size = new System.Drawing.Size(67, 73);
            this.star8.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(890, 538);
            this.Controls.Add(this.star8);
            this.Controls.Add(this.star7);
            this.Controls.Add(this.star6);
            this.Controls.Add(this.star5);
            this.Controls.Add(this.star4);
            this.Controls.Add(this.star3);
            this.Controls.Add(this.star2);
            this.Controls.Add(this.star1);
            this.Name = "Form1";
            this.Text = "Star Field";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label star1;
        private System.Windows.Forms.Label star2;
        private System.Windows.Forms.Label star3;
        private System.Windows.Forms.Label star4;
        private System.Windows.Forms.Label star5;
        private System.Windows.Forms.Label star6;
        private System.Windows.Forms.Label star7;
        private System.Windows.Forms.Label star8;
        private System.Windows.Forms.Timer timer1;
    }
}

