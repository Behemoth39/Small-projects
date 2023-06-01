namespace Övning_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKlick_Click(object sender, EventArgs e)
        {
            int tal1 = Int32.Parse(tbxTal1.Text);
            int tal2 = Int32.Parse(tbxTal2.Text);
            int tal3 = tal1 + tal2;
            lblSumma.Text = lblSumma.Text +" "+ Convert.ToString(tal3);
        }
    }
}