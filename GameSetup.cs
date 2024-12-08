using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class GameSetup : Form
    {

        private Player player; // Variable for player
        // List of player jobs in the game
        public static List<Job> joblist = new List<Job>()
        {
            new Job{Id = 1, JobName = "Farmer"},
            new Job{Id = 2, JobName = "Bard"},
            new Job{Id = 3, JobName = "Scholar"}
        };

        // GameSetup constructor
        public GameSetup()
        {
            InitializeComponent();
            // Play background music and display game title
            SoundEffect.BackgroundMusic();
            textHolder_Title.Content = "WELCOME TO DUNGEON GAME";
            // Populate list of jobs in dropdown
            foreach (Job job in joblist)
            {
                cb_Job.Items.Add(job.JobName);
            }
            // Set default value for player name and job
            tb_Name.Text = "NEW PLAYER";
            cb_Job.SelectedIndex = 0;
        }

        // Event when Create Player button is cliced in Welcome Page
        private void btn_WelcomeCreatePlayer_Click(object sender, EventArgs e)
        {
            // Hide the button and show Create Player panel
            panel_CreatePlayer.Visible = true;
            btn_WelcomeCreatePlayer.Visible = false;
            // Play mouseclick sound effect
            SoundEffect.MouseClickSound();
            tb_Name.Focus(); // Set focus to player name
        }

        // Event when Player job is changed
        private void cb_Job_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            if (cb_Job.SelectedIndex == 0)
            {
                // Display farmer character and update stats
                statusBar.SetStat(13, 10, 9);
                characterImg.Image = Properties.Resources.farmer;
            }
            else if (cb_Job.SelectedIndex == 1)
            {
                // Display bard character and update stats
                statusBar.SetStat(10, 9, 13);
                characterImg.Image = Properties.Resources.bard;
            }
            else
            {
                // Display scholar character and update stats
                statusBar.SetStat(9, 13, 10);
                characterImg.Image = Properties.Resources.scholar;
            }
        }

        // Event when Create player button is clicked
        private void btn_CreatePlayer_Click(object sender, EventArgs e)
        {
            // Play selection change sound effect
            SoundEffect.MouseClickSound();
            string playerName = tb_Name.Text;
            string chosenJobName = cb_Job.SelectedItem.ToString();
            Job chosenJob = joblist.Find(job => job.JobName == chosenJobName);

            // Generate the player with name and job specified
            PlayerGenerator p = new PlayerGenerator();
            p.PlayerGenerated += OnPlayerGenerated; // Subscribe event
            p.Generate(playerName, chosenJob);
        }
        
        // Event when a player is generated
        private void OnPlayerGenerated(object sender, PlayerGeneratedEventArgs e)
        {
            player = e.CreatedPlayer;

            // Instantiate the PlayerPreview form and pass the player object
            PlayerPreview playerPreview = new PlayerPreview(player, this);

            // Show the PlayerPreview form as a modal dialog
            this.Hide();
            playerPreview.ShowDialog();
        }
    }
}
