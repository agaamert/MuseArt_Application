namespace MuseArt_VirtualMuseum
{
    public partial class startingForm : Form
    {
        public startingForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            loadingBar.Width += 3;

            if(loadingBar.Width >= 500)
            {
                timer1.Stop();
                mainForm fm1 = new mainForm(); // new form to continue 
                fm1.Show(); // showing new form
                this.Hide(); // closing the starter splash (startingForm)
            }
        }

        private void startingForm_Load(object sender, EventArgs e)
        {

        }

        private void loadingBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}