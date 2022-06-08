using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KocogluOptik
{
    class UrunDetayEkle
    {
        public int idUrunDetay;
        public void ekle()
        {
            Form1 fr = new Form1();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");

            baglanti.Open();
            SqlCommand cmd2 = new SqlCommand("Urun_Detay_Ekle", baglanti);
            cmd2.CommandType = CommandType.StoredProcedure;
            cmd2.Parameters.AddWithValue("@CerceveTuru", SqlDbType.NChar).Value = fr.cmbCerceve.Text;
            cmd2.Parameters.AddWithValue("@CamRengi", SqlDbType.NChar).Value = fr.cmbCamRenk.Text;
            cmd2.Parameters.AddWithValue("@CamTürü", SqlDbType.NChar).Value = fr.cmbCamTur.Text;
            cmd2.Parameters.AddWithValue("@Filtre", SqlDbType.NChar).Value = fr.cmbFiltre.Text;
            cmd2.Parameters.AddWithValue("@SagSPH", SqlDbType.NChar).Value = fr.txtSagSPH.Text;
            cmd2.Parameters.AddWithValue("@SagCYL", SqlDbType.NChar).Value = fr.txtSagCYL.Text;
            cmd2.Parameters.AddWithValue("@SagAXS", SqlDbType.NChar).Value = fr.txtSagAXIS.Text;
            cmd2.Parameters.AddWithValue("@SagADD", SqlDbType.NChar).Value = fr.txtSagADD.Text;
            cmd2.Parameters.AddWithValue("@SolSPH", SqlDbType.NChar).Value = fr.txtSolSPH.Text;
            cmd2.Parameters.AddWithValue("@SolCYL", SqlDbType.NChar).Value = fr.txtSolCYL.Text;
            cmd2.Parameters.AddWithValue("@SolAXS", SqlDbType.NChar).Value = fr.txtSolAXIS.Text;
            cmd2.Parameters.AddWithValue("@SolADD", SqlDbType.NChar).Value = fr.txtSolADD.Text;
            cmd2.Parameters.AddWithValue("@Not", SqlDbType.Text).Value = fr.txtNot.Text;
            cmd2.ExecuteNonQuery();
            baglanti.Close();
            baglanti.Open();
            //burada ürün detay tablosundaki son id alınıyor ki biz ürün detayı ayrı siparişi ayrı almıyoruz. bu yüzden butona basıldığında eklediği ürün detayın de ıd si alınıp sipariş tablsuna eklensin
            SqlCommand cmd4 = new SqlCommand("select ident_current('Urun_Detay')", baglanti);
            idUrunDetay = Convert.ToInt32(cmd4.ExecuteScalar());
            cmd4.ExecuteNonQuery();
            baglanti.Close();
        }
       
    }
}
