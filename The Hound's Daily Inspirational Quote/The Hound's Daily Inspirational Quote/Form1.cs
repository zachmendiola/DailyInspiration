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
        public Form1()
        {
            InitializeComponent();
            string[] quotes = new string[] { };
            try
            {
                // Sets StreamReader variable to read from script.txt
                StreamReader fopen = new StreamReader("Script.txt");
                // Reading the file
                string line = fopen.ReadToEnd();
                // Splitting the file by newlines, forming a string array of quotes
                string[] lines = line.Split('\n');

                // Initialization of random variable 'u'
                Random u = new Random();
                // Declaring and integer variable equal to a random number
                int rInt = u.Next(0, lines.Length-1);
                // Setting variable that is equal to a random indice of the string array
                string phrases = lines[rInt];
                // Setting the text in the box equal to that random phrase
                label1.Text = phrases;
            }
            
            catch
            { 
                Console.WriteLine("Error in file reading.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Picture clicking class that reacts to the user clicking the picture.
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            // Restating the previous code, randomizing the text displayed
            // when the user clicks on the picture.
            StreamReader fopen = new StreamReader("Script.txt");
            string line = fopen.ReadToEnd();
            string[] lines = line.Split('\n');
            Random u = new Random();
            int rInt = u.Next(0, lines.Length - 1);
            label1.Text = lines[rInt];

            // Calls the playaudio method
            playaudio();
        }
        // Playaudio chooses a random sound quote and plays it.
        public void playaudio() 
        {
            // Setting variables for the sound files
            SoundPlayer corpse = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.corpse);
            SoundPlayer dwarf = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.dwarf);
            SoundPlayer fk = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.f___ing);
            SoundPlayer cts = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.lots_of_c___s);
            SoundPlayer wine = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.wine);
            SoundPlayer chick = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.chickens);
            SoundPlayer fam = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.family);
            SoundPlayer peasants = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.peasants);
            SoundPlayer lommy = new SoundPlayer(The_Hound_s_Daily_Inspirational_Quote.Properties.Resources.lommy);

            // Initialization of an array of numbers 1-9.
            int[] arrayal = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            // Initialization of random variable 's' and int variable 'sInt'.
            Random s = new Random();
            int sInt = s.Next(1, arrayal.Length);
            // Switch statement that changes the files played depending on what random number was chosen.
            switch (sInt)
            {
                case 1:
                    corpse.Play();
                    break;
                case 2:
                    dwarf.Play();
                    break;
                case 3:
                    fk.Play();
                    break;
                case 4:
                    cts.Play();
                    break;
                case 5:
                    wine.Play();
                    break;
                case 6:
                    chick.Play();
                    break;
                case 7:
                    fam.Play();
                    break;
                case 8:
                    peasants.Play();
                    break;
                case 9:
                    lommy.Play();
                    break;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
