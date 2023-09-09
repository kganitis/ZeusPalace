using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeusPalace
{
    public partial class BaseForm : Form
    {
        private Form activeForm;

        public BaseForm()
        {
            InitializeComponent();
            AlignLabelToCenter(labelLogo, panelLogo);
        }

        private void AlignLabelToCenter(Control label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            int labelY = (parentPanel.Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        private void ActivateButton(Button sender)
        {

        }

        private void SetTitle(string title)
        {
            labelTitle.Text = title;
            AlignLabelToCenter(labelTitle, panelTitle);
        }

        private void OpenChildForm(Form childForm, Button sender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(sender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktopPane.Controls.Add(childForm);
            panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            SetTitle(childForm.Text);
        }
    }
}
