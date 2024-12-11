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
    
    // Show Gameplay form and handle gameplay logic
    public partial class GamePlay : Form
    {
        // Define gameplay variables
        private Player generatedPlayer; // Variable for player
        private Conflict currentConflict; // Variable for conflict
        private Dice dice = new Dice(); // Variable for dice
        private string conflictResult; // Variable for conflict result
        private GameSetup GameSetupForm; // Reference to GameSetup form

        // Dictionary for attributes assigned to player
        public static Dictionary<int, string> attributeDictionary = new Dictionary<int, string>()
        {
            { 0, "Strength" },
            { 1, "Charisma" },
            { 2, "Intelligence" }
        };

        // List of conflicts (There will be 7 available conflicts in total)
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

        // List of choices for each conflict (Each conflict will have 3 choices)
        public static List<Choice> choiceList = new List<Choice>()
        {
            // Choices for Conflict 1
            new Choice { ConflictID = 1, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 3, ChoiceText = "Choice 3 [SURRENDER]", ChoiceCheck = null},

            // Choices for Conflict 2
            new Choice { ConflictID = 2, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},

            // Choices for Conflict 3
            new Choice { ConflictID = 3, ChoiceID = 1, ChoiceText = "Choice 1 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 3, ChoiceText = "Choice 3 [SURRENDER]", ChoiceCheck = null },

            // Choices for Conflict 4
            new Choice { ConflictID = 4, ChoiceID = 1, ChoiceText = "Choice 1 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 14, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 2, ChoiceText = "Choice 2 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 3, ChoiceText = "Choice 3 [SURRENDER]" , ChoiceCheck = null },

            // Choices for Conflict 5
            new Choice { ConflictID = 5, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 5, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 5, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            // Choices for Conflict 6
            new Choice { ConflictID = 6, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            // Choices for Conflict 7
            new Choice { ConflictID = 7, ChoiceID = 1, ChoiceText = "Choice 1 [STRENGTH]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 2, ChoiceText = "Choice 2 [CHARISMA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 3, ChoiceText = "Choice 3 [INTELLIGENCE]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },
        };

        // List of endings (There will be 8 available endings in total)
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
        
        // Constructor for GamePlay class with player and GameSetup form as input
        public GamePlay(Player createdPlayer, GameSetup GameSetupForm)
        {
            InitializeComponent();
            this.GameSetupForm = GameSetupForm; // Store the GameSetupForm reference
            generatedPlayer = createdPlayer; // Store player object
            // Evaluate player job
            if (generatedPlayer.Job.JobName == "Farmer")
            {
                // Display farmer character avatar and update stats
                characterAvtar.Image = Properties.Resources.avatar_farmer;
            }
            else if (generatedPlayer.Job.JobName == "Bard")
            {
                // Display bard character avatar and update stats
                characterAvtar.Image = Properties.Resources.avatar_bard;
            }
            else
            {
                // Display scholar character avatar and update stats
                characterAvtar.Image = Properties.Resources.avatar_scholar;
            }
            SetupAttriButes(); // Setup player attributes
            SetupChoices(); // Setup player choices
        }

        // Method to setup player attributes
        private void SetupAttriButes()
        {
            // Update attributes status bar based on attributes in player object
            statusBar.SetStat(generatedPlayer.Strength, generatedPlayer.Intelligence, generatedPlayer.Charisma);
        }

        // Method to setup choices
        private void SetupChoices()
        {
            // Update text for each buttons
            btn_Choice1.Text = choiceList[0].ChoiceText;
            btn_Choice2.Text = choiceList[1].ChoiceText;
            btn_Choice3.Text = choiceList[2].ChoiceText;

            // Update tags for each button
            btn_Choice1.Tag = choiceList[0].ChoiceID;
            btn_Choice2.Tag = choiceList[1].ChoiceID;
            btn_Choice3.Tag = choiceList[2].ChoiceID;

            SetupConflict(); // Setup player conflict
        }

        // Method to setup plater conflict
        private void SetupConflict()
        {
            // Setup conflict and update text and font size
            currentConflict = new Conflict();
            currentConflict = conflictList[0]; // Get 1st conflict
            lbl_ConflictText.Content = currentConflict.Text; // Update text
            lbl_ConflictText.FontSize = 18; // Update font size
        }

        // Method to Update choices
        private void UpdateChoices()
        {
            // Filter the choice which matches the current conflict ID
            var newChoiceList = choiceList.Where(choice => choice.ConflictID == currentConflict.ConflictID).ToList();
            // Choice list valid
            if (newChoiceList.Count > 0)
            {
                // Update text for each buttons
                btn_Choice1.Text = newChoiceList[0].ChoiceText;
                btn_Choice2.Text = newChoiceList[1].ChoiceText;
                btn_Choice3.Text = newChoiceList[2].ChoiceText;

                // Update tags for each button
                btn_Choice1.Tag = newChoiceList[0].ChoiceID;
                btn_Choice2.Tag = newChoiceList[1].ChoiceID;
                btn_Choice3.Tag = newChoiceList[2].ChoiceID;
            }
        }

        // Method to update conflict
        private void UpdateConflict(Conflict previousConflict)
        {
            // Get index of the previous conflict in the conflict list
            int indexOfPrev = conflictList.IndexOf(previousConflict);
            // Heading into Stage 2
            // Previous conflict index is 0
            if (indexOfPrev == 0)
            {
                // Check for outcome and update current conflict
                if (previousConflict.Outcome == true) currentConflict = conflictList[1];
                else currentConflict = conflictList[2];
            }
            // Previous conflict index is 1
            else if (indexOfPrev == 1)
            {
                // Check for outcome and update current conflict
                if (previousConflict.Outcome == true) currentConflict = conflictList[3];
                else currentConflict = conflictList[4];
            }
            // Previous conflict index is 2
            else if (indexOfPrev == 2)
            {
                // Check for outcome and update current conflict
                if (previousConflict.Outcome == true) currentConflict = conflictList[5];
                else currentConflict = conflictList[6];
            }
            // Previous conflict index is 3 and above
            else if (indexOfPrev == 3 || indexOfPrev == 4 || indexOfPrev == 5 || indexOfPrev == 6)
            {
                // Initiate ending
                SelectEnding(currentConflict);
            }
            // Update conflict text
            lbl_ConflictText.Content = currentConflict.Text;
        }

        // Method to select ending
        private void SelectEnding(Conflict penConflict)
        {
            // Evaluate conflict ID
            // Conflict ID is 4
            if (penConflict.ConflictID == 4)
            {
                // Check for outcome and update ending
                if (penConflict.Outcome == true) InitiateEnding(endingList[0]);
                else InitiateEnding(endingList[1]);
            }
            // Conflict ID is 5
            else if (penConflict.ConflictID == 5)
            {
                // Check for outcome and update ending
                if (penConflict.Outcome == true) InitiateEnding(endingList[2]);
                else InitiateEnding(endingList[3]);
            }
            // Conflict ID is 6
            else if (penConflict.ConflictID == 6)
            {
                // Check for outcome and update ending
                if (penConflict.Outcome == true) InitiateEnding(endingList[4]);
                else InitiateEnding(endingList[5]);
            }
            // Conflict ID is 7
            else if (penConflict.ConflictID == 7)
            {
                // Check for outcome and update ending
                if (penConflict.Outcome == true) InitiateEnding(endingList[6]);
                else InitiateEnding(endingList[7]);
            }
        }

        // Method to initiate ending
        private void InitiateEnding(Ending ending)
        {
            // Create instance of GameResult popup
            GameResult GameResult = new GameResult(ending.EndingText, generatedPlayer, GameSetupForm, this);
            GameResult.Show(); // Show Game result popup
            this.Hide(); // Hide Gameplay popup
        }

        // Method to handle Choice 1 button click
        private void btn_Choice1_Click(object sender, EventArgs e)
        {
            // Play mouse click sound effect
            SoundEffect.MouseClickSound();
            // Roll the dice
            int roll = dice.Roll();
            if (choiceList[0].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10;
                    if ((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false;  // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += choiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; 
                    if ((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += choiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else if (generatedPlayer.Strength == 10) //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == attributeDictionary[1]) // If ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; // Player with Charisma > 10 has Adv
                    if ((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += choiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += choiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == attributeDictionary[2]) // If ChoiceCheck is Int
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += choiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += choiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else // if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[0].ChoiceCheck == null) // if ChoiceCheck is null, auto-fail the conflict
            {
                conflictResult = "You selected the Surrender option!";
                currentConflict.Outcome = false; // Outcome is false
            }
            // Create instance of rolling dice window
            Dice_UI Dice_UI = new Dice_UI(conflictResult);
            Dice_UI.ShowDialog(); // Show rolling dice dialog
            SetupAttriButes(); // Update attributes
            UpdateConflict(currentConflict); // Update conflict
            UpdateChoices(); // Update choices
        }

        // Method to handle Choice 2 button click
        private void btn_Choice2_Click(object sender, EventArgs e)
        {
            // Play mouse click sound effect
            SoundEffect.MouseClickSound();
            // Roll the dice
            int roll = dice.Roll();
            if (choiceList[1].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; // Player with Str > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += choiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; // Player with Str < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += choiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == attributeDictionary[1]) // if ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += choiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += choiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == attributeDictionary[2]) // If ChoiceCheck is Intelligence
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += choiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += choiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[1].ChoiceCheck == null) // if ChoiceCheck is null, auto-fail the conflict
            {
                conflictResult = "You selected the Surrender option!";
                currentConflict.Outcome = false;
            }
            // Create instance of rolling dice window
            Dice_UI Dice_UI = new Dice_UI(conflictResult);
            Dice_UI.ShowDialog(); // Show rolling dice dialog
            SetupAttriButes(); // Update attributes
            UpdateConflict(currentConflict); // Update conflict
            UpdateChoices(); // Update choices
        }

        // Method to handle Choice 3 button click
        private void btn_Choice3_Click(object sender, EventArgs e)
        {
            // Play mouse click sound effect
            SoundEffect.MouseClickSound();
            // Roll the dice
            int roll = dice.Roll();
            if (choiceList[2].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; // Player with Str > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += choiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; // Player with Str < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += choiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == attributeDictionary[1]) // If ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += choiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += choiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == attributeDictionary[2]) //if ChoiceCheck is Intelligence
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += choiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += choiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < choiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (choiceList[2].ChoiceCheck == null) // If ChoiceCheck is null, auto-fail the conflict
            {
                conflictResult = "You selected the Surrender option!";
                currentConflict.Outcome = false;
            }
            // Create instance of rolling dice window
            Dice_UI Dice_UI = new Dice_UI(conflictResult);
            Dice_UI.ShowDialog(); // Show rolling dice dialog
            SetupAttriButes(); // Update attributes
            UpdateConflict(currentConflict); // Update conflict
            UpdateChoices(); // Update choices
        }

        // Method to handle closing of GameForm
        private void GamePlay_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit(); // Exit the application
        }
    }
}
