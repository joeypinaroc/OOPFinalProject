using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        // Property to access or modify the content dynamically
        public string Content
        {
            get => TextContent.Text;
            set => TextContent.Text = value;
        }
    }
}
