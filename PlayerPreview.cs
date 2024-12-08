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

namespace FinalProject
{
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
            textHolder_Title.Content = "PLAYER PREVIEW";
            lbl_Name_Value.Text = player.Name;
            lbl_Job_Value.Text = player.Job.JobName.ToUpper();
            statusBar.SetStat(player.Strength, player.Intelligence, player.Charisma);
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

        // Event when Play button is clicked
        private void btn_Play_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            // Show Gameplay popup
            GamePlay gamePlayForm = new GamePlay(player);
            gamePlayForm.Show();
            // Close this popup and Gamesetup form
            this.Close();
        }

        // Event when Cancel button is clicked
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            // Close Player preview window and show GameSetup window
            GameSetupForm.Show();
            this.Close(); // Close this popup
        }
    }
}
