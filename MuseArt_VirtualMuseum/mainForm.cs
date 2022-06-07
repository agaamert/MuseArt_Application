using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices; // for using native libraries from operating system for mouse down event
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; // FontAwesome NuggetPack
using MuseArt_VirtualMuseum.menuForms;

namespace MuseArt_VirtualMuseum
{
    public partial class mainForm : Form
    {
        // fields
        private IconButton currentButton;
        private Color redColor = Color.FromArgb(166, 10, 5); // redColor of application (used in MuseArt Logo etc.)
        private Form currentChildForm;
        public static Label title;
        // This will get the current PROJECT directory
        string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        // did the above because |DataDirectory| didn't work

        string constr = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\DatabaseMuseArt.mdf;Integrated Security=True;User Instance=True;";
        public SqlConnection exhibitionsDB = null;

        public Exhibit exhData = new Exhibit();
        public static List<Exhibit> exhibitionsList = new List<Exhibit>();
        public static List<ExhibitItem> basketList = new List<ExhibitItem>();

        public static FontAwesome.Sharp.IconButton basketBtn;

        // mainForm
        public mainForm()
        {
            InitializeComponent();
            basketBtn = btnShoppingCart;
            title = lblTitleChildForm;
            // form
            //this.Text = String.Empty;
            this.ControlBox = false; // removing the controlbox, i will design it manually
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // indicate the limits of the maximized (equal to the working are of the desk)

            // sql server connection
            // Starting SQL Connection with local database 
            exhibitionsDB = new SqlConnection(@"Data Source =(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + projectDirectory + @"\DatabaseMuseArt.mdf; Integrated Security = True; Connect Timeout = 30");            //SqlConnection exhibitionsDB = new SqlConnection(@"data source = LAPTOP-9ISRFRVP\SQLEXPRESS; initial catalog = DBMuseArt_Virtual; user id = sa; password = 1; ");
            //addExhibites();
            exhibitionsDB.Open();
            SqlCommand cmd = new SqlCommand("select * from Exhibitions", exhibitionsDB); // select all data from exhibition database
            SqlDataReader reader = cmd.ExecuteReader(); // execute the data from cmd

            while (reader.Read()) // while database has data
            {
                // extract all data to Exhibit class
                exhData = new Exhibit();
                exhData.setID(int.Parse(reader["id"].ToString(), CultureInfo.InvariantCulture));
                exhData.setName(reader["name"].ToString());
                exhData.setDescription(reader["description"].ToString());
                exhData.setCategory(reader["category"].ToString());
                exhData.setDate(int.Parse(reader["date"].ToString(), CultureInfo.InvariantCulture));
                exhData.Price = float.Parse(reader["price"].ToString(), CultureInfo.InvariantCulture);
                exhibitionsList.Add(exhData);
            }
            exhibitionsDB.Close();

            //hover tool notes init
            this.btnWindowClose.MouseHover += button1_MouseHover;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnWindowClose, "Close");
            ToolTip1.SetToolTip(this.btnWindowMaximize, "Maximize");
            ToolTip1.SetToolTip(this.btnWindowMinimize, "Minimize");
            ToolTip1.SetToolTip(this.btnHome, "Home");

        }

        // for adding data 
        private void addExhibites()
        {

            bool sql_fail = false;
            // opening sql connection
            exhibitionsDB.Open();

            // init sql insert command
            SqlCommand cmd = new SqlCommand("insert into Exhibitions values(@id, @name, @desc, @cat, @date)", exhibitionsDB);
            // adding user info as parameters of query
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = 2;
            cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = "Past";
            cmd.Parameters.Add("@desc", SqlDbType.NVarChar).Value = "Past is more colored.";
            cmd.Parameters.Add("@cat", SqlDbType.NVarChar).Value = "PT";
            cmd.Parameters.Add("@date", SqlDbType.Int).Value = 2022;
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
            exhibitionsDB.Close();


        }

        // functions
        private void ActivateButton(object senderBtn, Color color) // activated button
        {
            if(senderBtn != null)
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
            if(currentButton != null)
            {
                if (currentButton.Name.Equals("btnShoppingCart")) // shoppingBasket button has different background from the other buttons
                {
                    currentButton.BackColor = Color.IndianRed;
                }
                else if (!currentButton.Name.Equals("btnShoppingCart"))
                {
                    currentButton.BackColor = Color.Transparent;
                    currentButton.ForeColor = Color.FromArgb(64, 64, 64);
                    currentButton.TextAlign = ContentAlignment.MiddleLeft;
                    currentButton.IconColor = Color.FromArgb(64, 64, 64);
                    currentButton.ImageAlign = ContentAlignment.MiddleLeft;
                }                  

            }
        }

        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close(); // open only form
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenChildForm(new homeForm());
        }

        private void btnExplore_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            OpenChildForm(new exploreForm());
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            OpenChildForm(new aboutForm());
        }



        private void btnTalk_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            OpenChildForm(new communicateForm());
        }



        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if(currentChildForm != null)
                currentChildForm.Close();

            Reset();
            OpenChildForm(new homeForm());
        }

        private void btnShoppingCart_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            mainForm.title.Text = "Basket";
            OpenChildForm(new shoppingBasketForm());
        }

        private void Reset() // reset and return to home page
        {
            DisableButton(); // resets the current selected button

            // icon bottom of the titlebar: iconCurrentChildForm
            iconCurrentChildForm.IconChar = IconChar.Home; // change the title bar icon to 'Home'
            lblTitleChildForm.Text = "Home"; // change the title bar text to 'Home'
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }

        // mouse down drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWmd, int wMsg, int wParam, int lParam);

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            string message;
            string title;
            if (basketList.Count > 0)
            {
                message = "You have items in your basket. Want to checkout?";
                title = "Item(s) in basket";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    DisableButton(); // resets the current selected button
                    OpenChildForm(new shoppingBasketForm());
                }
                else
                    Application.Exit();
            }
            else
            {
                message = "Do you want to close the application?";
                title = "Close App";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                    Application.Exit();
            }
           
        }

        private void btnWindowMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btnWindowMaximize.Text = "=";
            }               
            else if(WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
                btnWindowMaximize.Text = "O";
            }
        }

        private void btnWindowMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

 

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panelTitleBar_DoubleClick(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
        }

        private void btnExhibitions_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);
            OpenChildForm(new exhibitionsForm());
        }


        private void MuseArtbtnExploreVM_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, redColor);

            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName; // gettin parent's path
            string app = projectDirectory + "/myResources/MuseArt_FinalVR/MuseArt";

            string message = "You are redirecting to MuseArt Virtual Museum.\n\nFor Quit, press Alt + F4";
            string title = "MuseArt Virtual Museum";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = app;
                // Do you want to show a console window?
                start.WindowStyle = ProcessWindowStyle.Hidden;
                start.CreateNoWindow = true;
                int exitCode;
                using (Process proc = Process.Start(start))
                {
                    proc.WaitForExit();

                    // Retrieve the app's exit code
                    exitCode = proc.ExitCode;
                }
            }
            else
            {

            }
            if (currentChildForm != null)
                currentChildForm.Close();

            Reset(); // reset and return to home page
        }
    }
}
