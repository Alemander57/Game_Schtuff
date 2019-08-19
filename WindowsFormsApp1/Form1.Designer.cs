﻿namespace WindowsFormsApp1
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
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MoveAnimation = new System.Windows.Forms.Timer(this.components);
            this.DID = new System.Windows.Forms.Timer(this.components);
            this.HP = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AScore = new System.Windows.Forms.Label();
            this.AAScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 20;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MoveAnimation
            // 
            this.MoveAnimation.Interval = 20;
            this.MoveAnimation.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DID
            // 
            this.DID.Interval = 1;
            this.DID.Tick += new System.EventHandler(this.DID_Tick);
            // 
            // HP
            // 
            this.HP.AutoSize = true;
            this.HP.Location = new System.Drawing.Point(560, 30);
            this.HP.Name = "HP";
            this.HP.Size = new System.Drawing.Size(19, 13);
            this.HP.TabIndex = 6;
            this.HP.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "/10";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(570, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "HP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(563, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score";
            // 
            // AScore
            // 
            this.AScore.AutoSize = true;
            this.AScore.Location = new System.Drawing.Point(573, 109);
            this.AScore.Name = "AScore";
            this.AScore.Size = new System.Drawing.Size(0, 13);
            this.AScore.TabIndex = 10;
            // 
            // AAScore
            // 
            this.AAScore.AutoSize = true;
            this.AAScore.Location = new System.Drawing.Point(573, 95);
            this.AAScore.Name = "AAScore";
            this.AAScore.Size = new System.Drawing.Size(13, 13);
            this.AAScore.TabIndex = 11;
            this.AAScore.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(515, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Click to move to \r\nBlue Highlighted Spaces";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Press Z to activate\r\nshoot mode\r\nBe ready for a minigame!\r\n";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(525, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Press X to cancel \r\nshoot mode";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AAScore);
            this.Controls.Add(this.AScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HP);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer MoveAnimation;
        public System.Windows.Forms.Timer DID;
        private System.Windows.Forms.Label HP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AScore;
        private System.Windows.Forms.Label AAScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

