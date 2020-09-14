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
    public partial class istatistikForm : Form
    {
        public istatistikForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V0HNS8O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void istatistikForm_Load(object sender, EventArgs e)
        {
            //Toplam Personel Sayısı
            baglanti.Open();
            SqlCommand personelKomut = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader personelReader = personelKomut.ExecuteReader();
            while (personelReader.Read())
            {
                toplamPersonelLabel.Text = personelReader[0].ToString();
            }
            personelReader.Close();
            ////Evli Personel Sayısı
            SqlCommand personelKomut2 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=1", baglanti);
            SqlDataReader personelReader2 = personelKomut2.ExecuteReader();
            while (personelReader2.Read())
            {
                evliPersonelLabel.Text = personelReader2[0].ToString();
            }
            personelReader2.Close();

            ////Bekar Personel Sayısı
            SqlCommand personelKomut3 = new SqlCommand("Select Count(*) From Tbl_Personel where PerDurum=0", baglanti);
            SqlDataReader personelReader3 = personelKomut3.ExecuteReader();
            while (personelReader3.Read())
            {
                bekarPersonelLabel.Text = personelReader3[0].ToString();
            }
            personelReader3.Close();

            ////Farklı Şehir Sayısı
            SqlCommand personelKomut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel ", baglanti);
            SqlDataReader personelReader4 = personelKomut4.ExecuteReader();
            while (personelReader4.Read())
            {
                farklıSehirLabel.Text = personelReader4[0].ToString();
            }
            personelReader4.Close();

            ////Toplam Maaş 
            SqlCommand personelKomut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel ", baglanti);
            SqlDataReader personelReader5 = personelKomut5.ExecuteReader();
            while (personelReader5.Read())
            {
               toplamMaasLabel.Text = personelReader5[0].ToString();
            }
            personelReader5.Close();

            ////Maaş Ortalaması 
            SqlCommand personelKomut6 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel ", baglanti);
            SqlDataReader personelReader6 = personelKomut6.ExecuteReader();
            while (personelReader6.Read())
            {
                ortalamaMaasLabel.Text = personelReader6[0].ToString();
            }
            personelReader6.Close();


            baglanti.Close();



        }
    }
}
