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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");


        private void Form5_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd = new SqlDataAdapter("select * from Calisan_Satislari", baglanti);
            DataSet ds = new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
