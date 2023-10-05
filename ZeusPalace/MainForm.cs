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
using ZeusPalace.Entities.Accommodation;
using System.Diagnostics;

namespace ZeusPalace
{
    public partial class MainForm : Form
    {
        AppController appController = AppController.Instance;

        // Forms
        private Dictionary<Type, EmbeddedForm> embeddedForms;
        private DevicesForm devicesForm;
        private PoolForm poolForm;
        private TrojanHorseForm templeCourtyardForm;
        private CustomerOrdersForm customerOrdersForm;

        // Current form
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

        // UI fields
        private Button activeButton;
        private readonly Color defaultButtonBackColor;
        private readonly Font defaultButtonFont;
        private readonly Font activeButtonFont;
        private readonly int initialWidth;
        private readonly int initialHeight;

        public MainForm()
        {
            InitializeComponent();

            // Buttons
            defaultButtonBackColor = buttonDevices.BackColor;
            defaultButtonFont = buttonDevices.Font;
            activeButtonFont = new Font(defaultButtonFont.Name, 21.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foreach (Button btn in flowLayoutPanelMenu.Controls.OfType<Button>())
            {
                btn.FlatAppearance.BorderColor = ColorPicker.GetTint(defaultButtonBackColor, 10);
                btn.FlatAppearance.MouseOverBackColor = ColorPicker.GetTint(defaultButtonBackColor, 10);
                btn.FlatAppearance.MouseDownBackColor = btn.FlatAppearance.MouseOverBackColor;
            }

            HandleUserPermissions();

            // Keep the initial dimensions so we can reset them later
            initialWidth = Width;
            initialHeight = Height;

            PreloadForms();
        }

        private void HandleUserPermissions()
        {
            bool buttonPoolVisible = appController.Customer.Accommodation.Type == AccommodationType.Apartment;
            bool buttonDrivingVisible = appController.User.Role == UserRole.Customer &&
                                    appController.Customer.Accommodation.Type == AccommodationType.TrojanHorse &&
                                    appController.ComputerType == ComputerType.Private;
            bool buttonOrdersVisible = appController.User.Role == UserRole.Customer;

            flowLayoutPanelMenu.Controls.Clear();

            flowLayoutPanelMenu.Controls.Add(buttonDevices);
            if (buttonPoolVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonPool);
            }
            if (buttonDrivingVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonDriving);
            }
            if (buttonOrdersVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonOrders);
            }
        }

        private void PreloadForms()
        {
            devicesForm = new DevicesForm();
            poolForm = new PoolForm();
            templeCourtyardForm = new TrojanHorseForm(this);
            customerOrdersForm = new CustomerOrdersForm();

            embeddedForms = new Dictionary<Type, EmbeddedForm>
            {
                { typeof(DevicesForm), devicesForm },
                { typeof(PoolForm), poolForm },
                { typeof(TrojanHorseForm), templeCourtyardForm },
                { typeof(CustomerOrdersForm), customerOrdersForm }
            };

            foreach (var embeddedForm in embeddedForms.Values)
            {
                embeddedForm.TopLevel = false;
                embeddedForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(embeddedForm);
            }
        }

        protected void AlignLabelToCenter(Control label, Panel parentPanel)
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
            ShowEmbeddedForm(embeddedForms[typeof(TrojanHorseForm)], (Button)sender);
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
