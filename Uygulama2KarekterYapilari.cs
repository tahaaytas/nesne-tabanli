namespace Uygulama2KarekterYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte yas;
            yas = Convert.ToByte(textBox1.Text);
            if (yas > 17)
            {
                MessageBox.Show("Ehliyet Başvurusunda Bulunabilirsiniz.");
            }
        }
    }
}
