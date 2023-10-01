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
using ZeusPalace.Modules.PoolControl;
using ZeusPalace.Modules.Driving;
using ZeusPalace.Modules.Orders;
using ZeusPalace.Entities.Pool;

namespace ZeusPalace
{
    public partial class MainForm : Form
    {
        public event EventHandler CurrentFormChanged;
        private EmbeddedForm currentForm;
        public EmbeddedForm CurrentForm
        {
            get { return currentForm; }
            private set
            {
                currentForm = value;
                currentForm.BringToFront();
                currentForm.Show();
                CurrentFormChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private readonly Dictionary<Type, EmbeddedForm> embeddedForms;
        private Button activeButton;
        private DevicesForm devicesForm;
        private PoolForm poolForm;
        private DrivingForm drivingForm;
        private CustomerOrdersForm customerOrdersForm;
        private readonly Color defaultButtonBackColor;
        private readonly Font defaultButtonFont;
        private readonly Font activeButtonFont;
        private readonly int initialWidth;
        private readonly int initialHeight;

        public MainForm()
        {
            InitializeComponent();
            defaultButtonBackColor = buttonDevices.BackColor;
            defaultButtonFont = buttonDevices.Font;
            activeButtonFont = new Font("Calibri", 21.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foreach (Button btn in panelMenu.Controls.OfType<Button>())
            {
                btn.FlatAppearance.BorderColor = ColorPicker.GetTint(defaultButtonBackColor, 10);
                btn.FlatAppearance.MouseOverBackColor = ColorPicker.GetTint(defaultButtonBackColor, 10);
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
            }
            initialWidth = Width;
            initialHeight = Height;
            embeddedForms = new Dictionary<Type, EmbeddedForm>();
            PreloadForms();
        }

        private void PreloadForms()
        {
            devicesForm = new DevicesForm();
            poolForm = new PoolForm();
            drivingForm = new DrivingForm();
            customerOrdersForm = new CustomerOrdersForm();
            embeddedForms.Add(typeof(DevicesForm), devicesForm);
            embeddedForms.Add(typeof(PoolForm), poolForm);
            embeddedForms.Add(typeof(DrivingForm), drivingForm);
            embeddedForms.Add(typeof(CustomerOrdersForm), customerOrdersForm);
            foreach (var embeddedForm in embeddedForms.Values)
            {
                embeddedForm.TopLevel = false;
                embeddedForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(embeddedForm);
            }
        }

        public EmbeddedForm GetEmbeddedForm(Type type)
        {
            return embeddedForms[type];
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
            activeButton.BackColor = ColorPicker.GetTint(defaultButtonBackColor, 10);
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
            CurrentForm = embeddedForm;
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

        public void SetPersonInPool(bool personInPool)
        {
            poolForm.SetPersonInPool(personInPool);
        }
    }
}
