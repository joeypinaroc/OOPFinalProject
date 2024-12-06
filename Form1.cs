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
    public partial class Form1 : Form
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
        public static List<Conflict> conflictList = new List<Conflict>()
        {
            new Conflict { ConflictID = 1, Text = "Your first conflict! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 2, Text = "Conflict number 2! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 3, Text = "Conflict number 3! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 4, Text = "Conflict number 4! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 5, Text = "Conflict number 5! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 6, Text = "Conflict number 6! Decide on a choice by pressing a button below.", Outcome = false},
            new Conflict { ConflictID = 7, Text = "Conflict number 7! Decide on a choice by pressing a button below.", Outcome = false},
        };
        public static List<Choice> choiceList = new List<Choice>()
        {
            new Choice { ConflictID = 1, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 3, ChoiceText = "Choice 3 [SURRENDER]", ChoiceCheck = null},

            new Choice { ConflictID = 2, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},

            new Choice { ConflictID = 3, ChoiceID = 1, ChoiceText = "Choice 1 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 3, ChoiceText = "Choice 3 [SURRENDER]", ChoiceCheck = null },

            new Choice { ConflictID = 4, ChoiceID = 1, ChoiceText = "Choice 1 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 14, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 3, ChoiceText = "Choice 3", ChoiceCheck = null },

            new Choice { ConflictID = 5, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 5, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 5, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            new Choice { ConflictID = 6, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            new Choice { ConflictID = 7, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },
        };
        public static List<Ending> endingList = new List<Ending>()
        {
            new Ending { EndingID = 1, EndingText = "You get Ending 1!"},
            new Ending { EndingID = 2, EndingText = "You get Ending 2!"},
            new Ending { EndingID = 3, EndingText = "You get Ending 3!"},
            new Ending { EndingID = 4, EndingText = "You get Ending 4!"},
            new Ending { EndingID = 5, EndingText = "You get Ending 5!"},
            new Ending { EndingID = 6, EndingText = "You get Ending 6!"},
            new Ending { EndingID = 7, EndingText = "You get Ending 7!"},
            new Ending { EndingID = 8, EndingText = "You get Ending 8!"},
        };
        
        public Form1()
        {
            InitializeComponent();

            foreach (Job job in joblist) // combobox has DropDownStyle = DropDownList
            {
                cb_Job.Items.Add(job.JobName);
            }
        }

        private void btn_WelcomeCreatePlayer_Click(object sender, EventArgs e)
        {
            panel_CreatePlayer.Visible = true;
        }

        private void btn_CreatePlayer_Click(object sender, EventArgs e)
        {
            string playerName = tb_Name.Text;
            string chosenJobName = cb_Job.SelectedItem.ToString();
            Job chosenJob = joblist.Find(job => job.JobName == chosenJobName);

            PlayerGenerator p = new PlayerGenerator();
            p.PlayerGenerated += OnPlayerGenerated;

            p.Generate(playerName, chosenJob);

            SetupAttriBox();
            SetupBackgroundImage();
            SetupPanel();
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
         private void SetupAttriBox()
        {
            rtb_Attributes.Text = "Name: " + generatedPlayer.Name;
            rtb_Attributes.Text += "\nJob: " + generatedPlayer.Job.JobName;
            rtb_Attributes.Text += "\nAttributes";
            rtb_Attributes.Text += "\nStrength: " + generatedPlayer.Strength;
            rtb_Attributes.Text += "\nCharisma: " + generatedPlayer.Charisma;
            rtb_Attributes.Text += "\nIntelligence: " + generatedPlayer.Intelligence;
            rtb_Attributes.Visible = true;
        }
        private void SetupBackgroundImage()
        {
            pb_Background.Visible = true;
        }
        private void SetupPanel()
        {
            lbl_Choice1.Text = choiceList[0].ChoiceText;
            lbl_Choice2.Text = choiceList[1].ChoiceText;
            lbl_Choice3.Text = choiceList[2].ChoiceText;
            panel_TextPanel.Visible = true;

            btn_Choice1.Tag = choiceList[0].ChoiceID;
            btn_Choice2.Tag = choiceList[1].ChoiceID;
            btn_Choice3.Tag = choiceList[2].ChoiceID;

            SetupConflict();
        }
        private void SetupConflict()
        {
            currentConflict = new Conflict();
            currentConflict = conflictList[0];
            rtb_ConflictText.Text = currentConflict.Text;
        }
        private void UpdatePanel()
        {
            var newChoiceList = choiceList.Where(choice => choice.ConflictID == currentConflict.ConflictID).ToList();

            if(newChoiceList.Count > 0)
            {
                lbl_Choice1.Text = newChoiceList[0].ChoiceText;
                lbl_Choice2.Text = newChoiceList[1].ChoiceText;
                lbl_Choice3.Text = newChoiceList[2].ChoiceText;

                btn_Choice1.Tag = newChoiceList[0].ChoiceID;
                btn_Choice2.Tag = newChoiceList[1].ChoiceID;
                btn_Choice3.Tag = newChoiceList[2].ChoiceID;
            }
        }
        private void UpdateConflict(Conflict previousConflict)
        {
            int indexOfPrev = conflictList.IndexOf(previousConflict);
            //heading into stage 2
            if(indexOfPrev == 0)
            {
                if (previousConflict.Outcome == true) currentConflict = conflictList[1];
                else currentConflict = conflictList[2];
            }
            else if(indexOfPrev == 1)
            {
                if (previousConflict.Outcome == true) currentConflict = conflictList[3];
                else currentConflict = conflictList[4];
            }
            else if (indexOfPrev == 2)
            {
                if (previousConflict.Outcome == true) currentConflict = conflictList[5];
                else currentConflict = conflictList[6];
            }
            else if(indexOfPrev == 3 || indexOfPrev == 4 || indexOfPrev == 5 || indexOfPrev == 6)
            {
                //initiate ending
                SelectEnding(currentConflict);
            }

            rtb_ConflictText.Text = currentConflict.Text;
        }
        private void SelectEnding(Conflict penConflict)
        {
            if (penConflict.ConflictID == 3)
            {
                if (penConflict.Outcome == true) InitiateEnding(endingList[0]);
                else InitiateEnding(endingList[1]);
            }
            else if (penConflict.ConflictID == 4)
            {
                if (penConflict.Outcome == true) InitiateEnding(endingList[2]);
                else InitiateEnding(endingList[3]);
            }
            else if (penConflict.ConflictID == 5)
            {
                if (penConflict.Outcome == true) InitiateEnding(endingList[4]);
                else InitiateEnding(endingList[5]);
            }
            else if (penConflict.ConflictID == 6)
            {
                if (penConflict.Outcome == true) InitiateEnding(endingList[6]);
                else InitiateEnding(endingList[7]);
            }
        }
        private void InitiateEnding(Ending ending)
        {
            ClearForm();
            MessageBox.Show(ending.EndingText);
        }

        private void btn_Choice1_Click(object sender, EventArgs e)
        {
            int roll = dice.Roll();
            if (choiceList[0].ChoiceCheck == attributeDictionary[0]) //if ChoiceCheck is Str
            {
                if(generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; //player with Str > 10 has Adv
                    if((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Strength += choiceList[0].DisadvantageBonus; //if player with Strength Adv fails, reduce their Strength attribute   
                    }
                }
                else if(generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; //player with Str < 10 has Disadv
                    if((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Strength += choiceList[0].AdvantageBonus; //if player without Strength Adv succeeds, add their Strength attribute
                    }
                    else if((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else if(generatedPlayer.Strength == 10) //if no Adv: Strength = 10, no added Adv
                {
                    if(roll >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if(roll < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == attributeDictionary[1]) //if ChoiceCheck is Cha
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Charisma += choiceList[0].DisadvantageBonus; //if player with Charisma Adv fails, reduce their Charisma attribute   
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Charisma += choiceList[0].AdvantageBonus; //if player without Charisma Adv succeeds, add their Charisma attribute
                    }
                    else if ((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == attributeDictionary[2]) //if ChoiceCheck is Int
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; //player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Intelligence += choiceList[0].DisadvantageBonus; //if player with Intelligence Adv fails, reduce their Intelligence attribute   
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Intelligence += choiceList[0].AdvantageBonus; //if player without Intelligence Adv succeeds, add their Intelligence attribute
                    }
                    else if ((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[0].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == null) //if ChoiceCheck is null, auto-fail the conflict
            {
                MessageBox.Show("You selected the Surrender option!");
                currentConflict.Outcome = false;
            }

            SetupAttriBox(); //update Attribute box
            UpdateConflict(currentConflict);
            UpdatePanel();
        }

        private void btn_Choice2_Click(object sender, EventArgs e)
        {
            int roll = dice.Roll();
            if (choiceList[1].ChoiceCheck == attributeDictionary[0]) //if ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; //player with Str > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Strength += choiceList[1].DisadvantageBonus; //if player with Strength Adv fails, reduce their Strength attribute   
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; //player with Str < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Strength += choiceList[1].AdvantageBonus; //if player without Strength Adv succeeds, add their Strength attribute
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == attributeDictionary[1]) //if ChoiceCheck is Cha
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Charisma += choiceList[1].DisadvantageBonus; //if player with Charisma Adv fails, reduce their Charisma attribute   
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Charisma += choiceList[1].AdvantageBonus; //if player without Charisma Adv succeeds, add their Charisma attribute
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == attributeDictionary[2]) //if ChoiceCheck is Int
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; //player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + adv) + ". Failure!");
                        currentConflict.Outcome = false;
                        generatedPlayer.Intelligence += choiceList[1].DisadvantageBonus; //if player with Intelligence Adv fails, reduce their Intelligence attribute   
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Success!");
                        currentConflict.Outcome = true;
                        generatedPlayer.Intelligence += choiceList[1].AdvantageBonus; //if player without Intelligence Adv succeeds, add their Intelligence attribute
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + (roll + disadv) + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Success!");
                        currentConflict.Outcome = true;
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        MessageBox.Show("You rolled " + roll + ". Failure!");
                        currentConflict.Outcome = false;
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == null) //if ChoiceCheck is null, auto-fail the conflict
            {
                MessageBox.Show("You selected the Surrender option!");
                currentConflict.Outcome = false;
            }

            SetupAttriBox(); //update Attribute box
            UpdateConflict(currentConflict);
            UpdatePanel();
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
