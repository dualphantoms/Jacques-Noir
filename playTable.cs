using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackJackForm
{
    public partial class playTable : Form
    {
        public playTable()
        {
            InitializeComponent();
            player.monies = 500;
            bets();
        }
        public class Player
        {
            public string Name { get; set; }
            public string Hand { get; set; }
            public string HandShown { get; set; }
            public int handValue { get; set; }
            public int shownhandValue { get; set; }
            public bool bust { get; set; }
            public bool stay { get; set; }
            public bool aCheck { get; set; }
            public int monies { get; set; }

            public Player(string name)
            {
                Name = name;
                Hand = " ";
                HandShown = " ";
                handValue = 0;
                shownhandValue = 0;
                bust = false;
                stay = false;
                aCheck = false;
                monies = 0;
            }

        }
        //variablesssss
        int startCard = 4, pot = 0, bet = 0, maxbet = 200, minbet = 0;
        string[] cardFaces = { "A", "J", "Q", "K" };
        List<string> deck = new List<string>();
        Player dealer = new Player("Dealer");
        Player player = new Player("Player");
        //functions
        public void clearEm(bool winner)
        {
            int oldmoney = player.monies;
            
            dealerBox.Text = "";
            playerBox.Text = "";
            dealerBox.ForeColor = Color.Black;
            player = null;
            dealer = null;
            startCard = 4;
            dealer = new Player("Dealer");
            player = new Player("Player");

            if (winner == true) { player.monies = oldmoney + (pot+(bet*2)); pot = 0; potLabel.Text = "$" + pot.ToString(); oldmoney = 0; }
            else if (winner == false) { player.monies = oldmoney; pot += bet;  potLabel.Text = "$" + pot.ToString(); oldmoney = 0; };
            bet = 0;


            deck = new List<string>();
            PValue.Text = ""; DValue.Text = "";
            hitBox.Enabled = true;

            bets();
        }
        private void checkHand(Player inn, string hand)
        {

            int handValueCurr = 0, counter = 0, aCount = 0;
            string[] chand = hand.Replace(" ", "").Split('-');
            chand = chand.Take(chand.Count() - 1).ToArray();
            string[] cardValue = new string[chand.Length];

            foreach (string card in chand)
            {
                cardValue[counter] = card.Substring(1, card.Length - 1);
                counter++;
                //Console.WriteLine("*");
            }
            counter = 0;
            foreach (string card in cardValue)
            {
                if (card == "A") { cardValue[counter] = "11"; aCount++; };
                if (card == "J") { cardValue[counter] = "10"; };
                if (card == "Q") { cardValue[counter] = "10"; };
                if (card == "K") { cardValue[counter] = "10"; };
                counter++;
                //Console.WriteLine("*");
            }

            foreach (string card in cardValue)
            {
                handValueCurr += Convert.ToInt32(card);
            };

            if (handValueCurr > 21 && aCount > 0)
            {
                for (var i = 0; i < aCount; i++)
                {
                    handValueCurr -= 10;
                };
            }

            if (handValueCurr > 21)
            {
                inn.bust = true;
                inn.handValue = handValueCurr;
            }
            else
            {
                inn.handValue = handValueCurr;
            };
            if (inn.Name != "Dealer") { PValue.Text = handValueCurr.ToString(); }
            //Console.WriteLine("*");
        }
        private void checkshownHand(Player inn, string hand)
        {

            int handValueCurr = 0, counter = 0, aCount = 0;
            string[] chand = hand.Replace(" ", "").Split('-');
            chand = chand.Take(chand.Count() - 1).ToArray();
            string[] cardValue = new string[chand.Length];

            foreach (string card in chand)
            {
                cardValue[counter] = card.Substring(1, card.Length - 1);
                counter++;
                //Console.WriteLine("*");
            }
            counter = 0;
            foreach (string card in cardValue)
            {
                if (card == "A") { cardValue[counter] = "11"; aCount++; };
                if (card == "J") { cardValue[counter] = "10"; };
                if (card == "Q") { cardValue[counter] = "10"; };
                if (card == "K") { cardValue[counter] = "10"; };
                counter++;
                //Console.WriteLine("*");
            }

            foreach (string card in cardValue)
            {
                handValueCurr += Convert.ToInt32(card);
            };

            if (inn.Name == "Dealer") { DValue.Text = handValueCurr.ToString(); }

            inn.shownhandValue = handValueCurr;
            
        }
        private void buildDeck()
        {

            for (int i = 2; i < 11; i++)
            {
                deck.Add("C" + i);
                deck.Add("S" + i);
                deck.Add("D" + i);
                deck.Add("H" + i);
            }

            for (int i = 0; i < 4; i++)
            {
                deck.Add("C" + cardFaces[i]);
                deck.Add("S" + cardFaces[i]);
                deck.Add("D" + cardFaces[i]);
                deck.Add("H" + cardFaces[i]);
            }

            Random rng = new Random();
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                string value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
            
            //Deal Deck
            player.Hand += deck[0] + "-";
            dealer.Hand += deck[1] + "-";
            player.Hand += deck[2] + "-";
            player.HandShown += deck[2] + "-";
            dealer.Hand += deck[3] + "-";
            dealer.HandShown += deck[3] + "-";

            checkHand(dealer, dealer.Hand);
            checkshownHand(dealer, dealer.HandShown);
            checkHand(player, player.Hand);
            checkshownHand(player, player.HandShown);
            drawEm(player, false);
            drawEm(dealer, false);
            if (player.handValue == 21) { drawEm(dealer, true); gameOver("BLACKJACK!!! Player wins!!!", true); }
            else if (dealer.handValue == 21) { drawEm(dealer, true); gameOver("BLACKJACK!!! Dealer wins!!!", false); }
        }
        private void gameOver(string message, bool winner)
        {
            Thread.Sleep(500);
            if (player.monies <= 0 && winner == false) { broke(); }
            else{
                new popupBox(message, "gg").ShowDialog();
                if (popupBox.returnNote == "ok") { clearEm(winner); }
                else { Application.Exit(); };
            };
        }
        private void broke() {
            new popupBox("Looks like you're broke, better luck next time!", "gg0").ShowDialog();
            if (popupBox.returnNote == "ok") { highscores(0, 1); }
            else { Application.Exit(); };
        }
        private void highscores(int winnings, int reset)
        {
            //debug// winnings = 2000;

            //-------------------------------------------------------------
            // Creates highscores file from resource if it doesn't already exist.
            //-------------------------------------------------------------
            string scoresFile = @".\highscores.txt";
            if (!(File.Exists(scoresFile))){
                File.WriteAllText(scoresFile, JacquesNoirForm.Properties.Resources.highscores);
            };
            //-------------------------------------------------------------

            string text = System.IO.File.ReadAllText(scoresFile);
            var highscores = text.Split(';');
            if (winnings != 0)
            {
                List<Tuple<string, int>> hs = new List<Tuple<string, int>>();
                bool derank = false;

                foreach (var score in highscores)
                {
                    hs.Add(new Tuple<string, int>(score.Substring(0, score.IndexOf(',')), Convert.ToInt32(score.Substring(score.IndexOf(',') + 1, (score.Length - score.IndexOf(',') - 1)))));
                    if (winnings > Convert.ToInt32(score.Substring(score.IndexOf(',') + 1, (score.Length - score.IndexOf(',') - 1))))
                    {
                        derank = true;
                    }
                }

                if (derank == true)
                {
                    //Console.WriteLine("You made it on the leaderboard!");
                    string playerName = promptName();
                    hs.Add(new Tuple<string, int>(playerName, winnings));
                    hs = hs.OrderByDescending(t => t.Item2).ToList();
                    hs.RemoveAt(5);
                    updateHS(hs);
                }
            };
            text = System.IO.File.ReadAllText(scoresFile);
            highscores = text.Split(';');
            new popupBox(text, "hs").ShowDialog();
            if(reset == 1) { player.monies = 500; pot = 0; bet = 0; clearEm(false); };

            //Console.WriteLine("*");
        }
        private void updateHS(List<Tuple<string, int>> hs)
        {
            string output = "";
            for (int i = 0; i < hs.Count; i++)
            {
                output += hs[i].Item1 + "," + hs[i].Item2 + ";";
            }
            output = output.Remove(output.Length - 1, 1);
            System.IO.File.WriteAllText(@".\highscores.txt", output);
        }
        private string promptName()
        {
            new nameEntry().ShowDialog();
            return nameEntry.playerName;
        }
        private void compareCards()
        {
            drawEm(dealer, true);
            if (player.bust == true && dealer.bust == false) { gameOver("You busted! Dealer wins!", false); }
            else if (player.bust == false && dealer.bust == true) { gameOver("The Dealer busted! You win!", true); }
            else if (player.stay == true && dealer.stay == true && player.handValue > dealer.handValue) { gameOver("The Dealer lost! You win!", true); }
            else if (player.stay == true && dealer.stay == true && player.handValue < dealer.handValue) { gameOver("You lost! Dealer Wins!", false); }
            else if (player.stay == true && dealer.stay == true && player.handValue == dealer.handValue) { gameOver("Sorry, House Wins.", false); }
            else { gameOver("Error?", false); };

        }
        private void dealerAI() {
            if (dealer.handValue >= 17) { dealer.stay = true; }
            else if (dealer.handValue < 17) { hitDealer(); }

            if (dealer.bust == true) { compareCards(); }
            if (player.stay == true && dealer.stay == true) { compareCards(); };
            if (player.stay == true && dealer.stay == false) { dealerAI(); };
        }
        private void drawEm(Player inn, bool status)
        {
            string[] chand;
            RichTextBox useThis;
            if (inn.Name == "Dealer" && status == true) { chand = dealer.Hand.Replace(" ", "").Split('-'); useThis = dealerBox; dealerBox.ForeColor = Color.Red; DValue.Text = dealer.handValue.ToString(); }
            else if (inn.Name == "Dealer" && status == false) { chand = dealer.HandShown.Replace(" ", "").Split('-'); useThis = dealerBox; }
            else { chand = player.Hand.Replace(" ", "").Split('-'); useThis = playerBox; }

            chand = chand.Take(chand.Count() - 1).ToArray();
            string[] cardValue = new string[chand.Length];

            if (inn.Name == "Dealer" && status == false)
            {
                useThis.Text = "";
                useThis.AppendText("■?, ");
            }
            else { useThis.Text = ""; };
            
            foreach (string card in chand)
            {
                string suit = card.Substring(0, 1);
                string value = card.Substring(1, card.Length - 1);
                
                switch (suit)
                {
                    case "H": useThis.AppendText("♥  " + value + ", "); Application.DoEvents();  break;
                    case "D": useThis.AppendText("♦  " + value + ", "); Application.DoEvents(); break;
                    case "S": useThis.AppendText("♠  " + value + ", "); Application.DoEvents(); break;
                    case "C": useThis.AppendText("♣  " + value + ", "); Application.DoEvents(); break;
                    default: break;
                };
            }

        }
        private void hitDealer() {
            dealer.Hand += deck[startCard] + "-";
            dealer.HandShown += deck[startCard] + "-";
            checkHand(dealer, dealer.Hand);
            checkshownHand(dealer, dealer.HandShown);
            drawEm(dealer, false);
            startCard++;
            Thread.Sleep(1000);
        }
        private void bets()
        {
            //Console.WriteLine(bet);
            dealButton.Visible = true;
            hitBox.Enabled = false;
            stayBox.Enabled = false;
            upButton.Enabled = true;
            downButton.Enabled = true;
            gg.Visible = true;
            betLabel.Text = "$" + bet;
            cashLabel.Text = "$" + player.monies.ToString();
            dealerBox.Text = "                  Welcome!\n  Click 'Dealer' for high scores";
            playerBox.Text = "         Make your bet below\n             Max Bet is 200\n\nSurrender                            Deal";
        }
        private void hitEm(object sender, EventArgs e)
        {
            if (player.stay == true) { dealerAI(); }
            else
            {
                player.Hand += deck[startCard] + "-";
                player.HandShown += deck[startCard] + "-";
                checkHand(player, player.Hand);
                checkshownHand(player, player.HandShown);
                drawEm(player, false);
                if (player.bust == true) { compareCards(); }
                startCard++;
            };
        }
        private void stayEm(object sender, EventArgs e)
        {
            player.stay = true;
            hitBox.Enabled = false;

            if (dealer.stay == true) { compareCards(); }
            else { dealerAI(); };
        }
        private void leaveEm(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void highscoresButton(object sender, EventArgs e)
        {
            highscores(0,0);
        }
        private void ggButton(object sender, EventArgs e)
        {
            if(bet != 0) { player.monies = player.monies + bet; }
            highscores(player.monies, 1);
        }
        private void decreaseBet(object sender, EventArgs e)
        {
            if (bet <= minbet)
            {
                downButton.Enabled = false;
            }
            else
            {
                upButton.Enabled = true;
                bet -= 25;
                betLabel.Text = "$" + bet.ToString();
                player.monies += 25;
                cashLabel.Text = "$" + player.monies.ToString();
            };
            
        }
        private void dealCards(object sender, EventArgs e)
        {
            dealButton.Visible = false;
            downButton.Enabled = false;
            upButton.Enabled = false;
            //gg.Visible = false;
            hitBox.Enabled = true;
            stayBox.Enabled = true;
            buildDeck();
        }
        private void increaseBet(object sender, EventArgs e)
        {
            if (bet >= player.monies && player.monies == 0){
                upButton.Enabled = false;
            }
            else if (bet >= maxbet) {
                upButton.Enabled = false;
            }else{
                downButton.Enabled = true;
                bet += 25;
                betLabel.Text = "$" + bet.ToString();
                player.monies -= 25;
                cashLabel.Text = "$" + player.monies.ToString();
            };
        }
    }
};

/*  Credits:
    - Poker Hand: Icon made by Freepik from www.flaticon.com is licensed by Creative Commons BY 3.0.
    - Flag: Icon made by Smashicons from www.flaticon.com is licensed by Creative Commons BY 3.0
    - Chips Icon: Icons made by Eucalyp is licensed by Creative Commons BY 3.0  
*/