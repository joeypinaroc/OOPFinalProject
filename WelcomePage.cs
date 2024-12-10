using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class WelcomePage : Form
    {

        private Player generatedPlayer;
        private Conflict currentConflict;
        private Dice dice = new Dice();
        public static List<Job> joblist = new List<Job>()
        {
            new Job{Id = 1, JobName = "Farmer"},
            new Job{Id = 2, JobName = "Bard"},
            new Job{Id = 3, JobName = "Scholar"}
        };
        
        public static Dictionary<int, string> attributeDictionary = new Dictionary<int, string>()
        {
            { 0, "Strength" },
            { 1, "Charisma" },
            { 2, "Intelligence" }
        };
        
        public WelcomePage()
        {
            InitializeComponent();
            SoundEffect.BackgroundMusic();
            textHolder1.Content = "WELCOME TO DUNGEON GAME";
            foreach (Job job in joblist) // combobox has DropDownStyle = DropDownList
            {
                cb_Job.Items.Add(job.JobName);
            }
            tb_Name.Text = "NEW PLAYER";
            cb_Job.SelectedIndex = 0;   
        }

        private void btn_WelcomeCreatePlayer_Click(object sender, EventArgs e)
        {     
            panel_CreatePlayer.Visible = true;
            btn_WelcomeCreatePlayer.Visible = false;
            SoundEffect.MouseClickSound();
        }

        private void btn_CreatePlayer_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound();
            string playerName = tb_Name.Text;
            string chosenJobName = cb_Job.SelectedItem.ToString();
            Job chosenJob = joblist.Find(job => job.JobName == chosenJobName);

            PlayerGenerator p = new PlayerGenerator();
            p.PlayerGenerated += OnPlayerGenerated;

            p.Generate(playerName, chosenJob);
        }
        private void OnPlayerGenerated(object sender, PlayerGeneratedEventArgs e)
        {
            generatedPlayer = e.CreatedPlayer;

            ClearForm();
        }
        private void ClearForm()
        {
            foreach(Control control in Controls)
            {
                control.Visible = false;
            }
        }

        
    }
}
