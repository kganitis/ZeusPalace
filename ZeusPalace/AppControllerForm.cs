using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ZeusPalace.Entities.Accommodation;
using ZeusPalace.Modules.PoolControl;

namespace ZeusPalace
{
    public partial class AppControllerForm : Form
    {
        AppController appController = AppController.Instance;

        public AppControllerForm()
        {
            InitializeComponent();
            appController.CurrentFormChanged += AppController_CurrentFormChanged;
            dateTimePicker.Value = DateTime.Now;
        }

        private void AppController_CurrentFormChanged(object sender, EventArgs e)
        {
            checkBoxPersonInPool.Visible = appController.CurrentForm.GetType() == typeof(PoolForm);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            // Check for fullname errors
            string fullname = textBoxFullname.Text;
            string[] nameParts = fullname.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (nameParts.Length < 2)
            {
                labelFullnameError.Visible = true;
                return;
            }
            else
            {
                labelFullnameError.Visible = false;
            }

            // Create customer
            Accommodation accommodation = radioButtonAppartment.Checked ? new Apartment() : (Accommodation)new TrojanHorse();
            decimal initialBalance = ConvertStringToDecimal(textBoxBalance.Text);
            Customer customer = new Customer(fullname, accommodation, initialBalance);
            appController.Customer = customer;
            
            // Create employee
            string name;
            Image image;
            if (radioButtonEmployee1.Checked)
            {
                name = radioButtonEmployee1.Text;
                image = pictureBox1.Image;
            }
            else if (radioButtonEmployee2.Checked)
            {
                name = radioButtonEmployee2.Text;
                image = pictureBox2.Image;
            }
            else if (radioButtonEmployee3.Checked)
            {
                name = radioButtonEmployee3.Text;
                image = pictureBox3.Image;
            }
            else
            {
                name = radioButtonEmployee4.Text;
                image = pictureBox4.Image;
            }
            Employee employee = new Employee(name, image);
            appController.Employee = employee;

            // Set time
            appController.Time = ExtractTimeFromDateTimePicker();
            appController.DateTime = dateTimePicker.Value;

            // Display user login data
            labelUsernameValue.Text = customer.Username;
            labelPasswordValue.Text = customer.Password;
            labelEmpUsernameValue.Text = employee.Username;
            labelEmpPasswordValue.Text = employee.Password;
            foreach (Label label in panelUserData.Controls)
            {
                label.Visible = true;
            }

            appController.StartApplication();
        }

        public static decimal ConvertStringToDecimal(string input)
        {
            // Define the culture info for the conversion
            CultureInfo cultureInfo = new CultureInfo("en-US");

            // Replace ',' with '.' to ensure uniform decimal separator
            input = input.Replace(',', '.');

            // Try to parse the string to a decimal with up to two decimal places
            if (decimal.TryParse(input, NumberStyles.AllowDecimalPoint, cultureInfo, out decimal result))
            {
                // Round the result to two decimal places
                result = Math.Round(result, 2);
                return result;
            }
            else
            {
                // If parsing fails, return 0
                return 0m;
            }
        }

        public int ExtractTimeFromDateTimePicker()
        {
            int hours = dateTimePicker.Value.Hour;
            int minutes = dateTimePicker.Value.Minute;
            int timeAsInt = (hours * 100) + minutes;

            return timeAsInt;
        }

        private void checkBoxPersonInPool_CheckedChanged(object sender, EventArgs e)
        {
            appController.SetPersonInPool(checkBoxPersonInPool.Checked);
        }
    }
}
