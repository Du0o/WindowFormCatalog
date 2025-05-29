
namespace FinalProject
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblHTP = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblHTP
            // 
            this.lblHTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHTP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHTP.Location = new System.Drawing.Point(30, 80);
            this.lblHTP.Name = "lblHTP";
            this.lblHTP.Size = new System.Drawing.Size(728, 256);
            this.lblHTP.TabIndex = 0;
            this.lblHTP.Text = resources.GetString("lblHTP.Text");
            this.lblHTP.Click += new System.EventHandler(this.lblHTP_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(530, 176);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(228, 94);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(728, 58);
            this.label1.TabIndex = 2;
            this.label1.Text = " Inferno Decursio";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(797, 285);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblHTP);
            this.Name = "Form2";
            this.Text = "How To Play";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHTP;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
    }
}