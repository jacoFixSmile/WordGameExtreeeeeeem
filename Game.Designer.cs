
namespace WordGameExtreeeeeeem
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.labelActiveWoord = new System.Windows.Forms.Label();
            this.buttonVolgende = new System.Windows.Forms.Button();
            this.buttonVorige = new System.Windows.Forms.Button();
            this.buttonNextGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelActiveWoord
            // 
            this.labelActiveWoord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelActiveWoord.AutoSize = true;
            this.labelActiveWoord.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelActiveWoord.Location = new System.Drawing.Point(258, 90);
            this.labelActiveWoord.Name = "labelActiveWoord";
            this.labelActiveWoord.Size = new System.Drawing.Size(254, 86);
            this.labelActiveWoord.TabIndex = 0;
            this.labelActiveWoord.Text = "Testing";
            this.labelActiveWoord.Click += new System.EventHandler(this.labelActiveWoord_Click);
            // 
            // buttonVolgende
            // 
            this.buttonVolgende.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVolgende.AutoSize = true;
            this.buttonVolgende.Location = new System.Drawing.Point(582, 343);
            this.buttonVolgende.Name = "buttonVolgende";
            this.buttonVolgende.Size = new System.Drawing.Size(113, 25);
            this.buttonVolgende.TabIndex = 1;
            this.buttonVolgende.Text = "Volgend woord";
            this.buttonVolgende.UseVisualStyleBackColor = true;
            this.buttonVolgende.Click += new System.EventHandler(this.buttonVolgende_Click);
            // 
            // buttonVorige
            // 
            this.buttonVorige.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonVorige.AutoSize = true;
            this.buttonVorige.Location = new System.Drawing.Point(103, 345);
            this.buttonVorige.Name = "buttonVorige";
            this.buttonVorige.Size = new System.Drawing.Size(109, 25);
            this.buttonVorige.TabIndex = 2;
            this.buttonVorige.Text = "Vorig woord";
            this.buttonVorige.UseVisualStyleBackColor = true;
            this.buttonVorige.Click += new System.EventHandler(this.buttonVorige_Click);
            // 
            // buttonNextGame
            // 
            this.buttonNextGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonNextGame.AutoSize = true;
            this.buttonNextGame.Location = new System.Drawing.Point(275, 345);
            this.buttonNextGame.Name = "buttonNextGame";
            this.buttonNextGame.Size = new System.Drawing.Size(223, 25);
            this.buttonNextGame.TabIndex = 3;
            this.buttonNextGame.Text = "Volgende Word Game Extreeeem!!!";
            this.buttonNextGame.UseVisualStyleBackColor = true;
            this.buttonNextGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNextGame);
            this.Controls.Add(this.buttonVorige);
            this.Controls.Add(this.buttonVolgende);
            this.Controls.Add(this.labelActiveWoord);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelActiveWoord;
        private System.Windows.Forms.Button buttonVolgende;
        private System.Windows.Forms.Button buttonVorige;
        private System.Windows.Forms.Button buttonNextGame;
    }
}