using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseArt_VirtualMuseum.menuForms
{
    public partial class communicateForm : Form
    {
        public communicateForm()
        {
            InitializeComponent();
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            bool failed = false;
            // check user input 
            if (nameText.Text.Length < 2)
            {
                MessageBox.Show("Name cannot be empty", "Invalid Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            else if (!IsValidEmail(emailText.Text))
            {
                MessageBox.Show("Please fill the email correctly", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            else if (messageTB.Text.Length < 10)
            {
                MessageBox.Show("Please fill text area for the subject you want", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            if (!failed)
            {
                MessageBox.Show("Email Sent Succesfully!\nOur admins will reply you as soon as.\nThank you!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nameText.Text = emailText.Text = messageTB.Text = "";
            }
        }

        public static bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();

            if (trimmedEmail.EndsWith("."))
            {
                return false; // suggested by @TK-421
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == trimmedEmail;
            }
            catch
            {
                return false;
            }
        }

        private void communicateForm_Load(object sender, EventArgs e)
        {

        }
    }
}
