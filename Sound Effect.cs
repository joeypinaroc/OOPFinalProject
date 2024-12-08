using System;
using NAudio.Wave;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using FinalProject.Properties;
using System.IO;

namespace FinalProject
{
    public static class SoundEffect
    {
        private static SoundPlayer backgroundSound; // Background music object
        private static WaveStream mouseClickSound; // Mouse click audio object
        private static WaveOut mouseClickSoundPlayer; // Mouse click audio out object

        static SoundEffect()
        {
            // Initialize sounds
            backgroundSound = new SoundPlayer(Properties.Resources.background_music); // Set background music
            mouseClickSound = new AudioFileReader("../../Resources/click.wav");
            mouseClickSoundPlayer = new WaveOut();
            mouseClickSoundPlayer.Init(mouseClickSound);      
        }

        // Play background music
        public static void BackgroundMusic()
        {
            //backgroundSound?.PlayLooping(); // Play background music
        }

        // Play mouseclick sound
        public static void MouseClickSound()
        {
            mouseClickSoundPlayer.Stop();
            mouseClickSound.CurrentTime = new TimeSpan(0L);
            mouseClickSoundPlayer.Play();
        }
    }
}
