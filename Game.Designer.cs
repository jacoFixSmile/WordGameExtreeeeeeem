
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
            this.SuspendLayout();
            // 
            // labelActiveWoord
            // 
            this.labelActiveWoord.AutoSize = true;
            this.labelActiveWoord.Location = new System.Drawing.Point(336, 114);
            this.labelActiveWoord.Name = "labelActiveWoord";
            this.labelActiveWoord.Size = new System.Drawing.Size(44, 15);
            this.labelActiveWoord.TabIndex = 0;
            this.labelActiveWoord.Text = "Testing";
            // 
            // buttonVolgende
            // 
            this.buttonVolgende.Location = new System.Drawing.Point(582, 345);
            this.buttonVolgende.Name = "buttonVolgende";
            this.buttonVolgende.Size = new System.Drawing.Size(113, 23);
            this.buttonVolgende.TabIndex = 1;
            this.buttonVolgende.Text = "Volgend woord";
            this.buttonVolgende.UseVisualStyleBackColor = true;
            this.buttonVolgende.Click += new System.EventHandler(this.buttonVolgende_Click);
            // 
            // buttonVorige
            // 
            this.buttonVorige.Location = new System.Drawing.Point(103, 345);
            this.buttonVorige.Name = "buttonVorige";
            this.buttonVorige.Size = new System.Drawing.Size(109, 23);
            this.buttonVorige.TabIndex = 2;
            this.buttonVorige.Text = "Vorig woord";
            this.buttonVorige.UseVisualStyleBackColor = true;
            this.buttonVorige.Click += new System.EventHandler(this.buttonVorige_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}