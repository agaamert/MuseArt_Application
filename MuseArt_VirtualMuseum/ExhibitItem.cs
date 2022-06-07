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
using MuseArt_VirtualMuseum.menuForms;

namespace MuseArt_VirtualMuseum
{
    public partial class ExhibitItem : UserControl
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
        public string Date { get => date; set => date = value; }
        public Image Img { get => img; set => img = value; }
        public int Id { get => id; set => id = value; }
        public float Price { get => price; set => price = value; }


        public ExhibitItem()
        {
            InitializeComponent();
        }

     

        public void setLabels()
        {
            exhibitImage.Image = this.img;
            nameLbl.Text = this.name;
            descLbl.Text = this.desc;
            priceLbl.Text = this.Price + " €";
            dateTextLbl.Text = this.Date;
            categoryTextLbl.Text = this.category;
        }

        private void exhibitImage_Click(object sender, EventArgs e)
        {
            using (Form form = new Form())
            {
                Bitmap img = new Bitmap(this.Img);

                form.StartPosition = FormStartPosition.CenterParent;
                form.Size = img.Size;
                form.Text = this.Name1;
                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = img;

                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }

        private void itemAddBtn_Click(object sender, EventArgs e)
        {
            // check if item is already in basket list
            if (!mainForm.basketList.Contains(this))
            {
                mainForm.basketList.Add(this);
                itemAddBtn.IconColor = Color.Green;
                mainForm.basketBtn.Text = "Basket" + "(" + mainForm.basketList.Count + ")";
                exhibitionsForm.showAddedPanel(this.Name1);
            }
            else
                MessageBox.Show("Item already in basket", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
