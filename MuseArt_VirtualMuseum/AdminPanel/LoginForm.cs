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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.ControlBox = false; // removing the controlbox, i will design it manually
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // indicate the limits of the maximized (equal to the working are of the desk)
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            string message;
            string title;

            message = "Are you sure to exit?";
            title = "Exit";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameTB.Text.Trim();
            string password = PwdTB.Text.Trim();

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            SqlConnection MartDB = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB; AttachDbFilename=" + projectDirectory + @"\DatabaseMuseArt.mdf; Integrated Security = True; Connect Timeout = 30");

            MartDB.Open();

            SqlCommand cmd = new SqlCommand("select count (*) as cnt from Account where username = @un and password = @pwd", MartDB);
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@un", username);
            cmd.Parameters.AddWithValue("@pwd", password);

            // if user is found or not
            if (cmd.ExecuteScalar().ToString() == "1")
            {
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    AdminForm af = new AdminForm();
                    af.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("The username or password is incorrect.", "Account cannot find", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            MartDB.Close();

        }
    }
}
