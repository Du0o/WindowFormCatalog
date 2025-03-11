
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
            this.Flower = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Hive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).BeginInit();
            this.SuspendLayout();
            // 
            // Hive
            // 
            this.Hive.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Hive, "Hive");
            this.Hive.Name = "Hive";
            this.Hive.TabStop = false;
            // 
            // Flower
            // 
            this.Flower.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.Flower, "Flower");
            this.Flower.Name = "Flower";
            this.Flower.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.Controls.Add(this.Flower);
            this.Controls.Add(this.Hive);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Hive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Flower)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Hive;
        private System.Windows.Forms.PictureBox Flower;
        private System.Windows.Forms.Timer timer1;
    }
}

