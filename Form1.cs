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
using System.Diagnostics;

namespace WordGameExtreeeeeeem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxTypeGame.Items.Add("Woorden");
            comboBoxTypeGame.Items.Add("Zinnen");
            comboBoxTypeGame.SelectedIndex = 0;
        }
  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveWords_Click(object sender, EventArgs e)
        {
            Form2 saveWoordenlijst = new Form2(textBoxWoordenSpel.Text);
            saveWoordenlijst.ShowDialog();


        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            char splitter;
            if (comboBoxTypeGame.SelectedItem == "Woorden")
            {
                splitter = ' ';
            }
            else
            {
                splitter = '.';
            }
            String []splitedArray = textBoxWoordenSpel.Text.Split(splitter);
            if (splitedArray.Length > 1)
            {
                this.Hide();
                Game game = new Game(splitedArray);
                game.Show();
            }
            else
            {
                MessageBox.Show( "Gelieven een input in te geven voor het spel te starten", "Niet genoeg input");
            }

        }

        private void buttonLaatWoordenLijst_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Title = "Browse Text Files";
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            string path = System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase;
            path = System.IO.Path.GetDirectoryName(path);
            openFileDialog1.InitialDirectory = path;
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            DialogResult dr = openFileDialog1.ShowDialog(); 
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                string buffer = null;
                using (openFileDialog1.OpenFile())
                {
                    using (System.IO.StreamReader rdr = new System.IO.StreamReader(openFileDialog1.OpenFile()))
                    {
                        buffer = rdr.ReadToEnd();
                    }
                }
                textBoxWoordenSpel.Text = buffer;
            }

        }
    }
}
