using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MuseArt_VirtualMuseum.menuForms;
using System.Globalization;

namespace MuseArt_VirtualMuseum
{
    public partial class BasketItem : UserControl
    {
        private int id;
        private Image img;
        private string name;
        private string desc;
        private string category;
        private string date;
        private float price;


        public string Name1 { get => name; set => name = value; }
        public string Desc { get => desc; set => desc = value; }
        public string Category { get => category; set => category = value; }
        public Image Img { get => img; set => img = value; }
        public int Id { get => id; set => id = value; }
        public float Price { get => price; set => price = value; }
        public string Date { get => date; set => date = value; }

        public BasketItem()
        {
            InitializeComponent();
        }


        public void setLabels()
        {
            itemImg.Image = this.img;
            ItemName.Text = this.name;
            ItemDesc.Text = this.desc;
            ItemPrice.Text = this.Price + " €";
            dateLabel.Text = this.Date;
            categoryTextLbl.Text = this.category;
        }
       
        public static void clearBasket() // clean all items from the basket
        {
            mainForm.basketList.RemoveAll(p => p.Id == p.Id);

            foreach (ExhibitItem item in mainForm.basketList)
            {
                shoppingBasketForm.basketPanel.Controls.Remove(item);              
            }
            if (mainForm.basketList.Count.Equals(0))
                mainForm.basketBtn.Text = "Basket";
            else
                mainForm.basketBtn.Text = "Basket" + "(" + mainForm.basketList.Count + ")";

            mainForm.title.Text = "Basket";
            shoppingBasketForm.updateTotal();
        }
       

        private void itemRmvBtn_Click(object sender, EventArgs e)
        {
            mainForm.basketList.RemoveAll(p => p.Id == this.id);

            shoppingBasketForm.basketPanel.Controls.Remove(this);
            shoppingBasketForm.basketPanel.FlowDirection = shoppingBasketForm.basketPanel.FlowDirection;

            if (mainForm.basketList.Count.Equals(0))
                mainForm.basketBtn.Text = "Basket";
            else
                mainForm.basketBtn.Text = "Basket" + "(" + mainForm.basketList.Count + ")";
            mainForm.title.Text = "Basket";
            shoppingBasketForm.updateTotal();
        }
    }
}
