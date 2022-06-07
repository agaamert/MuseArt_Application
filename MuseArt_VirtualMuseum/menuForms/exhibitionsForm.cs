using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using MuseArt_VirtualMuseum;



namespace MuseArt_VirtualMuseum.menuForms
{
    public partial class exhibitionsForm : Form
    {
        public static Panel addedPan; 
        public static Label addedLbl; 
        public exhibitionsForm()
        {
            InitializeComponent();
            addedPan = addedPanel;
            addedLbl = addedLblText;
            addedPanel.Visible = false;
        }

        private void GenerateExhibits(string showingCategory)
        {

            exhibitsFlowLayoutPanel.Controls.Clear();

            List<ExhibitItem> exhs = new List<ExhibitItem>();
            string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            foreach (Exhibit ex in mainForm.exhibitionsList)
            {
                if (!showingCategory.Equals("All"))
                {
                    if (ex.category.Equals(showingCategory))
                    { 
                        ExhibitItem exhItem = new ExhibitItem();
                        exhItem.Id = ex.ID;
                        exhItem.Name1= ex.name;
                        exhItem.Desc = ex.description;

                        if (ex.category == "PT")
                            exhItem.Category = "Portrait";
                        if(ex.category == "ARC")
                            exhItem.Category = "Archeology";
                        if (ex.category == "NFT")
                            exhItem.Category = ex.category;

                        exhItem.Date = ex.date.ToString(CultureInfo.InvariantCulture);
                        exhItem.Price = ex.Price;
                        string imgName = projectDirectory+"/myResources/Exhibits/portraits/" + Convert.ToString(ex.ID, CultureInfo.InvariantCulture) + ".png";
                        exhItem.Img = Image.FromFile(imgName);
                        exhItem.setLabels();

                        exhibitsFlowLayoutPanel.Controls.Add(exhItem);
                    }
                }
                else
                {
                    ExhibitItem exhItem = new ExhibitItem();
                    exhItem.Id = ex.ID;
                    exhItem.Name1 = ex.name;
                    exhItem.Desc = ex.description;

                    if (ex.category == "PT")
                        exhItem.Category = "Portrait";
                    if (ex.category == "ARC")
                        exhItem.Category = "Archeology";
                    if (ex.category == "NFT")
                        exhItem.Category = ex.category;

                    exhItem.Date = ex.date.ToString(CultureInfo.InvariantCulture);
                    exhItem.Price = ex.Price;
                    string imgName = projectDirectory + "/myResources/Exhibits/portraits/" + Convert.ToString(ex.ID, CultureInfo.InvariantCulture) + ".png";
                    exhItem.Img = Image.FromFile(imgName);
                    exhItem.setLabels();

                    exhibitsFlowLayoutPanel.Controls.Add(exhItem);
                }
               
                
            }
        }



        public static void showAddedPanel(string name)
        {
            // show added message for 3 secs
            var t = new System.Windows.Forms.Timer();
            addedPan.Visible = true;
            addedLbl.ForeColor = System.Drawing.Color.White;
            addedLbl.Text = name + " added to Basket."; 
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, e) =>
            {
                addedPan.Visible = false;
                addedLbl.Text = "";
                t.Stop();
            };
            t.Start();
        }

        private void exhibitionsForm_Load(object sender, EventArgs e)
        {
            categoryComboBox.SelectedIndex = 0;
            GenerateExhibits("All");
        }

        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryComboBox.SelectedItem.Equals("All"))
                GenerateExhibits("All");
            else if (categoryComboBox.SelectedItem.Equals("Portrait"))
                GenerateExhibits("PT");
            else if (categoryComboBox.SelectedItem.Equals("Archeology"))
                GenerateExhibits("ARC");
            else if (categoryComboBox.SelectedItem.Equals("NFT"))
                GenerateExhibits("NFT");
        }
    }
}
