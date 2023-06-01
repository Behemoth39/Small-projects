using System.Text;

namespace övning___text_och_tecken
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKor_Click(object sender, EventArgs e)
        {
            string name1 = textBox1.Text;
            string name2 = textBox2.Text;                       

            StringBuilder strA = new StringBuilder(name1);
            char initial1 = strA[0];

            StringBuilder strB = new StringBuilder(name2);
            char initial2 = strB[0];

            labelInitials.Text = name1 +" "+ name2 + " har initialerna " + initial1 + "." + initial2 + ".";
        }
    }
}