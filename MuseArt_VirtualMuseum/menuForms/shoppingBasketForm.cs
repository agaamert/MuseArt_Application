using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuseArt_VirtualMuseum.menuForms
{
    public partial class shoppingBasketForm : Form
    {
        public static FlowLayoutPanel basketPanel;
        public static float total = 0f;
        public static Label totalPrice;
        public static Label emptyMsg;
        public static Button clrBtn;

        public shoppingBasketForm()
        {
            InitializeComponent();
            
            basketPanel = basketFlowLayoutPanel;
            totalPrice = pricelLbl;
            emptyMsg = emptyMsgLbl;
            clrBtn = clearBtn;

            InitializeBasketList(false);
        }

        private void InitializeBasketList(Boolean empty)
        {
            basketFlowLayoutPanel.Controls.Clear();
            if(!empty)
            {
                total = 0f;
                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                foreach (ExhibitItem ex in mainForm.basketList)
                {
                        BasketItem bskItem = new BasketItem();
                        bskItem.Id = ex.Id;
                        bskItem.Name1 = ex.Name1;
                        bskItem.Desc = ex.Desc;
                        bskItem.Category = ex.Category;
                        bskItem.Date = ex.Date;
                        bskItem.Price = ex.Price;
                        total += ex.Price;
                        string imgName = projectDirectory + "/myResources/Exhibits/portraits/" + Convert.ToString(ex.Id, CultureInfo.InvariantCulture) + ".png";
                        bskItem.Img = Image.FromFile(imgName);
                        bskItem.setLabels();   
                        basketFlowLayoutPanel.Controls.Add(bskItem);              
                }
                updateTotal();
            }
            else if (empty)
            {

            }
            

        }

        public static void updateTotal()
        {
            // calculate new prices
            total = 0f;
            foreach (ExhibitItem ex in mainForm.basketList)
                total += ex.Price;
            
            totalPrice.Text = Convert.ToString(total, CultureInfo.InvariantCulture) + " €";

            if (mainForm.basketList.Count.Equals(0))
            {
                basketPanel.Visible = false;
                clrBtn.Visible = false;
                emptyMsg.Visible = true;
            }
            else
            {
                basketPanel.Visible = true;
                clrBtn.Visible = true;
                emptyMsg.Visible = false;
            }
        }

        private void completeBtn_Click(object sender, EventArgs e)
        {
            if (mainForm.basketList.Count == 0)
            {
                MessageBox.Show("Please add item to basket to proceed to checkout", "Empty Basket", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CheckoutForm checkoutForm = new CheckoutForm(totalPrice.Text);
                checkoutForm.Show();
            }
          
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            string message = "Are you sure for cleaning the shopping basket?";
            string title = "Clear Basket";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
            {
                BasketItem.clearBasket();
            }
            else { }
            
        }
    }
}
