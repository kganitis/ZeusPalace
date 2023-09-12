using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace.Modules
{
    public partial class EmbeddedForm : Form
    {
        private readonly int initialWidth;
        private readonly int initialHeight;

        public EmbeddedForm()
        {
            InitializeComponent();
            initialWidth = Width;
            initialHeight = Height;
        }

        // Make the form not-resizable by reseting the size on resizing event
        private void EmbeddedForm_Resize(object sender, EventArgs e)
        {
            Width = initialWidth;
            Height = initialHeight;
        }
    }
}
