using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Player
    {
        public string Name { get; set; }
        public Job Job { get; set; }
        public int Strength { get; set; }
        public int Charisma { get; set; }
        public int Intelligence { get; set; }
        public Player()
        {
            // default constructor
        }
        public Player(string name, Job job)
        {
            Name = name;
            Job = job;
            if (Job.JobName == "Farmer")
            {
                Strength = 13;
                Charisma = 9;
                Intelligence = 10;
            }
            else if (Job.JobName == "Bard")
            {
                Strength = 10;
                Charisma = 13;
                Intelligence = 9;
            }
            else if (Job.JobName == "Scholar")
            {
                Strength = 9;
                Charisma = 10;
                Intelligence = 13;
            }
        }
    }
    public class PlayerGeneratedEventArgs : EventArgs
    {
        public Player CreatedPlayer { get; set; }

    }
    public class PlayerGenerator
    {
        public delegate void PlayerGeneratedEventHandler(object sender, PlayerGeneratedEventArgs e);
        public event PlayerGeneratedEventHandler PlayerGenerated; 

        public void Generate(string name, Job job)
        {
            Player player = new Player(name, job);
            if(player.Job.JobName == "Farmer")
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

            OnPlayerGenerated(player);
        }
        protected virtual void OnPlayerGenerated(Player player)
        {
            if (PlayerGenerated != null) PlayerGenerated(this, new PlayerGeneratedEventArgs() { CreatedPlayer = player });
        }
    }
    public class Job
    {
        public int Id { get; set; }
        public string JobName { get; set; }
    }

}
