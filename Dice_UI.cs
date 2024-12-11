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
    // Show Dice Roll popup and handle logic
    public partial class Dice_UI : Form
    {
        // Constructor for Dice Roll Popup
        public Dice_UI(string result)
        {
            // Initialize component and UI state
            InitializeComponent();
            // Hide button and set text and font size
            btn_Continue.Visible = false;
            lbl_ConflictResult.Content = "Rolling Dice...";
            lbl_ConflictResult.FontSize = 18;

            // Path to temporary file
            string videoPath = Path.Combine(Path.GetTempPath(), "tempVideo.mp4");
            // Write the video resource to the file only if it does not exist
            if (!File.Exists(videoPath))
            {
                byte[] videoData = Properties.Resources.rollingdice;
                using (var fileStream = new FileStream(videoPath, FileMode.Create, FileAccess.Write))
                {
                    // Write video file as file stream
                    fileStream.Write(videoData, 0, videoData.Length);
                }
            }
            media_RollingDice.URL = videoPath; // Set the media player URL to the temporary file path
            media_RollingDice.uiMode = "none"; // Set UI mode to none
            media_RollingDice.settings.setMode("loop", true); // Continuous loop
            media_RollingDice.Ctlcontrols.stop(); // Stop video if currently playing
            media_RollingDice.Ctlcontrols.play(); // Play video
            SoundEffect.RollingDiceSound(); // Play rolling dice sound effect
            ShowResultWithDelay(result); // Delay and then update the result
        }

        // Async method to handle the delay and update the label
        private async void ShowResultWithDelay(string result)
        {
            await Task.Delay(3000); // Wait for 3 seconds
            lbl_ConflictResult.Content = result; // Update the label content
            btn_Continue.Visible = true; // Show button
        }

        // Even to handle clicking the continue button
        private void btn_Continue_Click(object sender, EventArgs e)
        {
            SoundEffect.MouseClickSound(); // Play mouse click sound effect
            media_RollingDice.Ctlcontrols.stop(); // Stop rolling dice video
            media_RollingDice.close(); // Close media player
            this.Close(); // Close the popup
        }
    }
}
