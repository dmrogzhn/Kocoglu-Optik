using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KocogluOptik
{
    public class MusteriEkle
    {
        public int idMust;
        public void ekle()
        {
            Form1 fr=new Form1();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");
            
            //Müşteri Eklendi With Prosedür

            baglanti.Open();
            SqlCommand cmd = new SqlCommand("Musteri_Ekle", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MusteriAd", SqlDbType.NChar).Value = fr.txtMusteriAd.Text;
            cmd.Parameters.AddWithValue("@MusteriSoyad", SqlDbType.NChar).Value = fr.txtMusteriSoyad.Text;
            cmd.Parameters.AddWithValue("@MusteriTelefon", SqlDbType.NChar).Value = fr.txtMusteriTelefon.Text;
            cmd.Parameters.AddWithValue("@MusteriTc", SqlDbType.NChar).Value = fr.txtMusteriTc.Text;
            cmd.Parameters.AddWithValue("@MusteriSehir", SqlDbType.NChar).Value = fr.txtMusteriAdres.Text;
            cmd.ExecuteNonQuery();
            baglanti.Close();

            //burada müşteri tablosundaki son id alınıyor ki biz müşteriyi ayrı siparişi ayrı almıyoruz. bu yüzden butona basıldığında eklediği müşteinin de ıd si alınıp sipariş tablsuna eklensin
            baglanti.Open();
            SqlCommand cmd3 = new SqlCommand("Select Ident_current('Musteri')", baglanti);
            idMust = Convert.ToInt32(cmd3.ExecuteScalar());
            cmd3.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
