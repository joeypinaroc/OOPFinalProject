using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    // Conflict class
    public class Conflict
    {
        // Define conflict properties
        public int ConflictID { get; set; }
        public string Text { get; set; }
        public bool Outcome { get; set; }
    }

    // Choice class
    public class Choice
    {
        // Define choice properties
        public int ConflictID { get; set; }
        public int ChoiceID { get; set; }
        public string ChoiceText { get; set; }
        public string ChoiceCheck { get; set; }
        public int ChoiceCheckValue { get; set; }
        public int AdvantageBonus { get; set; }
        public int DisadvantageBonus { get; set; }
    }

    // Ending class
    public class Ending
    {
        // Define ending properties
        public int EndingID { get; set; }
        public string EndingText { get; set; }
    }
}
