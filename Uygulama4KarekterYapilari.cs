namespace Uygulama4KarekterYapilari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt32(textBox1.Text);
            if(sayi % 2 == 0)
            {
                MessageBox.Show("Bu bir çift sayıdır.");
            }
            if(sayi % 2== 1)
            {
                MessageBox.Show("Bu bir tek sayıdır.");
            }
        }
    }
}
