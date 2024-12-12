using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Properties
{
    public partial class TextHolder : UserControl
    {
        public TextHolder()
        {
            InitializeComponent();
            //TextContent.AutoSize = true;
        }

        // Property to access or modify the content dynamically
        public string Content
        {
            get => TextContent.Text;
            set => TextContent.Text = value;
        }

        // Property to modify the font size dynamically
        public int FontSize
        {
            get => (int)TextContent.Font.Size; // Get the current font size
            set
            {
                TextContent.Font = new Font(TextContent.Font.FontFamily, value, TextContent.Font.Style);
            }
        }

    }
}
