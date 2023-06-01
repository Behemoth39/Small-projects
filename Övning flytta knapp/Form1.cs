namespace Övning_flytta_knapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFlytta_Click(object sender, EventArgs e)
        {
            int xpos = int.Parse(tbxX.Text);
            int ypos = int.Parse(tbxY.Text);

            Point nyPosition = new Point(xpos, ypos);
            btnFlytta.Location = nyPosition;
        }
    }
}