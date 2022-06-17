using FontAwesome.Sharp;
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

namespace MuseArt_VirtualMuseum
{
    public partial class AdminForm : Form
    {
        public Boolean clicked = false;
        private IconButton currentButton;
        private Color redColor = Color.FromArgb(166, 10, 5); // redColor of application (used in MuseArt Logo etc.)
        private Form currentChildForm;
        public AdminForm()
        {
            InitializeComponent();
        }

        private void loadEmails()
        {
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            SqlConnection MartDB = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + projectDirectory + @"\DatabaseMuseArt.mdf; Integrated Security = True; Connect Timeout = 30");
            MartDB.Open();

            SqlCommand cmd = new SqlCommand("select * from Inbox", MartDB);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                InboxItem item = new InboxItem();

                item.Name1 = reader["sender_name"].ToString();
                item.Email = reader["email"].ToString();
                item.Subject = reader["subject"].ToString();
                item.Message = reader["message"].ToString();
                item.ID1 = (int)reader["ID"];
                
                if(reader["opened"].ToString() == "1")
                {
                    item.Opened1 = true;
                }
                else
                {
                    item.Opened1 = false;
                }

                item.setLabels();

                InboxFlowLayout.Controls.Add(item);
            }
            MartDB.Close();
        }

        private void ActivateButton(object senderBtn, Color color) // activated button
        {
            if (senderBtn != null)
            {
                DisableButton(); // Disable the current button

                // button
                currentButton = (IconButton)senderBtn; // give the current clicked button value
                currentButton.BackColor = color; // activated button color is MuseArt's red RGB(166, 10, 5)
                currentButton.ForeColor = Color.White; // button text to white
                currentButton.TextAlign = ContentAlignment.MiddleCenter;
                currentButton.IconColor = Color.White;
                currentButton.ImageAlign = ContentAlignment.MiddleRight;

                // icon bottom of the titlebar: iconCurrentChildForm
                iconCurrentChildForm.IconChar = currentButton.IconChar;
                lblTitleChildForm.Text = currentButton.Text;
            }
        }

        private void DisableButton()
        {
            if (currentButton != null)
            {
                    currentButton.BackColor = Color.Transparent;
                    currentButton.ForeColor = Color.FromArgb(64, 64, 64);
                    currentButton.TextAlign = ContentAlignment.MiddleLeft;
                    currentButton.IconColor = Color.FromArgb(64, 64, 64);
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            startingForm sf = new startingForm();
            sf.Show();
            this.Close();
        }

        private void InboxBtn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            if(!clicked)
            {
                loadEmails();
                clicked = true;
            }
            
        }
    }
}
