using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Dice_UI : Form
    {
        public Dice_UI(string result)
        {
            InitializeComponent();
            btn_Continue.Visible = false;
            lbl_ConflictResult.Content = "Rolling Dice...";
            lbl_ConflictResult.FontSize = 18;

            // Path to temporary file
            string videoPath = Path.Combine(Path.GetTempPath(), "tempVideo.mp4");
            // Write the video resource to the file only if it doesn't already exist
            if (!File.Exists(videoPath))
            {
                byte[] videoData = Properties.Resources.rollingdice;
                using (var fileStream = new FileStream(videoPath, FileMode.Create, FileAccess.Write))
                {
                    fileStream.Write(videoData, 0, videoData.Length);
                }
            }
            // Set the media player URL to the temporary file path
            media_RollingDice.URL = videoPath;
            media_RollingDice.uiMode = "none";
            media_RollingDice.settings.setMode("loop", true);
            media_RollingDice.Ctlcontrols.stop();
            media_RollingDice.Ctlcontrols.play();
            SoundEffect.RollingDiceSound();
            // Delay and then update the result
            ShowResultWithDelay(result);
        }

        // Async method to handle the delay and update the label
        private async void ShowResultWithDelay(string result)
        {
            await Task.Delay(3000); // Wait for 3 seconds
            lbl_ConflictResult.Content = result; // Update the label content
            btn_Continue.Visible = true;
        }

        // Even to handle clicking the continue button
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound();
            media_RollingDice.Ctlcontrols.stop();
            media_RollingDice.close();
            this.Close();
        }
    }
}
