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
using ZeusPalace.Properties;

namespace ZeusPalace
{
    public partial class MainForm : Form
    {
        AppController appController = AppController.Instance;

        // Forms
        private List<EmbeddedForm> embeddedForms;
        private HubForm hubForm;
        private DevicesForm devicesForm;
        private PoolForm poolForm;
        private TrojanHorseForm trojanHorseForm;
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
                SetButtonsVisible(currentForm != hubForm);
            }
        }

        // UI fields
        private Button activeButton;
        private readonly Font defaultButtonFont;
        private readonly Font activeButtonFont;
        private readonly int initialWidth;
        private readonly int initialHeight;

        public MainForm()
        {
            InitializeComponent();

            // Buttons
            defaultButtonFont = buttonDevices.Font;
            activeButtonFont = new Font(defaultButtonFont.Name, 19F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SetButtonsVisible(false);

            // Keep the initial dimensions so we can reset them later
            initialWidth = Width;
            initialHeight = Height;

            PreloadForms();

            // Hub Form
            hubForm.pictureBoxDevices.Click += PictureBoxDevices_Click;
            hubForm.pictureBoxPoolOrHorse.Click += PictureBoxPoolOrHorse_Click;
            hubForm.pictureBoxOrders.Click += PictureBoxOrders_Click;
            //hubForm.timerLoading.Tick += TimerLoading_Tick;

            CurrentForm = hubForm;

            HandleUserPermissions();
        }

        /*private void TimerLoading_Tick(object sender, EventArgs e)
        {
            if (appController.LoginRequired)
            {
                flowLayoutPanelMenu.BackgroundImage = Resources.background_login_menu;
            }
            else
            {
                flowLayoutPanelMenu.BackgroundImage = Resources.background_home_menu;
            }
        }*/

        private void PictureBoxOrders_Click(object sender, EventArgs e)
        {
            buttonOrders_Click(buttonOrders, e);
        }

        private void PictureBoxPoolOrHorse_Click(object sender, EventArgs e)
        {
            if (appController.Customer.Accommodation.Type == AccommodationType.Apartment)
            {
                buttonPool_Click(buttonPool, e);
            }
            else
            {
                buttonTrojanHorse_Click(buttonTrojanHorse, e);
            }
        }

        private void PictureBoxDevices_Click(object sender, EventArgs e)
        {
            buttonDevices_Click(buttonDevices, e);
        }

        private void HandleUserPermissions()
        {
            bool buttonPoolVisible = appController.Customer.Accommodation.Type == AccommodationType.Apartment;
            bool buttonTrojanHorseVisible = appController.User.Role == UserRole.Customer &&
                                    appController.Customer.Accommodation.Type == AccommodationType.TrojanHorse &&
                                    appController.ComputerType == ComputerType.Private;
            bool buttonOrdersVisible = appController.User.Role == UserRole.Customer;

            flowLayoutPanelMenu.Controls.Clear();

            flowLayoutPanelMenu.Controls.Add(buttonDevices);
            if (buttonPoolVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonPool);
            }
            if (buttonTrojanHorseVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonTrojanHorse);
            }
            if (buttonOrdersVisible)
            {
                flowLayoutPanelMenu.Controls.Add(buttonOrders);
            }
            else
            {
                hubForm.panelOrders.Visible = false;
            }
        }

        private void PreloadForms()
        {
            hubForm = new HubForm();
            if (appController.Customer.Accommodation.Type == AccommodationType.Apartment)
            {
                devicesForm = new DevicesForm();
            }
            else
            {
                devicesForm = new TrojanHorseDevicesForm();
                ((TrojanHorseDevicesForm)devicesForm).WheelPictureBox.Click += WheelPictureBox_Click;
                buttonDevices.Image = Resources.devices_th_icon;
            }
            poolForm = new PoolForm();
            trojanHorseForm = new TrojanHorseForm(this);
            customerOrdersForm = new CustomerOrdersForm();

            embeddedForms = new List<EmbeddedForm>
            {
                hubForm, devicesForm, poolForm, trojanHorseForm, customerOrdersForm
            };

            foreach (var embeddedForm in embeddedForms)
            {
                embeddedForm.TopLevel = false;
                embeddedForm.Dock = DockStyle.Fill;
                panelDesktopPane.Controls.Add(embeddedForm);
            }
        }

        private void WheelPictureBox_Click(object sender, EventArgs e)
        {
            buttonTrojanHorse_Click(buttonTrojanHorse, e);
        }

        private string GetImageName(Button btn)
        {
            string imageName = string.Empty;
            if (btn == buttonDevices)
            {
                imageName += "devices";
                if (appController.Customer.Accommodation.Type == AccommodationType.TrojanHorse)
                {
                    imageName += "_th";
                }
            }
            else if (btn == buttonPool)
            {
                imageName += "pool";
            }
            else if (btn == buttonTrojanHorse)
            {
                imageName = "trojanhorse";

            }
            else if (btn == buttonOrders)
            {
                imageName = "orders";
            }
            imageName += "_icon";
            return imageName;
        }

        private void HighlightButton(Button btn)
        {
            btn.Image = (Image)Resources.ResourceManager.GetObject(GetImageName(btn) + "_glow");
        }

        private void UnhighlightButton(Button btn)
        {
            btn.Image = (Image)Resources.ResourceManager.GetObject(GetImageName(btn));
        }

        private void ActivateButton(Button btn)
        {
            activeButton = btn;
            activeButton.Font = activeButtonFont;
            HighlightButton(activeButton);
        }

        private void DisableActiveButton()
        {
            if (activeButton != null)
            {
                activeButton.Font = defaultButtonFont;
                UnhighlightButton(activeButton);
            }
        }

        private void SetButtonsVisible(bool visible)
        {
            foreach (Button btn in flowLayoutPanelMenu.Controls.OfType<Button>())
            {
                btn.Visible = visible;
            }
        }

        private void ShowEmbeddedForm(EmbeddedForm embeddedForm, Button btn)
        {
            DisableActiveButton();
            ActivateButton(btn);
            CurrentForm = embeddedForm;
        }

        private void buttonDevices_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(devicesForm, (Button)sender);
        }

        private void buttonPool_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(poolForm, (Button)sender);
        }

        private void buttonTrojanHorse_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(trojanHorseForm, (Button)sender);
        }

        private void buttonOrders_Click(object sender, EventArgs e)
        {
            ShowEmbeddedForm(customerOrdersForm, (Button)sender);
        }

        // Make the form not-resizable by reseting the size on resizing event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            Width = initialWidth;
            Height = initialHeight;
        }

        private void buttonMenu_MouseEnter(object sender, EventArgs e)
        {
            if ((Button)sender != activeButton)
            {
                HighlightButton((Button)sender);
                ((Button)sender).Cursor = Cursors.Hand;
            }
        }

        private void buttonMenu_MouseLeave(object sender, EventArgs e)
        {
            if ((Button)sender != activeButton)
            {
                UnhighlightButton((Button)sender);
                ((Button)sender).Cursor = Cursors.Default;
            }
        }
    }
}
