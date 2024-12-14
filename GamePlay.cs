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
        private List<Choice> currentChoiceList = new List<Choice>(); // Variable List<Choice> for current choices
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
            new Conflict { ConflictID = 1, Text = "As you approach the spooky mountain, you see a rusty old gate leading into darkness. An old dungeon, you think to yourself. You look around the gate and see what looks to be a lever.", Outcome = false},
            new Conflict { ConflictID = 2, Text = "The gate creaks open and you venture on. In the darkness, a shadowy presence envelopes you, and you hear a ghostly voice speak in an ancient language.", Outcome = false},
            new Conflict { ConflictID = 3, Text = "The gate somehow swings open! You peer into the darkness and sense a pair of void eyes staring at you. The sound of heavy, boney footsteps grow louder as a skeletal dog appears out of the void!", Outcome = false},
            new Conflict { ConflictID = 4, Text = "The now friendly shadow creature leads you through the darkness, and to another (seemingly) friendly entity. A skeletal dog! The skeletal dog approaches you, 'sniffing' the air around you.", Outcome = false},
            new Conflict { ConflictID = 5, Text = "The creature wraps its shadowy limbs around you, and violently drags you further into the dark. The creature drops you on a sheet of ice, on the far end of which is your cat resting on solid ground.", Outcome = false},
            new Conflict { ConflictID = 6, Text = "The skeletal dog wags its bony tail and barks at you to follow it into the dark. You both reach the end of the dungeon and the dog points to your cat resting on top of a pedestal! At the foot of the pedestal though, lies a massive ancient bear, sleeping on its stomach.", Outcome = false},
            new Conflict { ConflictID = 7, Text = "The dog lets out an ear-piercing howl and disappears into the darkness. You suddenly hear heavier footsteps approaching. A large ancient bear, with eyes burning in the dark. It snarls at you.", Outcome = false},
        };

        // List of choices for each conflict (Each conflict will have 3 choices)
        public static List<Choice> choiceList = new List<Choice>()
        {
            // Choices for Conflict 1
            new Choice { ConflictID = 1, ChoiceID = 1, ChoiceText = "Pull on the lever with all your might. [STR]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 2, ChoiceText = "Create a makeshift leverage extender and pull the lever. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 1, ChoiceID = 3, ChoiceText = "Scream into the darkness! [SUR]", ChoiceCheck = null},

            // Choices for Conflict 2
            new Choice { ConflictID = 2, ChoiceID = 1, ChoiceText = "Flex and appear large and strong before the shadow! [STR]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 2, ChoiceText = "Act weak and hope that the shadow creature takes pity on you. [CHA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 2, ChoiceID = 3, ChoiceText = "You recognize the ancient language, ask the shadow to let you pass. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},

            // Choices for Conflict 3
            new Choice { ConflictID = 3, ChoiceID = 1, ChoiceText = "Try to pet the skeletal dog. [CHA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 2, ChoiceText = "Pick up a human femur and offer it to the dog. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 3, ChoiceID = 3, ChoiceText = "Stay still, and hope the dog leaves. [SUR]", ChoiceCheck = null },

            // Choices for Conflict 4
            new Choice { ConflictID = 4, ChoiceID = 1, ChoiceText = "Pet and befriend the skeletal dog. [CHA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 14, AdvantageBonus = 2, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 2, ChoiceText = "Crouch to the dog's level and allow it to 'sniff' you. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 4, ChoiceID = 3, ChoiceText = "Stare into the void of the dog's eyes. [SUR]" , ChoiceCheck = null },

            // Choices for Conflict 5
            new Choice { ConflictID = 5, ChoiceID = 1, ChoiceText = "Sprint across the ice and leap towards your cat! [STR]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 5, ChoiceID = 2, ChoiceText = "Slowly walk across the ice while maintaining your balance. [SUR]", ChoiceCheck = null},
            new Choice { ConflictID = 5, ChoiceID = 3, ChoiceText = "Penguin slide across the ice to get to solid ground! [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            // Choices for Conflict 6
            new Choice { ConflictID = 6, ChoiceID = 1, ChoiceText = "Use all your leg strength to jump to the top of the pedestal. [STR]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 2, ChoiceText = "Use nonverbal signals to convince your cat to jump down the pedestal! [CHA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 10, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 6, ChoiceID = 3, ChoiceText = "Pick your steps carefully and sneak past the sleeping bear. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },

            // Choices for Conflict 7
            new Choice { ConflictID = 7, ChoiceID = 1, ChoiceText = "Muster all your strength and punch the bear! [STR]", ChoiceCheck = attributeDictionary[0], ChoiceCheckValue = 12, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 2, ChoiceText = "Try to befriend the bear. [CHA]", ChoiceCheck = attributeDictionary[1], ChoiceCheckValue = 12, AdvantageBonus = 1, DisadvantageBonus = -1},
            new Choice { ConflictID = 7, ChoiceID = 3, ChoiceText = "Stand tall and try to scare the bear. [INT]", ChoiceCheck = attributeDictionary[2], ChoiceCheckValue = 12, AdvantageBonus = 2, DisadvantageBonus = -1 },
        };

        // List of endings (There will be 8 available endings in total)
        public static List<Ending> endingList = new List<Ending>()
        {
            new Ending { EndingID = 1, EndingText = "The skeletal dog leads you to where your cat is! You grab your cat tight and get portaled back to the dungeon entrance!"},
            new Ending { EndingID = 2, EndingText = "The skeletal dog emits a ghastly howl and runs back into the darkness! You chase after it, only to find it hunched over a small bloody corpse. Your cat! It then turns to you..."},
            new Ending { EndingID = 3, EndingText = "You reach solid ground and reunite with your cat. They point you to a secret ladder which leads to the outside world!"},
            new Ending { EndingID = 4, EndingText = "You hear the ice break and you sink to the cold depths below."},
            new Ending { EndingID = 5, EndingText = "You successfully reunite with your cat! Touching them triggers a portal which takes you both back to the dungeon entrance!"},
            new Ending { EndingID = 6, EndingText = "The ancient bear opens its burning eyes, stands up, and swings its claw at you, killing you with one swipe."},
            new Ending { EndingID = 7, EndingText = "The bear winces, and then leaves you alone. You run further into the darkness until you find your cat sleeping in a corner. You both venture back across the dungeon to safety."},
            new Ending { EndingID = 8, EndingText = "The bear pauses, and in a split second bites your head clean off!"},
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
            // Setup initial choices
            currentChoiceList.Add(choiceList[0]);
            currentChoiceList.Add(choiceList[1]);
            currentChoiceList.Add(choiceList[2]);

            // Update text for each buttons
            btn_Choice1.Text = currentChoiceList[0].ChoiceText;
            btn_Choice2.Text = currentChoiceList[1].ChoiceText;
            btn_Choice3.Text = currentChoiceList[2].ChoiceText;

            // Update tags for each button
            btn_Choice1.Tag = currentChoiceList[0].ChoiceID;
            btn_Choice2.Tag = currentChoiceList[1].ChoiceID;
            btn_Choice3.Tag = currentChoiceList[2].ChoiceID;

            SetupConflict(); // Setup player conflict
        }

        // Method to setup plater conflict
        private void SetupConflict()
        {
            // Setup conflict and update text and font size
            currentConflict = new Conflict();
            currentConflict = conflictList[0]; // Get 1st conflict
            lbl_ConflictText.Content = currentConflict.Text; // Update text
            lbl_ConflictText.WrapWidth = 800;
            lbl_ConflictText.FontSize = 14; // Update font size
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

            currentChoiceList = newChoiceList; // Update currentChoiceList with new choices
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
            if (currentChoiceList[0].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10;
                    if ((roll + adv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false;  // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += currentChoiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; 
                    if ((roll - disadv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += currentChoiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else if (generatedPlayer.Strength == 10) //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[0].ChoiceCheck == attributeDictionary[1]) // If ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; // Player with Charisma > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += currentChoiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += currentChoiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[0].ChoiceCheck == attributeDictionary[2]) // If ChoiceCheck is Int
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += currentChoiceList[0].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; //player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += currentChoiceList[0].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else // if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[0].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[0].ChoiceCheck == null) // if ChoiceCheck is null, auto-fail the conflict
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
            if (currentChoiceList[1].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; // Player with Str > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += currentChoiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; // Player with Str < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += choiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[1].ChoiceCheck == attributeDictionary[1]) // if ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += currentChoiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += currentChoiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[1].ChoiceCheck == attributeDictionary[2]) // If ChoiceCheck is Intelligence
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += currentChoiceList[1].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += currentChoiceList[1].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[1].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[1].ChoiceCheck == null) // if ChoiceCheck is null, auto-fail the conflict
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
            if (currentChoiceList[2].ChoiceCheck == attributeDictionary[0]) // If ChoiceCheck is Str
            {
                if (generatedPlayer.Strength > 10)
                {
                    int adv = generatedPlayer.Strength - 10; // Player with Str > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Strength Adv fails, reduce their Strength attribute   
                        generatedPlayer.Strength += currentChoiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Strength < 10)
                {
                    int disadv = 10 - generatedPlayer.Strength; // Player with Str < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Strength Adv succeeds, add their Strength attribute
                        generatedPlayer.Strength += currentChoiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Strength = 10, no added Adv
                {
                    if (roll >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[2].ChoiceCheck == attributeDictionary[1]) // If ChoiceCheck is Charisma
            {
                if (generatedPlayer.Charisma > 10)
                {
                    int adv = generatedPlayer.Charisma - 10; //player with Cha > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Charisma Adv fails, reduce their Charisma attribute   
                        generatedPlayer.Charisma += currentChoiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Charisma < 10)
                {
                    int disadv = 10 - generatedPlayer.Charisma; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Charisma Adv succeeds, add their Charisma attribute
                        generatedPlayer.Charisma += currentChoiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Charisma = 10, no added Adv
                {
                    if (roll >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[2].ChoiceCheck == attributeDictionary[2]) //if ChoiceCheck is Intelligence
            {
                if (generatedPlayer.Intelligence > 10)
                {
                    int adv = generatedPlayer.Intelligence - 10; // Player with Int > 10 has Adv
                    if ((roll + adv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if ((roll + adv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + adv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                        // If player with Intelligence Adv fails, reduce their Intelligence attribute   
                        generatedPlayer.Intelligence += currentChoiceList[2].DisadvantageBonus;
                    }
                }
                else if (generatedPlayer.Intelligence < 10)
                {
                    int disadv = 10 - generatedPlayer.Intelligence; // Player with Cha < 10 has Disadv
                    if ((roll - disadv) >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                        // If player without Intelligence Adv succeeds, add their Intelligence attribute
                        generatedPlayer.Intelligence += currentChoiceList[2].AdvantageBonus;
                    }
                    else if ((roll - disadv) < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + (roll + disadv) + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
                else //if no Adv: Intelligence = 10, no added Adv
                {
                    if (roll >= currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Success!";
                        currentConflict.Outcome = true; // Outcome is true
                    }
                    else if (roll < currentChoiceList[2].ChoiceCheckValue)
                    {
                        conflictResult = "You rolled " + roll + ". Failure!";
                        currentConflict.Outcome = false; // Outcome is false
                    }
                }
            }
            else if (currentChoiceList[2].ChoiceCheck == null) // If ChoiceCheck is null, auto-fail the conflict
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
