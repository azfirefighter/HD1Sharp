﻿namespace hd1sharp.Resources
{
    partial class PowerOnLogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PowerOnLogo));
            this.PowerOnLogoPicture = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.PowerOnProgressBar = new System.Windows.Forms.ProgressBar();
            this.percent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PowerOnLogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PowerOnLogoPicture
            // 
            this.PowerOnLogoPicture.Image = ((System.Drawing.Image)(resources.GetObject("PowerOnLogoPicture.Image")));
            this.PowerOnLogoPicture.Location = new System.Drawing.Point(24, 28);
            this.PowerOnLogoPicture.Name = "PowerOnLogoPicture";
            this.PowerOnLogoPicture.Size = new System.Drawing.Size(160, 128);
            this.PowerOnLogoPicture.TabIndex = 0;
            this.PowerOnLogoPicture.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PowerOnLogoOpen_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 2;
            this.button2.Text = "Read";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ReadPowerOnLogo);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 27);
            this.button3.TabIndex = 3;
            this.button3.Text = "Write";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PowerOnLogoWrite);
            // 
            // PowerOnProgressBar
            // 
            this.PowerOnProgressBar.Location = new System.Drawing.Point(24, 200);
            this.PowerOnProgressBar.Name = "PowerOnProgressBar";
            this.PowerOnProgressBar.Size = new System.Drawing.Size(284, 27);
            this.PowerOnProgressBar.TabIndex = 4;
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(99, 230);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(159, 15);
            this.percent.TabIndex = 5;
            this.percent.Text = "Completion percentage {0}%";
            // 
            // PowerOnLogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 257);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.PowerOnProgressBar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PowerOnLogoPicture);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PowerOnLogo";
            this.Text = "PowerOnLogo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PowerOnLogo_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.PowerOnLogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PowerOnLogoPicture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ProgressBar PowerOnProgressBar;
        private System.Windows.Forms.Label percent;
    }
}