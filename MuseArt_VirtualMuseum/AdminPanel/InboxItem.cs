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
using MuseArt_VirtualMuseum.AdminPanel;

namespace MuseArt_VirtualMuseum
{
    public partial class InboxItem : UserControl
    {
        private int ID;
        private string _name;
        private string _email;
        private string _subject;
        private string _message;
        private bool opened;

        
        public InboxItem()
        {
            InitializeComponent();
            IconEmailOpened.Visible = false;

        }

        // setters getters
        public string Name1 { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Subject { get => _subject; set => _subject = value; }
        public string Message { get => _message; set => _message = value; }
        public bool Opened { get => Opened1; set => Opened1 = value; }
        public int ID1 { get => ID; set => ID = value; }
        public bool Opened1 { get => opened; set => opened = value; }

        private void ReadBtn_Click(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            SqlConnection MartDB = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + projectDirectory + @"\DatabaseMuseArt.mdf; Integrated Security = True; Connect Timeout = 30");
            
            MartDB.Open();

            SqlCommand cmd = new SqlCommand("update Inbox set opened = 1 where ID = @id", MartDB);
            cmd.Parameters.AddWithValue("@id", ID1);
            cmd.CommandType = CommandType.Text;

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            MartDB.Close();

            IconEmailClosed.Visible = false;
            IconEmailOpened.Visible = true;

            AdminPanel.EmailDisplayForm readEmail = new AdminPanel.EmailDisplayForm(this._name, this._subject, this._email, this._message);
            readEmail.Show();
        }

        public void setLabels()
        {
            SubjectLbl.Text = this._subject;
            
            if (this.opened)
            {
                IconEmailOpened.Visible = true;
                IconEmailClosed.Visible = false;
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            string message;
            string title;

            message = "Are you sure to delete?";
            title = "Delete";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                SqlConnection MartDB = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + projectDirectory + @"\DatabaseMuseArt.mdf; Integrated Security = True; Connect Timeout = 30");

                MartDB.Open();

                SqlCommand cmd = new SqlCommand("delete from Inbox where ID = @id", MartDB);
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@id", ID1);
                cmd.CommandType = CommandType.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MartDB.Close();
                AdminForm.loadEmails();
            }
            else { }
        }
    }
}
