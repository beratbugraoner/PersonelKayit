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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V0HNS8O\\SQLEXPRESS;Initial Catalog=PersonelVeriTabani;Integrated Security=True");
        string evliMi;
        void temizle()
        {
            personelAd.Text = "";
            personelId.Text = "";
            personelMaas.Text = "";
            personelMeslek.Text = "";
            personelSehir.Text = "";
            personelSoyad.Text = "";
            evliButton.Checked = false;
            bekarButton.Checked = false;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);

        }

        private void listeleButton_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelVeriTabaniDataSet1.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
           
            if (evliButton.Checked==true || bekarButton.Checked==true)
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", personelAd.Text);
                komut.Parameters.AddWithValue("@p2", personelSoyad.Text);
                komut.Parameters.AddWithValue("@p3", personelSehir.Text);
                komut.Parameters.AddWithValue("@p4", personelMaas.Text);
                komut.Parameters.AddWithValue("@p5", personelMeslek.Text);
                

                if (evliButton.Checked == true)
                {
                    komut.Parameters.AddWithValue("@p6", "True");
                }
                else if (bekarButton.Checked == true)
                {

                    komut.Parameters.AddWithValue("@p6", "False");
                }

                komut.ExecuteNonQuery();
                this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
            }
            else
            {
                SqlCommand komut = new SqlCommand("insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                komut.Parameters.AddWithValue("@p1", personelAd.Text);
                komut.Parameters.AddWithValue("@p2", personelSoyad.Text);
                komut.Parameters.AddWithValue("@p3", personelSehir.Text);
                komut.Parameters.AddWithValue("@p4", personelMaas.Text);
                komut.Parameters.AddWithValue("@p5", personelMeslek.Text);
                
                komut.ExecuteNonQuery();
                this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
            }

           
            baglanti.Close();
            MessageBox.Show("Personel Eklendi!");
        }

        private void temizleButton_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void kayıtdataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenDeger = kayıtdataGrid.SelectedCells[0].RowIndex;

                personelId.Text = kayıtdataGrid.Rows[secilenDeger].Cells[0].Value.ToString();
                personelAd.Text = kayıtdataGrid.Rows[secilenDeger].Cells[1].Value.ToString();
                personelSoyad.Text = kayıtdataGrid.Rows[secilenDeger].Cells[2].Value.ToString();
                personelSehir.Text = kayıtdataGrid.Rows[secilenDeger].Cells[3].Value.ToString();
                personelMaas.Text = kayıtdataGrid.Rows[secilenDeger].Cells[4].Value.ToString();
                personelMeslek.Text = kayıtdataGrid.Rows[secilenDeger].Cells[6].Value.ToString();

                evliMi = kayıtdataGrid.Rows[secilenDeger].Cells[5].Value.ToString();


                if (evliMi == "True")
                {
                    evliButton.Checked = true;

                }
                else if (evliMi == "False")
                {
                    bekarButton.Checked = true;
                }


           
           

        }

        private void silButton_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand silKomutu = new SqlCommand("Delete From Tbl_Personel Where Perid=@k1",baglanti);
            silKomutu.Parameters.AddWithValue("@k1", personelId.Text);
            silKomutu.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi!");
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);

        }

        private void güncelleButton_Click(object sender, EventArgs e)
        {
        
            baglanti.Open();
            if (evliButton.Checked == true || bekarButton.Checked == true)
            {
                SqlCommand güncelleSql = new SqlCommand("Update Tbl_Personel Set PerAd=@ad,PerSoyad=@soyad,PerSehir=@sehir,PerMaas=@maas,PerDurum=@durum,PerMeslek=@meslek where Perid=@id", baglanti);
                güncelleSql.Parameters.AddWithValue("@ad", personelAd.Text);
                güncelleSql.Parameters.AddWithValue("@soyad", personelSoyad.Text);
                güncelleSql.Parameters.AddWithValue("@sehir", personelSehir.Text);
                güncelleSql.Parameters.AddWithValue("@maas", personelMaas.Text);
                güncelleSql.Parameters.AddWithValue("@id", personelId.Text);
                güncelleSql.Parameters.AddWithValue("@meslek", personelMeslek.Text);

                if (evliButton.Checked == true)
                {
                    güncelleSql.Parameters.AddWithValue("@durum", "True");
                }
                else if (bekarButton.Checked == true)
                {
                    güncelleSql.Parameters.AddWithValue("@durum", "False");
                }

                güncelleSql.ExecuteNonQuery();
                MessageBox.Show("GÜNCELLENDİ!");
            }
            else if (evliButton.Checked == false && bekarButton.Checked == false)
            {
                SqlCommand güncelleSql = new SqlCommand("Update Tbl_Personel Set PerAd=@ad,PerSoyad=@soyad,PerSehir=@sehir,PerMaas=@maas,PerMeslek=@meslek where Perid=@id", baglanti);
                güncelleSql.Parameters.AddWithValue("@ad", personelAd.Text);
                güncelleSql.Parameters.AddWithValue("@soyad", personelSoyad.Text);
                güncelleSql.Parameters.AddWithValue("@sehir", personelSehir.Text);
                güncelleSql.Parameters.AddWithValue("@maas", personelMaas.Text);
                güncelleSql.Parameters.AddWithValue("@id", personelId.Text);
                güncelleSql.Parameters.AddWithValue("@meslek", personelMeslek.Text);

                güncelleSql.ExecuteNonQuery();
                MessageBox.Show("GÜNCELLENDİ!");
            }         
            this.tbl_PersonelTableAdapter1.Fill(this.personelVeriTabaniDataSet1.Tbl_Personel);
            baglanti.Close();
           
        }

        private void istatistikButton_Click(object sender, EventArgs e)
        {
            istatistikForm form2 = new istatistikForm();
            form2.Show();
        }

        private void grafiklerButton_Click(object sender, EventArgs e)
        {
            grafikForm grafikler = new grafikForm();
            grafikler.Show();
        }
    }
}
