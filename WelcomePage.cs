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
        
        public Form1()
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

        private void btn_Choice3_Click(object sender, EventArgs e)
        {
            int roll = dice.Roll();
            if (choiceList[2].ChoiceCheck == attributeDictionary[0]) //if ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; //player with Str > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Strength += choiceList[2].DisadvantageBonus; //if player with Strength Adv fails, reduce their Strength attribute   
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; //player with Str < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Strength += choiceList[2].AdvantageBonus; //if player without Strength Adv succeeds, add their Strength attribute
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == attributeDictionary[1]) //if ChoiceCheck is Cha
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Charisma += choiceList[2].DisadvantageBonus; //if player with Charisma Adv fails, reduce their Charisma attribute   
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Charisma += choiceList[2].AdvantageBonus; //if player without Charisma Adv succeeds, add their Charisma attribute
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == attributeDictionary[2]) //if ChoiceCheck is Int
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; //player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Intelligence += choiceList[2].DisadvantageBonus; //if player with Intelligence Adv fails, reduce their Intelligence attribute   
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Intelligence += choiceList[2].AdvantageBonus; //if player without Intelligence Adv succeeds, add their Intelligence attribute
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == null) //if ChoiceCheck is null, auto-fail the conflict
            {
                MessageBox.Show("You selected the Surrender option!");
                currentConflict.Outcome = false;
            }

            SetupAttriBox(); //update Attribute box
            UpdateConflict(currentConflict);
            UpdatePanel();
        }
    }
}
