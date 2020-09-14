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
    public partial class girisForm : Form
    {
        public girisForm()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V0HNS8O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        private void girisForm_Load(object sender, EventArgs e)
        {
           

        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand giris = new SqlCommand("Select * From Tbl_Yönetici where kullaniciId=@p1 and sifre=@p2", baglanti);
            giris.Parameters.AddWithValue("@p1", idTextBox.Text);
            giris.Parameters.AddWithValue("@p2", sifreTextBox.Text);
            SqlDataReader girisReader = giris.ExecuteReader();

            if (girisReader.Read())
            {
                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Şifre-Kullanıcı Adı yanlış!");
            }


            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
