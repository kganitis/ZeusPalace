using System;
using System.Drawing;
using System.Windows.Forms;
using ZeusPalace.Properties;

namespace ZeusPalace.Modules
{
    public partial class HubForm : ZeusPalace.Modules.EmbeddedForm
    {
        AppController appController = AppController.Instance;

        public HubForm()
        {
            InitializeComponent();
            OnlineHelpSection = "#toc-Αρχική%20οθόνη";

            if (appController.Customer.Accommodation.Type == Entities.Accommodation.AccommodationType.TrojanHorse)
            {
                pictureBoxDevices.Image = Resources.devices_th_button;

                pictureBoxPoolOrHorse.Image = Resources.trojanhorse_button;
                labelPoolOrHorse.Text = "ΔΟΥΡΕΙΟΣ ΙΠΠΟΣ";
                AlignLabelToCenterHorizontally(labelPoolOrHorse, panelPoolOrHorse);
            }

            timerLoading.Start();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            timerLoading.Stop();
            
            if (appController.LoginRequired)
            {
                BackgroundImage = Resources.background_login;
                panelLogin.Visible = true;
                OnlineHelpSection = "#toc-Σύνδεση%20στο%20σύστημα";
            }
            else
            {
                panelHub.BringToFront();
                panelHub.Visible = true;
            }
        }

        private void buttonLogin_Click(object sender, System.EventArgs e)
        {
            if (textBoxUsername.Text.Equals(appController.User.Username) && textBoxPassword.Text.Equals(appController.User.Password))
            {
                panelLogin.Visible = false;
                panelHub.BringToFront();
                panelHub.Visible = true;
                OnlineHelpSection = "#toc-Αρχική%20οθόνη";
            }
            else
            {
                MessageBox.Show("Λανθασμένα στοιχεία εισόδου");
            }
        }

        private string GetImageName(PictureBox pictureBox)
        {
            string imageName = string.Empty;
            if (pictureBox == pictureBoxDevices)
            {
                imageName += "devices";
                if (appController.Customer.Accommodation.Type == Entities.Accommodation.AccommodationType.TrojanHorse)
                {
                    imageName += "_th";
                }
            }
            else if (pictureBox == pictureBoxPoolOrHorse)
            {
                if (appController.Customer.Accommodation.Type == Entities.Accommodation.AccommodationType.TrojanHorse)
                {
                    imageName += "trojanhorse";
                }
                else
                {
                    imageName += "pool";
                }
            }
            else if (pictureBox == pictureBoxOrders)
            {
                imageName = "orders";
            }
            imageName += "_button";
            return imageName;
        }

        private void pictureBox_MouseEnter(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = (Image)Resources.ResourceManager.GetObject(GetImageName((PictureBox)sender) + "_glow");
        }

        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            ((PictureBox)sender).Image = (Image)Resources.ResourceManager.GetObject(GetImageName((PictureBox)sender));
        }
    }
}
