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
    public partial class Stats : UserControl
    {
        public Stats()
        {
            InitializeComponent();
        }

        public class CustomProgressBar : ProgressBar
        {
            public Color BarColor { get; set; } = Color.Green;

            public CustomProgressBar()
            {
                // Enable double-buffering for smoother rendering
                this.SetStyle(ControlStyles.UserPaint, true);
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rect = this.ClientRectangle;
                Graphics g = e.Graphics;

                // Draw the background
                g.FillRectangle(new SolidBrush(this.BackColor), rect);

                rect.Width = (int)(rect.Width * ((double)this.Value / this.Maximum));

                g.FillRectangle(new SolidBrush(this.BarColor), rect);

                g.DrawRectangle(Pens.Black, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        // Property to modify attribute display
        public void  SetStat(int strength, int intelligence, int charisma)
        {
            progressBar_Str.Value = strength;
            progressBar_Int.Value = intelligence;
            progressBar_Chr.Value = charisma;
        }

    }
}
