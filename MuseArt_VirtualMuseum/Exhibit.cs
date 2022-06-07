using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseArt_VirtualMuseum
{
    public class Exhibit
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        public int date { get; set; }

        private Image img;

        private float price;

        public Exhibit()
        {

        }

        public Exhibit(int ID, string name, string description, string category, int date)
        {
            this.ID = ID;
            this.name = name;
            this.description = description;
            this.category = category;
            this.date = date;
        }

        // setters and getters
        public float Price { get => price; set => price = value; }
        public Image Img { get => img; set => img = value; }
        public void setID(int ID) { this.ID = ID; }
        public int getID() { return this.ID; }

        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }

        public void setDescription(string description) { this.description = description; }
        public string getDescription() { return this.description; }

        public void setCategory(string category) { this.category = category; }
        public string getCategory() { return this.category; }

        public void setDate(int date) { this.date = date; }
        public int getDate() { return this.date; }

        public override string ToString()
        {
            return "Name: " + name; 
        }
    }
}
