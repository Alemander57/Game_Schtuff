namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.XPosBox = new System.Windows.Forms.TextBox();
            this.YPosBox = new System.Windows.Forms.TextBox();
            this.EnemyX = new System.Windows.Forms.Label();
            this.EnXDisp = new System.Windows.Forms.TextBox();
            this.DID = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
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
            this.label2.Location = new System.Drawing.Point(350, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "YPosition";
            // 
            // XPosBox
            // 
            this.XPosBox.Enabled = false;
            this.XPosBox.Location = new System.Drawing.Point(308, 30);
            this.XPosBox.Name = "XPosBox";
            this.XPosBox.Size = new System.Drawing.Size(24, 20);
            this.XPosBox.TabIndex = 2;
            this.XPosBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // YPosBox
            // 
            this.YPosBox.Enabled = false;
            this.YPosBox.Location = new System.Drawing.Point(364, 30);
            this.YPosBox.Name = "YPosBox";
            this.YPosBox.Size = new System.Drawing.Size(24, 20);
            this.YPosBox.TabIndex = 3;
            // 
            // EnemyX
            // 
            this.EnemyX.AutoSize = true;
            this.EnemyX.Location = new System.Drawing.Point(406, 13);
            this.EnemyX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.EnemyX.Name = "EnemyX";
            this.EnemyX.Size = new System.Drawing.Size(46, 13);
            this.EnemyX.TabIndex = 4;
            this.EnemyX.Text = "EnemyX";
            this.EnemyX.Click += new System.EventHandler(this.label3_Click);
            // 
            // EnXDisp
            // 
            this.EnXDisp.Enabled = false;
            this.EnXDisp.Location = new System.Drawing.Point(408, 30);
            this.EnXDisp.Margin = new System.Windows.Forms.Padding(2);
            this.EnXDisp.Name = "EnXDisp";
            this.EnXDisp.Size = new System.Drawing.Size(84, 20);
            this.EnXDisp.TabIndex = 5;
            // 
            // DID
            // 
            this.DID.Interval = 1;
            this.DID.Tick += new System.EventHandler(this.DID_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(569, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "10/10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 500);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EnXDisp);
            this.Controls.Add(this.EnemyX);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox XPosBox;
        private System.Windows.Forms.TextBox YPosBox;
        private System.Windows.Forms.Label EnemyX;
        private System.Windows.Forms.TextBox EnXDisp;
        public System.Windows.Forms.Timer DID;
        private System.Windows.Forms.Label label3;
    }
}

