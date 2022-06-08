using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KocogluOptik
{
    class CalisanAdEkleme
    {
        public void adEkle()
        {
            // burada combo box a sql den çalışan isimleri alınıp gösterilmek istendi fakat load da kabul edilmedi
            
            Form1 fr=new Form1();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");

            baglanti.Open();
            SqlCommand command = new SqlCommand("select Calisan_ID, Calisan_Ad from Calisan", baglanti);
            SqlDataReader read = command.ExecuteReader();
            

            while (read.Read())
            {
                fr.cmbCalisanAd.DisplayMember = read["Calisan_Ad"].ToString();
                fr.cmbCalisanAd.ValueMember = read["Calisan_ID"].ToString();

            }
            baglanti.Close();

        }
    }
}
