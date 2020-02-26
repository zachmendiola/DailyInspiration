using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace The_Hound_s_Daily_Inspirational_Quote
{
    public partial class Form1 : Form
    {
        static Random u = new Random();
        static StreamReader fopen = new StreamReader("Script.txt");
        static string line = fopen.ReadToEnd();
        static string[] lines = line.Split('\n');
        static int rInt = u.Next(0, lines.Length - 1);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Picture clicking Method that reacts to the user clicking the picture.
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            // Creating new random variable
            int rInt = u.Next(0, lines.Length - 1);
            // Switch statement for what value the variable is given
   
            label1.Text = lines[rInt];


            
            // Setting variables for the sound files
            SoundPlayer corpse = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.corpse);
            SoundPlayer dwarf = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.dwarf);
            SoundPlayer fk = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.f___ing);
            SoundPlayer cts = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.lots_of_c___s);
            SoundPlayer wine = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.wine);
            SoundPlayer chick = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.chickens);
            SoundPlayer fam = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.family);
            SoundPlayer peasants = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.peasants);
            // Switch statement using the Play method to play the sound that corresponds to the quote.
            switch (rInt)
            {
                case 0:
                    corpse.Play();
                    break;
                case 1:
                    dwarf.Play();
                    break;
                case 2:
                    fk.Play();
                    break;
                case 3:
                    cts.Play();
                    break;
                case 4:
                    wine.Play();
                    break;
                case 5:
                    chick.Play();
                    break;
                case 6:
                    fam.Play();
                    break;
                case 7:
                    peasants.Play();
                    break;
            }

        }   

        
    }
}
