using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }
    }
}
