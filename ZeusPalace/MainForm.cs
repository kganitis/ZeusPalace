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
using ZeusPalace.Modules;
using ZeusPalace.Modules.Devices;
using ZeusPalace.Modules.Pool;
using ZeusPalace.Modules.Driving;
using ZeusPalace.Modules.Orders;

namespace ZeusPalace
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, EmbeddedForm> embeddedForms;
        private Button activeButton;
        private Form activeForm;
        private readonly Color defaultButtonBackColor;
        private readonly Color activeButtonBackColor;
        private readonly Font defaultButtonFont;
        private readonly Font activeButtonFont;
        private readonly int initialWidth;
        private readonly int initialHeight;

        public MainForm()
        {
            InitializeComponent();
            defaultButtonBackColor = buttonDevices.BackColor;
            defaultButtonFont = buttonDevices.Font;
            activeButtonBackColor = Color.NavajoWhite;
            activeButtonFont = new Font("Palatino Linotype", 21.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            initialWidth = Width;
            initialHeight = Height;
            embeddedForms = new Dictionary<Type, EmbeddedForm>();
            PreloadForms();
        }

        private void PreloadForms()
        {
            embeddedForms.Add(typeof(DevicesForm), new DevicesForm());
            embeddedForms.Add(typeof(PoolForm), new PoolForm());
            embeddedForms.Add(typeof(DrivingForm), new DrivingForm());
            embeddedForms.Add(typeof(CustomerOrdersForm), new CustomerOrdersForm());
            foreach (var embeddedForm in embeddedForms.Values)
            {
                embeddedForm.TopLevel = false;
                embeddedForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(embeddedForm);
                panelDesktopPane.Tag = embeddedForm;
            }
        }

        private void AlignLabelToCenter(Control label, Panel parentPanel)
        {
            int labelX = (parentPanel.Width - label.Width) / 2;
            int labelY = (parentPanel.Height - label.Height) / 2;
            label.Location = new Point(labelX, labelY);
        }

        private void ActivateButton(Button btn)
        {
            activeButton = btn;
            activeButton.BackColor = activeButtonBackColor;
            activeButton.Font = activeButtonFont;
        }

        private void DisableActiveButton()
        {
            if (activeButton != null)
            {
                activeButton.BackColor = defaultButtonBackColor;
                activeButton.Font = defaultButtonFont;
            }
        }

        private void ShowEmbeddedForm(EmbeddedForm embeddedForm, Button btn)
        {
            DisableActiveButton();
            ActivateButton(btn);
            activeForm = embeddedForm;
            activeForm.BringToFront();
            activeForm.Show();
        }

        private void buttonApartment_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(embeddedForms[typeof(DevicesForm)], (Button)sender);
        }

        private void buttonPool_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(embeddedForms[typeof(PoolForm)], (Button)sender);
        }

        private void buttonTrojanHorse_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(embeddedForms[typeof(DrivingForm)], (Button)sender);
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(embeddedForms[typeof(CustomerOrdersForm)], (Button)sender);
        }

        // Make the form not-resizable by reseting the size on resizing event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Width = initialWidth;
            Height = initialHeight;
        }
    }
}
