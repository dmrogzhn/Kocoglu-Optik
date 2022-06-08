using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KocogluOptik
{
    class CalisanIDAlma
    {
        public int idCalisan;
        public void IDAl()
        {
            //combobox tan gelen çalışan ismi ile veri tabanımızda ıd almayı burada yapıyoruz
            Form1 fr=new Form1();
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Calisan_ID_Getir ", baglanti);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CalisanAd", SqlDbType.NChar).Value = fr.cmbCalisanAd.Text;
            idCalisan = Convert.ToInt32(cmd.ExecuteScalar());
        }
    }
}
