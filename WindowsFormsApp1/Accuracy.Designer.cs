namespace WindowsFormsApp1
{
    partial class Accuracy
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Timer(this.components);
            this.Game_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.GlobalVarTest = new System.Windows.Forms.TextBox();
            this.AlienTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Peru;
            this.panel1.Location = new System.Drawing.Point(10, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Close
            // 
            this.Close.Enabled = true;
            this.Close.Interval = 10000;
            this.Close.Tick += new System.EventHandler(this.Close_Tick);
            // 
            // Game_Timer
            // 
            this.Game_Timer.Enabled = true;
            this.Game_Timer.Interval = 10;
            this.Game_Timer.Tick += new System.EventHandler(this.Game_Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil Std", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Accuracy";
            // 
            // GlobalVarTest
            // 
            this.GlobalVarTest.Enabled = false;
            this.GlobalVarTest.Location = new System.Drawing.Point(343, 12);
            this.GlobalVarTest.Name = "GlobalVarTest";
            this.GlobalVarTest.Size = new System.Drawing.Size(100, 20);
            this.GlobalVarTest.TabIndex = 2;
            // 
            // AlienTimer
            // 
            this.AlienTimer.Enabled = true;
            this.AlienTimer.Interval = 500;
            this.AlienTimer.Tick += new System.EventHandler(this.AlienTimer_Tick);
            // 
            // Accuracy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.GlobalVarTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Accuracy";
            this.Text = "Accuracy";
            this.Load += new System.EventHandler(this.Accuracy_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Accuracy_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Accuracy_MouseDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer Close;
        private System.Windows.Forms.Timer Game_Timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GlobalVarTest;
        private System.Windows.Forms.Timer AlienTimer;
    }
}