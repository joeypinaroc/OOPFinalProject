using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        // Define properties of player
        public string Name { get; set; }
        public Job Job { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public Player()
        {
            // default constructor
        }
        
        // Player class constructor with name and job as input
        public Player(string name, Job job)
        {
            // Store name and job
            Name = name;
            Job = job;
            // Evaluate job and apply corresponding attributes
            if (Job.JobName == "Farmer")
            {
                // Strength is the main attribute of farmer
                Strength = 13;
                Charisma = 9;
                Intelligence = 10;
            }
            else if (Job.JobName == "Bard")
            {
                // Charisma is the main attribute of bard
                Strength = 10;
                Charisma = 13;
                Intelligence = 9;
            }
            else if (Job.JobName == "Scholar")
            {
                // Intelligence is the main attribute of scholar
                Strength = 9;
                Charisma = 10;
                Intelligence = 13;
            }
        }
    }
    
    // Player Generated event argument
    public class PlayerGeneratedEventArgs : EventArgs
    {
        // Update created player properties
        public Player CreatedPlayer { get; set; }
    }

    // Class for Player Generator
    public class PlayerGenerator
    {
        public delegate void PlayerGeneratedEventHandler(object sender, PlayerGeneratedEventArgs e);
        public event PlayerGeneratedEventHandler PlayerGenerated; 

        // Method to generate a player
        public void Generate(string name, Job job)
        {
            // Generate a player with specified name and job
            Player player = new Player(name, job);
            // Evaluate job and apply corresponding attributes
            if (player.Job.JobName == "Farmer")
            {
                player.Strength = 13;
                player.Charisma = 9;
                player.Intelligence = 10;
            }
            else if (player.Job.JobName == "Bard")
            {
                player.Strength = 10;
                player.Charisma = 13;
                player.Intelligence = 9;
            }
            else if (player.Job.JobName == "Scholar")
            {
                player.Strength = 9;
                player.Charisma = 10;
                player.Intelligence = 13;
            }

            OnPlayerGenerated(player); // Call OnPlayerGenerated method
        }
        
        // Method when a player is generated
        protected virtual void OnPlayerGenerated(Player player)
        {
            if (PlayerGenerated != null) PlayerGenerated(this, new PlayerGeneratedEventArgs() { CreatedPlayer = player });
        }
    }
    
    // Job class
    public class Job
    {
        // Define job properties
        public int Id { get; set; }
        public string JobName { get; set; }
    }

}
