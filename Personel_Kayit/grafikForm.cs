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


namespace Personel_Kayit
{
    public partial class grafikForm : Form
    {
        public grafikForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V0HNS8O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void grafikForm_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand chartKomut = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel Group By PerSehir ", baglanti);

            SqlDataReader sqlDataReader = chartKomut.ExecuteReader();

            while(sqlDataReader.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(sqlDataReader[0], sqlDataReader[1]);

            }
            sqlDataReader.Close();

            SqlCommand chartKomut2 = new SqlCommand("Select PerMeslek,Avg(PerMaas) From Tbl_Personel Group By PerMeslek", baglanti);

            SqlDataReader sqlDataReader2 = chartKomut2.ExecuteReader();

            while (sqlDataReader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(sqlDataReader2[0], sqlDataReader2[1]);

            }
            sqlDataReader2.Close();


            baglanti.Close();

        }

        
    }
}
