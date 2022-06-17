using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

            NameErrorLbl.Visible = false;
            SubjectErrorLbl.Visible = false;
            EmailErrorLbl.Visible = false;
            MsgErrorLbl.Visible = false;
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            bool failed = false;
            // check user input 
            if (nameText.Text.Length < 2)
            {
                NameErrorLbl.Visible = true;
                failed = true;
            }
            else
            {
                NameErrorLbl.Visible = false;
                failed = false;
            }

            if (SubjectTBox.Text.Length < 2)
            {
                SubjectErrorLbl.Visible = true;
                failed = true;
            }
            else
            {
                SubjectErrorLbl.Visible = false;
                failed = false;
            }

            if (!IsValidEmail(emailText.Text))
            {
                EmailErrorLbl.Visible = true;
                failed = true;
            }
            else
            {
                EmailErrorLbl.Visible = false;
                failed = false;
            }

            if (messageTB.Text.Length < 10)
            {
                MsgErrorLbl.Visible = true;
                failed = true;
            }
            else
            {
                MsgErrorLbl.Visible = false;
                failed = false;
            }


            if (!failed)
            {
                insertEmail(nameText.Text, SubjectTBox.Text, emailText.Text, messageTB.Text);

                MessageBox.Show("Email Sent Succesfully!\nOur admins will reply you as soon as.\nThank you!", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nameText.Text = emailText.Text = messageTB.Text = "";
            }
        }
        private void insertEmail(string name, string subject, string email, string msg)
        {

            bool sql_fail = false;
            // opening sql connection
            mainForm.MuseArtDB.Open();

            // init sql insert command
            SqlCommand cmd = new SqlCommand("insert into Inbox (sender_name, subject, email, message) values (@name, @sub, @email, @msg)", mainForm.MuseArtDB);
            // adding user info as parameters of query
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
            cmd.Parameters.Add("@sub", SqlDbType.NVarChar).Value = subject;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
            cmd.Parameters.Add("@msg", SqlDbType.NVarChar).Value = msg;
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                sql_fail = true;
            }
            // close connection
            mainForm.MuseArtDB.Close();


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

        private void sendBtn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13) // Enter
            {
                sendBtn_Click(sender, e);
            }
        }
    }
}
