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
    public partial class GameStoryIntro : Form
    {
        public GameStoryIntro()
        {
            InitializeComponent();

            // Setup Story Intro text
            lbl_Intro.Content = "Your story begins with you living your normal cozy medieval-fantasy life with your completely normal companion cat, Mr. Mustard. One night," +
                " as if prompted by some eldritch cosmic magic, Mr. Mustard starts levitating! He flies across your home, bolts out your door, and beams towards a spooky mountain. " +
                "You journey to the mountain going after Mr. Mustard.";
            lbl_Intro.WrapWidth = 600;
            lbl_Intro.FontSize = 14;

            lbl_MrMustard.Content = "Mr. Mustard";
            lbl_MrMustard.WrapWidth = 200;
            lbl_MrMustard.FontSize = 10;
        }

        private void btn_IntroNext_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound(); // Play mouse click sound effect
            this.Close();
        }
    }
}
