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
    public partial class Game : Form
    {
        private String[] WoordenLijst;
        private int WoordCounter=0;
        private Form1 parrentCallback;
        public Game(String[] woordenlijstRaw, Form1 parrentCallback)
        {
            this.WoordenLijst = woordenlijstRaw;
            InitializeComponent();
            labelActiveWoord.Text = WoordenLijst[0];
            buttonVorige.Hide();
            buttonNextGame.Hide();

            if (WoordCounter + 1 >= WoordenLijst.Length)
            {
                buttonVolgende.Hide();
            }
            this.parrentCallback = parrentCallback;
        }
      
        private void buttonVolgende_Click(object sender, EventArgs e)
        {
            this.goNext();
        }
        private void goNext()
        {
            WoordCounter++;
            labelActiveWoord.Text = WoordenLijst[WoordCounter];
            // Toon volgende button als het mogelijk is
            if (WoordCounter + 1 >= WoordenLijst.Length)
            {
                buttonVolgende.Hide();
                buttonNextGame.Show();
            }
            // Toon vorige button als het mogelijk is
            if (WoordCounter - 1 >= 0)
            {
                buttonVorige.Show();
            }
        }
        private void goPrevious()
        {
            WoordCounter--;
            labelActiveWoord.Text = WoordenLijst[WoordCounter];
            // Toon button volgende als het kan
            if (WoordCounter + 1 < WoordenLijst.Length)
            {
                buttonVolgende.Show();
                buttonNextGame.Hide();

            }
            // Toon button vorige niet als het niet kan
            if (WoordCounter - 1 < 0)
            {
                buttonVorige.Hide();
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
           
        }

        private void buttonVorige_Click(object sender, EventArgs e)
        {
            this.goPrevious();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            parrentCallback.Show();
        }

        private void labelActiveWoord_Click(object sender, EventArgs e)
        {

        }
    }
}
