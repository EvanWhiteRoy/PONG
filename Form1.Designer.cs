namespace PONG
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
            this.p1scorelabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // p1scorelabel
            // 
            this.p1scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scorelabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p1scorelabel.Location = new System.Drawing.Point(76, 32);
            this.p1scorelabel.Name = "p1scorelabel";
            this.p1scorelabel.Size = new System.Drawing.Size(100, 23);
            this.p1scorelabel.TabIndex = 0;
            this.p1scorelabel.Text = "0";
            this.p1scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // winnerLabel
            // 
            this.winnerLabel.BackColor = System.Drawing.Color.Transparent;
            this.winnerLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winnerLabel.Location = new System.Drawing.Point(232, 229);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(132, 44);
            this.winnerLabel.TabIndex = 1;
            this.winnerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.p2scoreLabel.Location = new System.Drawing.Point(399, 32);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.p2scoreLabel.TabIndex = 2;
            this.p2scoreLabel.Text = "0";
            this.p2scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.winnerLabel);
            this.Controls.Add(this.p1scorelabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1scorelabel;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
    }
}

