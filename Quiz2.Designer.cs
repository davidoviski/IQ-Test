﻿namespace VPP
{
    partial class Quiz2
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
            this.Q2lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Q2lblQuestion
            // 
            this.Q2lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q2lblQuestion.Location = new System.Drawing.Point(68, 230);
            this.Q2lblQuestion.Name = "Q2lblQuestion";
            this.Q2lblQuestion.Size = new System.Drawing.Size(672, 61);
            this.Q2lblQuestion.TabIndex = 1;
            this.Q2lblQuestion.Text = "label1";
            this.Q2lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 75);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.eventCheckAwnsers);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 75);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.eventCheckAwnsers);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(59, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 75);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.eventCheckAwnsers);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 373);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 75);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.eventCheckAwnsers);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VPP.Properties.Resources.brasilll;
            this.pictureBox1.Location = new System.Drawing.Point(170, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(451, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Quiz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Q2lblQuestion);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Quiz2";
            this.Text = "Quiz2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Q2lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}