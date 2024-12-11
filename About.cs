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
    public partial class About : Form
    {
        // About Popup constructor. Show the popup. 
        public About()
        {
            InitializeComponent();
            // Project details
            lbl_About.Text = "SODV2101: FINAL PROJECT\n" +
                "RAPID APPLICATION DEVELOPMENT\n\n" +
                "BY:\n\tGLENN PEREZ\n\tJOEY PINAROC\n\n" +
                "DECEMBER 2024";
        }

        // Event to close the About popup
        private void btn_OK_Click(object sender, EventArgs e)
        {
            // Play mouse click effect and close popup
            SoundEffect.MouseClickSound();
            this.Close();
        }
    }
}
