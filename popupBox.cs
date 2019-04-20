using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackJackForm
{
    public partial class popupBox : Form
    {
        public popupBox(string prevFormInput, string prevFormInputType)
        {
            InitializeComponent();
            nameLabel.Text = "";
            scoreLabel.Text = "";
            messageLabel.Text = "";
            if (prevFormInputType == "hs") { showScores(prevFormInput); }
            if (prevFormInputType == "gg") { showGG(prevFormInput,false); }
            if (prevFormInputType == "gg0") { showGG(prevFormInput,true); }
        }
        public static string returnNote = "";
        private void showScores(string highscoresIn){
            this.Text = "Highscores";
            nameLabel.Visible = true;
            scoreLabel.Visible = true;
            messageLabel.Visible = false;
            okButton.Visible = false;
            quitButton.Visible = false;
            string[] highscoresArr = highscoresIn.Split(';');
            int counter = 1;
            foreach (var score in highscoresArr)
            {
                string name = counter.ToString() + ". " + score.Substring(0, score.IndexOf(',')) + "\n";
                string monies = "$" + score.Substring(score.IndexOf(',') + 1, (score.Length - score.IndexOf(',') - 1)) + "\n"; ;
                nameLabel.Text += name;
                scoreLabel.Text += monies;
                counter++;
            }
            //Console.WriteLine("$$$");
        }

        private void showGG(string ggMessage,bool broke)
        {
            this.Text = "Game over!";
            nameLabel.Visible = false;
            scoreLabel.Visible = false;
            messageLabel.Visible = true;
            okButton.Visible = true;
            quitButton.Visible = true;

            if(broke == true){
                okButton.Text = "Play again?";
            }

            messageLabel.Text += ggMessage;
        }

            private void escapeForm(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 27) { this.Close(); }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            returnNote = "ok";
            this.Close();
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
