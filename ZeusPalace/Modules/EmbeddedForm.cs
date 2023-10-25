using System.Drawing;
using System.Windows.Forms;

namespace ZeusPalace.Modules
{
    public partial class EmbeddedForm : Form
    {
        public string OnlineHelpSection = "#";

        public EmbeddedForm()
        {
            InitializeComponent();
        }

        protected void AlignLabelToCenter(Control label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            int labelY = (parentPanel.Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        protected void AlignLabelToCenterHorizontally(Control label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            label.Location = new Point(labelX, label.Location.Y);
        }
    }
}
