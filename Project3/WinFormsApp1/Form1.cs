using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Create a new instance of the Person class and fill in its properties
            Person person = new Person
            {
                FirstName = FirstNameTextBox.Text,  // Make sure this is the correct name in the designer
                LastName = LastNameTextBox.Text,    // Make sure this is the correct name in the designer
                PersonalNumber = PersonalNumberTextBox.Text  // Make sure this is the correct name in the designer
            };

            // Check if the personal number is valid and determine gender
            bool isValid = person.IsPersonalNumberValid();
            string gender = person.GetGender();

            // Display the results in a multiline TextBox
            ResultTextBox.Text = $"First Name: {person.FirstName}\n" +
                                 $"Last Name: {person.LastName}\n" +
                                 $"Personal Number: {person.PersonalNumber} ({(isValid ? "Valid" : "Invalid")})\n" +
                                 $"Gender: {gender}";
        }

    }

    private void button2_Click(object sender, EventArgs e)
    {
        this.Close();
    }
}


