namespace Uygylama3KarekterYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte sayi1, sayi2;
            sayi1 = Convert.ToByte(textBox1.Text);
            sayi2 = Convert.ToByte(textBox2.Text);
            if (sayi1 > sayi2)
            {
                MessageBox.Show("1.Sayı 2.Sayıdan Büyüktür.");
            }
            if (sayi1 == sayi2)
            {
                MessageBox.Show("Sayılar Birbirine Eşittir.");
            }
            if (sayi1 < sayi2)
            {
                MessageBox.Show("2.Sayı 1.Sayıdan Büyüktür.");
            }
        }

        private void InitializeComponent()
        {

        }
    }
}

