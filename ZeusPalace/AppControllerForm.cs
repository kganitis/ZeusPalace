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
            checkBoxPersonInPool.Enabled = appController.CurrentForm.GetType() == typeof(PoolForm);
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {
            InitializeAppControllerData();
            appController.User = appController.Customer;
            
            // Display user login data
            labelUsernameValue.Text = appController.User.Username;
            labelPasswordValue.Text = appController.User.Password;
            labelUsername.Visible = true;
            labelPassword.Visible = true;
            labelUsernameValue.Visible = true;
            labelPasswordValue.Visible = true;

            appController.StartApplication();
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            InitializeAppControllerData();
            appController.User = appController.Employee;

            // Display user login data
            labelEmpUsernameValue.Text = appController.User.Username;
            labelEmpPasswordValue.Text = appController.User.Password;
            labelEmpUsername.Visible = true;
            labelEmpPassword.Visible = true;
            labelEmpUsernameValue.Visible = true;
            labelEmpPasswordValue.Visible = true;

            appController.StartApplication();
        }

        private void InitializeAppControllerData()
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

            // Set computer type
            if (radioButtonPrivate.Checked)
            {
                appController.ComputerType = ComputerType.Private;
            }
            else if (radioButtonPublic.Checked)
            {
                appController.ComputerType = ComputerType.Public;
            }
            else
            {
                appController.ComputerType = ComputerType.PublicPool;
            }

            appController.DateTime = dateTimePicker.Value;
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

        private void checkBoxPersonInPool_CheckedChanged(object sender, EventArgs e)
        {
            appController.SetPersonInPool(checkBoxPersonInPool.Checked);
        }

        private void radioButtonPublicPool_CheckedChanged(object sender, EventArgs e)
        {
            buttonCustomer.Enabled = !radioButtonPublicPool.Checked;
        }

        private void buttonRefreshTime_Click(object sender, EventArgs e)
        {
            appController.DateTime = dateTimePicker.Value;
        }
    }
}
