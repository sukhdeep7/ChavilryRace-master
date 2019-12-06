using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChavilryRace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Setup Defaults
            setup();
        }

        // Setup all the base elements for the race
        public void setup()
        {
            // Get's the start position
            int startPos = knightBlack.Left;

            // Calculates the length of the race track
            int RaceTrackLength = TrackLengthPanel.Width - knightBlack.Right;

            // Initializes all the racing vehicles
            Data.chevilries[0] = new Chevilry() { chevilryImg = knightBlack, startPos = startPos, finalPos = RaceTrackLength };
            Data.chevilries[1] = new Chevilry() { chevilryImg = knightGreen, startPos = startPos, finalPos = RaceTrackLength };
            Data.chevilries[2] = new Chevilry() { chevilryImg = knightRed, startPos = startPos, finalPos = RaceTrackLength };
            Data.chevilries[3] = new Chevilry() { chevilryImg = knightBlue, startPos = startPos, finalPos = RaceTrackLength };

            // Initialize all the gamblers
            Data.bettor[0] = new Gambler() { balance = 65, activity = label1, listOfBettors = radioButton1, name = "Player 1" };
            Data.bettor[1] = new Gambler() { balance = 75, activity = label2, listOfBettors = radioButton2, name = "Player 2" };
            Data.bettor[2] = new Gambler() { balance = 55, activity = label3, listOfBettors = radioButton3, name = "Player 3" };

            // Update all the activity labels to default
            Data.bettor[0].UpdateActivity();
            Data.bettor[1].UpdateActivity();
            Data.bettor[2].UpdateActivity();

            // Reset all the starts to defaults
            Data.bettor[0].ResetStats();
            Data.bettor[1].ResetStats();
            Data.bettor[2].ResetStats();
        }

        public void ResetPositions()
        {
            Data.chevilries[0].MoveToStart();
            Data.chevilries[1].MoveToStart();
            Data.chevilries[2].MoveToStart();
            Data.chevilries[3].MoveToStart();
        }

        public void ResetBidsText()
        {
            label1.Text = "Player 1 hasn't placed a bit.";
            label2.Text = "Player 2 hasn't placed a bit.";
            label3.Text = "Player 3 hasn't placed a bit.";
        }

        public void announceWinner(int winner)
        {
            MessageBox.Show("Knight #" + winner + " is the winning Knight!");
            for (int i = 0; i < Data.bettor.Length; i++)
            {
                Data.bettor[i].collectWinningAmount(winner);
                Data.bettor[i].UpdateActivity();
                ResetPositions();
                ResetBidsText();
            }
        }

        private void PlaceBet_Click(object sender, EventArgs e)
        {
            Data.bettor[Data.currentGambler].betting((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            Data.bettor[Data.currentGambler].UpdateActivity();
        }

        private void StartRace_Click(object sender, EventArgs e)
        {
            RaceTime.Start();
            StartRace.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 1;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Data.currentGambler = 2;
        }

        private void RaceTime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Data.chevilries.Length; i++)
            {
                Data.chevilries[Data.rand.Next(0, 4)].isAccelerating();
                if (Data.chevilries[i].isAccelerating())
                {
                    RaceTime.Stop();
                    RaceTime.Enabled = false;
                    StartRace.Enabled = true;
                    announceWinner(i + 1);
                }
            }
        }
    }
}
