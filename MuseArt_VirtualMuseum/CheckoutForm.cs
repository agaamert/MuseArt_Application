using MuseArt_VirtualMuseum.menuForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseArt_VirtualMuseum
{
    public partial class CheckoutForm : Form
    {
        public CheckoutForm(string total)
        {
            InitializeComponent();
            totalLbl.Text = total;

            this.ControlBox = false; // removing the controlbox, i will design it manually
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea; // indicate the limits of the maximized (equal to the working are of the desk)
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            string message;
            string title;

            
            bool failed = false;
            // check user input 
            if (nameLbl.Text.Length < 2)
            {
                MessageBox.Show("Invalid Name", "Name cannot be empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            else if (!communicateForm.IsValidEmail(emailTextBox.Text))
            {
                MessageBox.Show("Please fill the email correctly", "Invalid email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            else if (!IsCreditCardInfoValid(CreditmaskedTB.Text, DatemaskedTB.Text, CvvmaskedTB.Text))
            {
                MessageBox.Show("Please fill the credit card informations correctly", "Invalid Credit Card Number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                failed = true;
            }
            if (!failed)
            {
                message = "The exhibition copy will be sent to given email address (" + emailTextBox.Text + ")\nDo you want to continue?";
                title = "Email Notify";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    Random order = new Random();
                    MessageBox.Show("Order Submited Succesfully", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    titleLbl.Text = "Order Confirmation";
                    emailLbl.Text = emailTextBox.Text;
                    orderNumberLbl.Text = order.Next(10000, 99999).ToString(CultureInfo.InvariantCulture);
                    checkOutPanel.Dock = DockStyle.None;
                    confirmationPanel.Dock = DockStyle.Fill;
                    checkOutPanel.Visible = false;
                    confirmationPanel.Visible = true;

                    BasketItem.clearBasket();
                }
                else { }
            }
        }

        public static bool IsCreditCardInfoValid(string cardNo, string expiryDate, string cvv)
        {
            var cardCheck = new Regex(@"^(1298|4165|1267|4512|4567|8901|8933)([\-\s]?[0-9]{4}){3}$");
            var monthCheck = new Regex(@"^(0[1-9]|1[0-2])$");
            var yearCheck = new Regex(@"^20[0-9]{2}$");
            var cvvCheck = new Regex(@"^\d{3}$");

            if (!cardCheck.IsMatch(cardNo)) // <1>check card number is valid
                return false;
            if (!cvvCheck.IsMatch(cvv)) // <2>check cvv is valid as "999"
                return false;

            var dateParts = expiryDate.Split('/'); //expiry date in from MM/yyyy            
            if (!monthCheck.IsMatch(dateParts[0]) || !yearCheck.IsMatch(dateParts[1])) // <3 - 6>
                return false; // ^ check date format is valid as "MM/yyyy"

            var year = int.Parse(dateParts[1], CultureInfo.InvariantCulture);
            var month = int.Parse(dateParts[0], CultureInfo.InvariantCulture);
            var lastDateOfExpiryMonth = DateTime.DaysInMonth(year, month); //get actual expiry date
            var cardExpiry = new DateTime(year, month, lastDateOfExpiryMonth, 23, 59, 59);

            //check expiry greater than today & within next 6 years <7, 8>>
            return (cardExpiry > DateTime.Now && cardExpiry < DateTime.Now.AddYears(6));
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

            if (titleLbl.Text.Equals("Order Confirmation"))
            {
                this.Close();
            }
            else
            {
                message = "Are you sure to exit?";
                title = "Exit";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
                else { }
            }
        }

        private void CheckoutForm_Load(object sender, EventArgs e)
        {
            checkOutPanel.Dock = DockStyle.Fill;
        }
    }
}
