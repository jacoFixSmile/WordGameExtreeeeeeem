
namespace WordGameExtreeeeeeem
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxWoordenSpel = new System.Windows.Forms.TextBox();
            this.buttonSaveWords = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBoxTypeGame = new System.Windows.Forms.ComboBox();
            this.buttonLaatWoordenLijst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(630, 263);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Begin";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(633, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "WordGame Extreeeeeeemmmm";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxWoordenSpel
            // 
            this.textBoxWoordenSpel.Location = new System.Drawing.Point(97, 58);
            this.textBoxWoordenSpel.Multiline = true;
            this.textBoxWoordenSpel.Name = "textBoxWoordenSpel";
            this.textBoxWoordenSpel.PlaceholderText = "Woorden voor het spel";
            this.textBoxWoordenSpel.Size = new System.Drawing.Size(608, 199);
            this.textBoxWoordenSpel.TabIndex = 2;
            this.textBoxWoordenSpel.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // buttonSaveWords
            // 
            this.buttonSaveWords.Location = new System.Drawing.Point(97, 263);
            this.buttonSaveWords.Name = "buttonSaveWords";
            this.buttonSaveWords.Size = new System.Drawing.Size(153, 23);
            this.buttonSaveWords.TabIndex = 3;
            this.buttonSaveWords.Text = "Slaag woorden lijst op";
            this.buttonSaveWords.UseVisualStyleBackColor = true;
            this.buttonSaveWords.Click += new System.EventHandler(this.buttonSaveWords_Click);
            // 
            // comboBoxTypeGame
            // 
            this.comboBoxTypeGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeGame.FormattingEnabled = true;
            this.comboBoxTypeGame.Location = new System.Drawing.Point(503, 263);
            this.comboBoxTypeGame.Name = "comboBoxTypeGame";
            this.comboBoxTypeGame.Size = new System.Drawing.Size(121, 23);
            this.comboBoxTypeGame.TabIndex = 4;
            // 
            // buttonLaatWoordenLijst
            // 
            this.buttonLaatWoordenLijst.Location = new System.Drawing.Point(97, 293);
            this.buttonLaatWoordenLijst.Name = "buttonLaatWoordenLijst";
            this.buttonLaatWoordenLijst.Size = new System.Drawing.Size(153, 23);
            this.buttonLaatWoordenLijst.TabIndex = 5;
            this.buttonLaatWoordenLijst.Text = "Laat woorden lijst";
            this.buttonLaatWoordenLijst.UseVisualStyleBackColor = true;
            this.buttonLaatWoordenLijst.Click += new System.EventHandler(this.buttonLaatWoordenLijst_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLaatWoordenLijst);
            this.Controls.Add(this.comboBoxTypeGame);
            this.Controls.Add(this.buttonSaveWords);
            this.Controls.Add(this.textBoxWoordenSpel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "WordGameExtreeeeeeem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxWoordenSpel;
        private System.Windows.Forms.Button buttonSaveWords;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBoxTypeGame;
        private System.Windows.Forms.Button buttonLaatWoordenLijst;
    }
}

