﻿namespace VPP
{
    partial class Quiz3
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
            this.Q3lblQuestion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Q3lblask = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Q3lblQuestion
            // 
            this.Q3lblQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3lblQuestion.Location = new System.Drawing.Point(54, 55);
            this.Q3lblQuestion.Name = "Q3lblQuestion";
            this.Q3lblQuestion.Size = new System.Drawing.Size(672, 61);
            this.Q3lblQuestion.TabIndex = 2;
            this.Q3lblQuestion.Text = "label1";
            this.Q3lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Q3lblQuestion.Click += new System.EventHandler(this.checkAnwsersEvent);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(59, 282);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 75);
            this.button1.TabIndex = 3;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnwsersEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(59, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(262, 75);
            this.button2.TabIndex = 4;
            this.button2.Tag = "1";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnwsersEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(262, 75);
            this.button3.TabIndex = 5;
            this.button3.Tag = "1";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnwsersEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(464, 363);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 75);
            this.button4.TabIndex = 6;
            this.button4.Tag = "1";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnwsersEvent);
            // 
            // Q3lblask
            // 
            this.Q3lblask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Q3lblask.Location = new System.Drawing.Point(54, 158);
            this.Q3lblask.Name = "Q3lblask";
            this.Q3lblask.Size = new System.Drawing.Size(672, 61);
            this.Q3lblask.TabIndex = 7;
            this.Q3lblask.Text = "label1";
            this.Q3lblask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Q3lblask);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Q3lblQuestion);
            this.Name = "Quiz3";
            this.Text = "Quiz3";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Q3lblQuestion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Q3lblask;
    }
}