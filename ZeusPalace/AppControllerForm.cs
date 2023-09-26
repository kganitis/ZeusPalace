using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            labelUsernameValue.Text = GenerateUsernameFromGreekName(customer.Name);
            labelAccNoValue.Text = customer.Accommodation.Id;
            labelEmpUsernameValue.Text = ExtractFirstLetters(employee.Name);
            labelEmpPasswordValue.Text = ExtractFirstLetters(employee.Name, 3);
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

        public static string GenerateUsernameFromGreekName(string greekName)
        {
            // Split the Greek full name into parts
            string[] nameParts = greekName.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (nameParts.Length < 2)
            {
                throw new ArgumentException("Invalid full name. It should contain at least a first name and a last name.");
            }

            // Initialize the StringBuilder for the username
            StringBuilder usernameBuilder = new StringBuilder();

            foreach (string part in nameParts)
            {
                // Extract the first 3 letters of each part
                string extractedLetters = ExtractFirstLetters(part, 5 - Math.Min(nameParts.Length, 4));

                // Convert the extracted letters to Latin characters and append to the result
                usernameBuilder.Append(ConvertToLatinCharacters(extractedLetters));
            }

            return usernameBuilder.ToString();
        }

        // Extract the first 3 letters of a Greek part while handling special characters
        private static string ExtractFirstLetters(string greekPart, int numberOfLetters = int.MaxValue)
        {
            StringBuilder extractedLetters = new StringBuilder();

            for (int i = 0; i < Math.Min(numberOfLetters, greekPart.Length); i++)
            {
                string currentChar = greekPart[i].ToString();
                string convertedChar = ConvertToLatinCharacters(currentChar);

                // Append the converted character to the result
                extractedLetters.Append(convertedChar);
            }

            return extractedLetters.ToString();
        }

        // A mapping of Greek characters to Latin characters
        private static string ConvertToLatinCharacters(string greekCharacter)
        {
            string greekString = greekCharacter.ToLowerInvariant();
            switch (greekString)
            {
                case "α": return "a";
                case "β": return "b";
                case "γ": return "g";
                case "δ": return "d";
                case "ε": return "e";
                case "ζ": return "z";
                case "η": return "i";
                case "θ": return "th";
                case "ι": return "i";
                case "κ": return "k";
                case "λ": return "l";
                case "μ": return "m";
                case "ν": return "n";
                case "ξ": return "x";
                case "ο": return "o";
                case "π": return "p";
                case "ρ": return "r";
                case "σ":
                case "ς": return "s";
                case "τ": return "t";
                case "υ": return "u";
                case "φ": return "f";
                case "χ": return "ch";
                case "ψ": return "ps";
                case "ω": return "o";
                case "ά": return "a";
                case "έ": return "e";
                case "ί": return "i";
                case "ή": return "i";
                case "ό": return "o";
                case "ώ": return "o";
                case "ύ": return "u";
                default: return greekString;
            }
        }
    }
}
