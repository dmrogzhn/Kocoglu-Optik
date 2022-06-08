using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KocogluOptik
{
    class SiparisEkle
    {
        public void ekle()
        {
           
            //prosedür ile eklendi
            CalisanIDAlma al = new CalisanIDAlma();
            MusteriEkle must = new MusteriEkle();
            UrunDetayEkle udet = new UrunDetayEkle();
            Form1 fr = new Form1();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");

            baglanti.Open();
            SqlCommand cmd6 = new SqlCommand("Siparis_Ekle", baglanti);
            cmd6.CommandType = CommandType.StoredProcedure;
            cmd6.Parameters.AddWithValue("@MusteriID", SqlDbType.SmallInt).Value = must.idMust;
            cmd6.Parameters.AddWithValue("@UrunDetayID", SqlDbType.SmallInt).Value = udet.idUrunDetay;
            cmd6.Parameters.AddWithValue("@ReceteNo", SqlDbType.NVarChar).Value = fr.txtReceteNo.Text;
            cmd6.Parameters.AddWithValue("@Fiyat", SqlDbType.SmallInt).Value = fr.txtFiyat.Text;
            cmd6.Parameters.AddWithValue("@Tarih", SqlDbType.Date).Value = fr.txtTarih.Text;
            cmd6.Parameters.AddWithValue("@CalisanID", SqlDbType.SmallInt).Value = al.idCalisan;
            cmd6.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
