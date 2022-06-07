using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseArt_VirtualMuseum.menuForms
{
    public partial class exploreForm : Form
    {
        private Form? currentChildChildForm;
        private Form? parentForm;

        public exploreForm()
        {
            InitializeComponent();
        }

        private void OpenRoomForm(Form childChildForm)
        {
            if (currentChildChildForm != null)
            {
                currentChildChildForm.Close(); // open only form
            }
            parentForm = childChildForm; // for back button
            currentChildChildForm = childChildForm;
            childChildForm.TopLevel = false;
            childChildForm.FormBorderStyle = FormBorderStyle.None;
            childChildForm.Dock = DockStyle.Fill;
            panelChildDesktop.Controls.Add(childChildForm);
            panelChildDesktop.Tag = childChildForm;
            childChildForm.BringToFront();
            childChildForm.Show();
        }


        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        private void btnExploreVM_Click(object sender, EventArgs e)
        {
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
        }
    }
}
