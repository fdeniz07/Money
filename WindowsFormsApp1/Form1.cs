using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            uint tutar = uint.Parse(txtTutar.Text);
            uint nakitPara = uint.Parse(txtNakitPara.Text);
            uint paraUstu;

            uint[] paraTurleri = new uint[] { 100, 50, 10, 5, 1 };
            uint[] paraAdetleri = new uint[5];

            paraUstu = nakitPara - tutar;

            if (nakitPara <= tutar)
            {
                uint kalanOdenecekTutar;
                kalanOdenecekTutar = tutar - nakitPara;
                MessageBox.Show("Eksik Para Girdiniz Lütfen " + kalanOdenecekTutar + "TL Kadar daha para ekleyiniz.");
                lblParaUstu.Text = "";
            }
            else
            {
                lblParaUstu.Text = paraUstu.ToString();
                int i = 0;
                if (paraUstu % paraTurleri[i] != 0)
                {
                    for (int j = 0; j < paraAdetleri.Length; j++)
                    {
                        if (paraUstu % paraTurleri[j] != 0)
                        {
                            paraAdetleri[i] = paraUstu / paraTurleri[j];
                            paraUstu -= paraTurleri[j] * paraAdetleri[j];
                        }
                        else
                        {
                            paraAdetleri[i] = paraUstu / paraTurleri[j];
                            paraUstu -= paraTurleri[j] * paraAdetleri[j];
                        }
                        i++;
                        listBox1.Items.Add(paraTurleri[j]);
                        listBox2.Items.Add(paraAdetleri[j]);
                    }
                }
            }
            lbl100TL.Text = paraAdetleri[0].ToString();
            lbl50TL.Text = paraAdetleri[1].ToString();
            lbl10TL.Text = paraAdetleri[2].ToString();
            lbl5TL.Text = paraAdetleri[3].ToString(); 
            lbl1TL.Text = paraAdetleri[4].ToString();
        }

        private void btnTemizle_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }
    }
}
