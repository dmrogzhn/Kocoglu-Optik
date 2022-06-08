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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TENBBEV\\SQLEXPRESS;Initial Catalog=KocogluOptik;Integrated Security=True");


        private void Form4_Load(object sender, EventArgs e)
        {
            SqlDataAdapter cmd=new SqlDataAdapter("select * from Calisan",baglanti);
            DataSet ds=new DataSet();
            cmd.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];


        }
    }
}
