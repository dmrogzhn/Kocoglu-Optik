using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace KocogluOptik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //class ile almaya çalıştığımızda oluşan sorundan dolayı direkt burada alındı
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");

            baglanti.Open();
            SqlCommand command = new SqlCommand("select Calisan_Ad from Calisan", baglanti);
            SqlDataReader read = command.ExecuteReader();


            while (read.Read())
            {
                cmbCalisanAd.Items.Add(read[0]);
               

            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            MusteriEkle musteriEkle=new MusteriEkle();
            musteriEkle.ekle();

            UrunDetayEkle urunDetayEkle=new UrunDetayEkle();
            urunDetayEkle.ekle();

            SiparisEkle siparisEkle=new SiparisEkle();
            siparisEkle.ekle();

        }

        private void personelEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr2=new Form2();
            fr2.Show();
        }

        private void personelGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 fr4=new Form4();
            fr4.Show();
        }

        private void siparişGörüntüleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fr3=new Form3();
            fr3.Show();
        }

        private void personelSiparişBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 fr5=new Form5();
            fr5.Show();
        }
    }
}
