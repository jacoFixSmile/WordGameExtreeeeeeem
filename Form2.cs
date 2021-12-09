using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WordGameExtreeeeeeem
{
    public partial class Form2 : Form
    {
        private String textToSafe;
        public Form2(String text)
        {
            InitializeComponent();
            this.textToSafe = text;
        }

        private void buttonDontSaveWoord_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSaveWoorden_Click(object sender, EventArgs e)
        {
            if (textBoxNameList.Text.Length > 0)
            {
                 String textBoxNameListNoSpace = textBoxNameList.Text.Replace(' ', '_');
                 File.WriteAllTextAsync("woordenLijsten/" + textBoxNameListNoSpace+".txt", textToSafe);
            }
            else
            {
                MessageBox.Show("Voer een naam voor de lijst in.", "Niet genoeg input");
            }
        }

    }

}
