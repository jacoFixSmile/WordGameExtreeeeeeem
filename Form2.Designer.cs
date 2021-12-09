
namespace WordGameExtreeeeeeem
{
    partial class Form2
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
            this.buttonDontSaveWoord = new System.Windows.Forms.Button();
            this.buttonSaveWoorden = new System.Windows.Forms.Button();
            this.textBoxNameList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDontSaveWoord
            // 
            this.buttonDontSaveWoord.Location = new System.Drawing.Point(68, 144);
            this.buttonDontSaveWoord.Name = "buttonDontSaveWoord";
            this.buttonDontSaveWoord.Size = new System.Drawing.Size(75, 23);
            this.buttonDontSaveWoord.TabIndex = 0;
            this.buttonDontSaveWoord.Text = "Anuleer";
            this.buttonDontSaveWoord.UseVisualStyleBackColor = true;
            this.buttonDontSaveWoord.Click += new System.EventHandler(this.buttonDontSaveWoord_Click);
            // 
            // buttonSaveWoorden
            // 
            this.buttonSaveWoorden.Location = new System.Drawing.Point(201, 144);
            this.buttonSaveWoorden.Name = "buttonSaveWoorden";
            this.buttonSaveWoorden.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveWoorden.TabIndex = 1;
            this.buttonSaveWoorden.Text = "Opslaan";
            this.buttonSaveWoorden.UseVisualStyleBackColor = true;
            this.buttonSaveWoorden.Click += new System.EventHandler(this.buttonSaveWoorden_Click);
            // 
            // textBoxNameList
            // 
            this.textBoxNameList.Location = new System.Drawing.Point(68, 73);
            this.textBoxNameList.Name = "textBoxNameList";
            this.textBoxNameList.PlaceholderText = "Naam Lijst";
            this.textBoxNameList.Size = new System.Drawing.Size(219, 23);
            this.textBoxNameList.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 179);
            this.Controls.Add(this.textBoxNameList);
            this.Controls.Add(this.buttonSaveWoorden);
            this.Controls.Add(this.buttonDontSaveWoord);
            this.Name = "Form2";
            this.Text = "Woorden lijst opslagen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDontSaveWoord;
        private System.Windows.Forms.Button buttonSaveWoorden;
        private System.Windows.Forms.TextBox textBoxNameList;
    }
}