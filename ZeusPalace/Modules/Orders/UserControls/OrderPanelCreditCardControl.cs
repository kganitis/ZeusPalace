using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeusPalace.Modules.Orders.UserControls
{
    public partial class OrderPanelCreditCardControl : OrderPanelControl
    {
        private Color defaultTextForeColor;
        public event EventHandler FieldsChanged;
        public event EventHandler PaymentSuccessful;
        public OrderPanelCreditCardControl()
        {
            InitializeComponent();
            textBoxCardNumber.TextChanged += Fields_Changed;
            textBoxExpDate.TextChanged += Fields_Changed;
            textBoxCVV.TextChanged += Fields_Changed;
            textBoxName.TextChanged += Fields_Changed;
            defaultTextForeColor = textBoxExpDate.ForeColor;
        }

        private void Fields_Changed(object sender, EventArgs e)
        {
            FieldsChanged?.Invoke(this, EventArgs.Empty);
        }

        public bool FieldsAreFilled
        {
            get
            {
                return textBoxCardNumber.Text.Length != 0
                && textBoxExpDate.Text.Length != 0 && !textBoxExpDate.Text.Equals(textBoxExpDate.Tag.ToString())
                && textBoxCVV.Text.Length != 0
                && textBoxName.Text.Length != 0;
            }
        }

        public void ExecutePayment()
        {
            pictureBoxProcessing.Visible = true;
            labelMessage.Visible = true;
            timerProcessing.Start();
        }

        private void textBoxCardNumber_TextChanged(object sender, EventArgs e)
        {
            string currentText = textBoxCardNumber.Text;
            currentText = currentText.Replace(" ", "");
            if (currentText.Length > 4)
            {
                for (int i = 4; i < currentText.Length; i += 5)
                {
                    currentText = currentText.Insert(i, " ");
                }
            }
            textBoxCardNumber.Text = currentText;
            textBoxCardNumber.SelectionStart = textBoxCardNumber.Text.Length;
        }

        private void textBoxExpDate_TextChanged(object sender, EventArgs e)
        {
            string input = textBoxExpDate.Text.Replace("/", "").Trim();
            if (input.Length >= 2)
            {
                string mm = input.Substring(0, 2);
                string yy = input.Substring(2);
                textBoxExpDate.Text = $"{mm}/{yy}";
            }
            else
            {
                textBoxExpDate.Text = input;
            }
            textBoxExpDate.SelectionStart = textBoxExpDate.Text.Length;
        }

        private void textBoxExpDate_Enter(object sender, EventArgs e)
        {
            textBoxExpDate.Clear();
            textBoxExpDate.ForeColor = textBoxCardNumber.ForeColor;
        }

        private void textBoxExpDate_Leave(object sender, EventArgs e)
        {
            if (textBoxExpDate.Text == String.Empty)
            {
                textBoxExpDate.Text = textBoxExpDate.Tag.ToString();
                textBoxExpDate.ForeColor = defaultTextForeColor;
            }
        }

        private void textBoxExpDate_KeyDown(object sender, KeyEventArgs e)
        {
            string currentText = textBoxExpDate.Text.Replace("/", "").Trim(); // Remove existing slashes
            if (currentText.Length == 2 || currentText.Length == 3)
            {
                // Check for backspace key (key code 8)
                if (e.KeyCode == Keys.Back)
                {
                    // Unsubscribe temporarily
                    textBoxExpDate.TextChanged -= textBoxExpDate_TextChanged;

                    if (currentText.Length == 2)
                    {
                        textBoxExpDate.Text = currentText.Substring(0, 1);
                    }
                    else
                    {
                        textBoxExpDate.Text = currentText.Substring(0, 2) + '/';
                    }

                    // Set the cursor position at the end of the text
                    textBoxExpDate.SelectionStart = textBoxExpDate.Text.Length;
                    textBoxExpDate.TextChanged += textBoxExpDate_TextChanged;
                    e.SuppressKeyPress = true; // Suppress backspace keypress
                }
            }   
        }

        private void timerProcessing_Tick(object sender, EventArgs e)
        {
            timerProcessing.Stop();
            labelMessage.Text = "Πληρωμή επιτυχής!";
            labelMessage.ForeColor = Color.FromArgb(26, 161, 91);
            pictureBoxProcessing.Visible = false;
            pictureBoxSuccess.Visible = true;
            PaymentSuccessful?.Invoke(this, EventArgs.Empty);
        }
    }
}
