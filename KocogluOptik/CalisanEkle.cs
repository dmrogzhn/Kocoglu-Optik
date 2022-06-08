using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KocogluOptik
{
    class CalisanEkle
    {
        public void ekle()
        {
            //prosedür ile eklendi
            Form2 fr2 = new Form2();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");

            baglanti.Open();
            SqlCommand da = new SqlCommand("Calisan_Ekle ", baglanti);
            da.CommandType = CommandType.StoredProcedure;
            da.Parameters.AddWithValue("@CalisanAd", SqlDbType.NChar).Value = fr2.txtad.Text;
            da.Parameters.AddWithValue("@CalisanSoyad", SqlDbType.NChar).Value = fr2.txtsoyad.Text;
            da.Parameters.AddWithValue("@CalisanTelefon", SqlDbType.NChar).Value = fr2.txttelefon.Text;
            da.Parameters.AddWithValue("@CalisanCinsiyet", SqlDbType.NChar).Value = fr2.txtcinsiyet.Text;
            da.Parameters.AddWithValue("@CalisanAdres", SqlDbType.NVarChar).Value = fr2.txtadres.Text;
            da.Parameters.AddWithValue("@CalisanGirisTarihi", SqlDbType.Date).Value = fr2.maskedTextBox1.Text;//masked yaparken sql e göre düzenlemeyi unutma text tasarımını
            da.ExecuteNonQuery();
            baglanti.Close();
        }
    }
}
