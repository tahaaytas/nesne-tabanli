namespace Uygulama5KarekterYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string kullanici_adi;
            kullanici_adi = textBox1.Text;
            if (kullanici_adi == "Naber Fıstık")
            {
                MessageBox.Show("Kullanıcı Sisteme Kayıtlıdır.");
            }
            else
            {
                MessageBox.Show("Kullanıcı Adınız Yanlıştır.");
            }
        }
    }
}
