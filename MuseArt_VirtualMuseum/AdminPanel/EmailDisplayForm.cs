using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseArt_VirtualMuseum.AdminPanel
{
    public partial class EmailDisplayForm : Form
    {
        public string name;
        public string subject;
        public string email;
        public string message;

        public EmailDisplayForm(string name, string subject, string email, string message)
        {
            InitializeComponent();

            this.name = name;
            this.subject = subject;
            this.email = email;
            this.message = message;

            this.ControlBox = false; // removing the controlbox, i will design it manually
            this.DoubleBuffered = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // indicate the limits of the maximized (equal to the working are of the desk)
        }

        private void EmailDisplayForm_Load(object sender, EventArgs e)
        {
            titleLbl.Text = name;
            emailLbl.Text = email;
            subjectLbl.Text = subject;
            messageBox.Text = message;
        }

        private void btnWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
