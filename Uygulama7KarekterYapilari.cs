using System.Diagnostics.Eventing.Reader;

namespace Uygulama7KarekterYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
}

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            int sonuc;
            if (radioButton1.Checked == true)
            {
                sonuc = deger1 + deger2;
                label4.Text = (deger1 + deger2).ToString();

            }
            else
            {
                sonuc = deger1 * deger2;
                label4.Text = (deger1 * deger2).ToString();
            }
        }
    }
}

