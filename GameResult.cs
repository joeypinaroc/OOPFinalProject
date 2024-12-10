using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameResult : Form
    {
        private Player generatedPlayer; // Variable for player
        private GameSetup GameSetupForm; // Reference to GameSetup form
        private GamePlay GamePlayForm; // Reference to GameSetup form
        public GameResult(string resultText, Player player, GameSetup GameSetupForm, GamePlay GamePlayForm)
        {
            InitializeComponent();
            this.GameSetupForm = GameSetupForm; // Store the reference
            this.GamePlayForm = GamePlayForm; // Store the reference
            this.generatedPlayer = player;
            lbl_GameResult.Content = resultText;
            lbl_GameResult.FontSize = 24;

            if (player.Job.JobName == "Farmer")
            {
                // Display farmer character and update stats
                characterImg.Image = Properties.Resources.farmer;
            }
            else if (player.Job.JobName == "Bard")
            {
                // Display bard character and update stats
                characterImg.Image = Properties.Resources.bard;
            }
            else
            {
                // Display scholar character and update stats
                characterImg.Image = Properties.Resources.scholar;
            }
        }

        // Even to restart the game
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            GamePlayForm.Hide();
            // Show GameSetup popup
            GameSetupForm.Show();
            // Close this popup and Gamesetup form
            this.Hide();
        }

        // Event to Exit the game
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound();
            Application.Exit(); // Ensure all threads and forms are terminated
        }

        private void GameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

