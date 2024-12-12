using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinalProject
{
    // Show Player preview and handle logic
    public partial class PlayerPreview : Form
    {
        private Player player; // Variable for player
        private GameSetup GameSetupForm; // Reference to GameSetup form
        
        // PlayerPreview Constructor
        public PlayerPreview(Player createdPlayer, GameSetup GameSetupForm)
        {
            InitializeComponent();
            this.GameSetupForm = GameSetupForm; // Store the reference
            player = createdPlayer;
            // Update Name, Job and stats based on player selection
            textHolder_Title.Content = player.Job.JobName.ToUpper();
            statusBar.SetStat(player.Strength, player.Intelligence, player.Charisma);
            textHolder_Desc.FontSize = 14;
            if (player.Job.JobName == "Farmer")
            {
                // Display farmer character, description and update stats
                characterImg.Image = Properties.Resources.farmer;
                textHolder_Desc.Content = "'From the earth, we thrive.' \nPossess a deep connection with nature \nand a wealth of practical knowledge";
            }
            else if (player.Job.JobName == "Bard")
            {
                // Display bard character, description and update stats
                characterImg.Image = Properties.Resources.bard;
                textHolder_Desc.Content = "'Every tale has a song.'\nSharing stories, songs and poems. \nPreserving the culture and history of the people.";
            }
            else
            {
                // Display scholar character, description and update stats
                characterImg.Image = Properties.Resources.scholar;
                textHolder_Desc.Content = "'Knowledge is the key to all doors.' \nDelving into ancient texts and history.\nValuable source of information and wisdom.";
            }
        }

        // Event when Play button is clicked
        private void btn_Play_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            // Show Gameplay popup
            GamePlay gamePlayForm = new GamePlay(player, GameSetupForm);
            gamePlayForm.Show();
            // Close this popup
            this.Hide();
        }

        // Event when Cancel button is clicked
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            // Close Player preview window and show GameSetup window
            GameSetupForm.Show();
            this.Hide(); // Close this popup
        }

        // Method to handle closing of Player Preview
        private void PlayerPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
