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
    // Show Game result and handle logic
    public partial class GameResult : Form
    {
        // Define result variables
        private Player generatedPlayer; // Variable for player
        private GameSetup GameSetupForm; // Reference to GameSetup form
        private GamePlay GamePlayForm; // Reference to GameSetup form

        // Constructor for GameResult class with result, player, GameSetup, and GamePlay form as input
        public GameResult(string resultText, Player player, GameSetup GameSetupForm, GamePlay GamePlayForm)
        {
            InitializeComponent();
            this.GameSetupForm = GameSetupForm; // Store the GameSetup reference
            this.GamePlayForm = GamePlayForm; // Store the GamePlay reference
            this.generatedPlayer = player; // Store player object
            // Update result text and size
            lbl_GameResult.Content = resultText;
            lbl_GameResult.FontSize = 16;
            lbl_GameResult.WrapWidth = 460; // Set TextHolder width
            // Evaluate player job
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

        // Event to restart the game
        private void btn_PlayAgain_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            // Hide GamePlay popup
            GamePlayForm.Hide();
            // Show GameSetup popup
            GameSetupForm.Show();
            // Close this popup and Gamesetup form
            this.Hide();
        }

        // Event to Exit the game
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound(); // Play mouseclick sound
            Application.Exit(); // Ensure all threads and forms are terminated
        }

        // Method to handle closing of GameResult
        private void GameResult_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}

