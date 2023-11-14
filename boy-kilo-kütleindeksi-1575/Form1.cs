namespace boy_kilo_kütleindeksi_1575
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(txtBoy.Text);
            kilo = Convert.ToDouble(txtKilo.Text);
            vki = kilo / (boy * boy);
            lblVki.Text = vki.ToString("##.##");
            if (vki < 18)
            {
                lblSonuc.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                lblSonuc.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                lblSonuc.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                lblSonuc.Text = "Obez";
            }
            else
            {
                lblSonuc.Text = "Ciddi Obez";
            }

        }
    }
}