using System;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;
using ZeusPalace.Entities.Accommodation;

namespace ZeusPalace
{
    public partial class AppControllerForm : Form
    {
        private MainForm mainForm;

        public AppControllerForm()
        {
            InitializeComponent();
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
            AppController appController = AppController.Instance;
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

            // Display user login data
            labelUsernameValue.Text = customer.Username;
            labelPasswordValue.Text = customer.Password;
            labelEmpUsernameValue.Text = employee.Username;
            labelEmpPasswordValue.Text = employee.Password;
            foreach (Label label in panelUserData.Controls)
            {
                label.Visible = true;
            }

            // Start application
            if (mainForm != null )
            {
                mainForm.Close();
                mainForm.Dispose();
                mainForm = null;
            }
            mainForm = new MainForm();
            mainForm.Show();
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
    }
}
