namespace WindowsFormsApp1
{
    partial class frmScores
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.PlyrNme = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.PlyrScre = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SCORE";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(237, 265);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(116, 23);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return to Game";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // PlyrNme
            // 
            this.PlyrNme.AutoSize = true;
            this.PlyrNme.Location = new System.Drawing.Point(45, 253);
            this.PlyrNme.Name = "PlyrNme";
            this.PlyrNme.Size = new System.Drawing.Size(67, 13);
            this.PlyrNme.TabIndex = 3;
            this.PlyrNme.Text = "Player Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(116, 252);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerName.TabIndex = 4;
            this.lblPlayerName.Text = "Name";
            // 
            // PlyrScre
            // 
            this.PlyrScre.AutoSize = true;
            this.PlyrScre.Location = new System.Drawing.Point(45, 289);
            this.PlyrScre.Name = "PlyrScre";
            this.PlyrScre.Size = new System.Drawing.Size(67, 13);
            this.PlyrScre.TabIndex = 5;
            this.PlyrScre.Text = "Player Score";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Location = new System.Drawing.Point(120, 289);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(35, 13);
            this.lblPlayerScore.TabIndex = 6;
            this.lblPlayerScore.Text = "Score";
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(80, 343);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 7;
            // 
            // frmScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 411);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.PlyrScre);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.PlyrNme);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmScores";
            this.Text = "frmScores";
            this.Load += new System.EventHandler(this.frmScores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label PlyrNme;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label PlyrScre;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblMessage;
    }
}