using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _1_InputValidationTests
{
    public partial class Form1 : Form
    {
        readonly string nameRegex = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$"; //@"^([A-Za-z]\s)+$";
        readonly string phoneRegex = @"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$"; // @"^(((\d{3})?)|(\d{3}-))?\d{3}-\d{4}$";
        readonly string emailRegex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$"; // @"^[^@]+@((\w|-)+.)*.[a-z]+$";

        readonly string nameMsg = "The name is invalid (only alphabetical characters are allowed)";
        readonly string phoneMsg = "The phone number is not valid";
        readonly string emailMsg = "The E-mail address is not valid";

        public Form1()
        {
            InitializeComponent();
            // this.ActiveControl = textBox_Name;
        }

        public Boolean ValidName(string str)
        {
            return Regex.IsMatch(str, nameRegex);
        }
        
        public Boolean ValidPhone(string str)
        {
            return Regex.IsMatch(str, phoneRegex);
        }
        
        public Boolean ValidEmail(string str)
        {
            return Regex.IsMatch(str, emailRegex);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!ValidName(textBox_Name.Text)) MessageBox.Show(nameMsg);

            if (!ValidPhone(textBox_Phone.Text)) MessageBox.Show(phoneMsg);

            if (!ValidEmail(textBox_Email.Text)) MessageBox.Show(emailMsg);
        }

        private void TextBox_Name_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Name.Text))
            {
                if (!Regex.IsMatch(textBox_Name.Text, nameRegex))
                {
                    MessageBox.Show(nameMsg);
                    this.ActiveControl = textBox_Name;
                }
            }
        }

        private void TextBox_Phone_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Phone.Text))
            {
                if (!Regex.IsMatch(textBox_Phone.Text, phoneRegex))
                {
                    MessageBox.Show(phoneMsg);
                    this.ActiveControl = textBox_Phone;
                }
            }
        }

        private void TextBox_Email_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox_Email.Text))
            {
                if (!Regex.IsMatch(textBox_Email.Text, emailRegex))
                {
                    MessageBox.Show(emailMsg);
                    this.ActiveControl = textBox_Email;
                }
            }
        }
    }
}
