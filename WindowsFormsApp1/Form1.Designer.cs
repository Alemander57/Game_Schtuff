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
            this.GridReset = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XPosBox = new System.Windows.Forms.TextBox();
            this.YPosBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 10;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // GridReset
            // 
            this.GridReset.Interval = 10;
            this.GridReset.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(296, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "XPosition";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YPosition";
            // 
            // XPosBox
            // 
            this.XPosBox.Enabled = false;
            this.XPosBox.Location = new System.Drawing.Point(265, 29);
            this.XPosBox.Name = "XPosBox";
            this.XPosBox.Size = new System.Drawing.Size(100, 20);
            this.XPosBox.TabIndex = 2;
            this.XPosBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // YPosBox
            // 
            this.YPosBox.Enabled = false;
            this.YPosBox.Location = new System.Drawing.Point(388, 29);
            this.YPosBox.Name = "YPosBox";
            this.YPosBox.Size = new System.Drawing.Size(100, 20);
            this.YPosBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.YPosBox);
            this.Controls.Add(this.XPosBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.Timer GridReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XPosBox;
        private System.Windows.Forms.TextBox YPosBox;
    }
}

