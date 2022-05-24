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

namespace siparistakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GQ0R89C\\SQLEXPRESS;Initial Catalog=ElbiseSiparis;Integrated Security=True");

        public void listele()
        {
            this.elbiseSiparisTableAdapter.Fill(this.elbiseSiparisDataSet1.ElbiseSiparis);
        }
        public void temizle()
        {
            id.Text = "";
            ad.Text = "";
            soyad.Text = "";
            fiyat.Text = "";
            odememiktari.Checked = false;
            odemetamami.Checked = false;
            odememiktartxt.Text = "";
            tarih.Text = "";
            comboBox1.SelectedItem = null;
            pictureBox1.ImageLocation = null;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            odememiktartxt.Enabled = false;


        }

        private void kaydet_Click(object sender, EventArgs e)
        {

            if (odememiktartxt.Enabled == Enabled)
            {
                try
                {
                    int sayi;
                    if (odememiktartxt.Text == null)
                    {
                        sayi = Convert.ToInt32(fiyat.Text) - 0;
                    }
                    else
                    {
                        sayi = Convert.ToInt32(fiyat.Text) - Convert.ToInt32(odememiktartxt.Text);
                    }
                    label4.Text = sayi.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Miktar alanı boş bırakılamaz.");

                }
            }

            if (odememiktari.Checked)
            {

            }

            baglanti.Open();
            SqlCommand kaydet = new SqlCommand("insert into ElbiseSiparis (ad,soyad,fiyat,odeme,tarih,kargodurumu,resim) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
            kaydet.Parameters.AddWithValue("@p1", ad.Text);
            kaydet.Parameters.AddWithValue("@p2", soyad.Text);
            kaydet.Parameters.AddWithValue("@p3", fiyat.Text);
            kaydet.Parameters.AddWithValue("@p4", label4.Text);
            kaydet.Parameters.AddWithValue("@p5", tarih.Text);
            kaydet.Parameters.AddWithValue("@p6", comboBox1.Text);
            kaydet.Parameters.AddWithValue("@p7", label7.Text);
            kaydet.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş Girildi.");
            listele();
            temizle();
        }

        private void odemetamami_CheckedChanged(object sender, EventArgs e)
        {
            label4.Text = "Tamamı";
            odememiktartxt.Enabled = false;
        }

        private void odememiktari_CheckedChanged(object sender, EventArgs e)
        {
            odememiktartxt.Enabled = true;
        }

        private void odememiktartxt_TextChanged(object sender, EventArgs e)
        {
            label4.Text = odememiktartxt.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dosya = new OpenFileDialog();
           /*dosya.Filter = "Resim Dosyası |*.jpg;*.nef;*.png |  Tüm Dosyalar |*.*";*/
            dosya.ShowDialog();
            string dosyayolu = dosya.FileName;
            label7.Text = dosyayolu;
            pictureBox1.ImageLocation = dosyayolu;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            ad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            soyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            fiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            label4.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            tarih.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            label7.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            pictureBox1.ImageLocation = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
            if (label4.Text == "Tamamı")
            {
                odemetamami.Checked = true;
            }
            else
            {
                odememiktari.Checked = true;
            }
        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("delete from ElbiseSiparis where siparisid=@s1", baglanti);
            sil.Parameters.AddWithValue("@s1", id.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sipariş Silindi.");
            listele();
            temizle();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            if (odememiktartxt.Enabled == Enabled)
            {
                try
                {
                    int sayi;
                    if (odememiktartxt.Text == null)
                    {
                        sayi = Convert.ToInt32(fiyat.Text) - 0;
                    }
                    else
                    {
                        sayi = Convert.ToInt32(fiyat.Text) - Convert.ToInt32(odememiktartxt.Text);
                    }
                    label4.Text = sayi.ToString();
                }
                catch (Exception)
                {
                    MessageBox.Show("Miktar alanı boş bırakılamaz.");

                }
            }
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update ElbiseSiparis set ad=@a1,soyad=@a2,fiyat=@a3,odeme=@a4,tarih=@a5,kargodurumu=@a6,resim=@a7 where siparisid=@a8", baglanti);
            guncelle.Parameters.AddWithValue("@a1", ad.Text);
            guncelle.Parameters.AddWithValue("@a2", soyad.Text);
            guncelle.Parameters.AddWithValue("@a3", fiyat.Text);
            guncelle.Parameters.AddWithValue("@a4", label4.Text);
            guncelle.Parameters.AddWithValue("@a5", tarih.Text);
            guncelle.Parameters.AddWithValue("@a6", comboBox1.Text);
            guncelle.Parameters.AddWithValue("@a7", label7.Text);
            guncelle.Parameters.AddWithValue("@a8", id.Text);

            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme Başarılı.");
            listele();
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilen2 = dataGridView1.SelectedCells[0].RowIndex;

            baglanti.Open();
            SqlCommand tamamla = new SqlCommand("insert into tamamlanansiparis (siparisid,ad,soyad,fiyat,tarih,kargodurumu) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            tamamla.Parameters.AddWithValue("@p1", dataGridView1.Rows[secilen2].Cells[0].Value.ToString());
            tamamla.Parameters.AddWithValue("@p2", dataGridView1.Rows[secilen2].Cells[1].Value.ToString());
            tamamla.Parameters.AddWithValue("@p3", dataGridView1.Rows[secilen2].Cells[2].Value.ToString());
            tamamla.Parameters.AddWithValue("@p4", dataGridView1.Rows[secilen2].Cells[3].Value.ToString());
            tamamla.Parameters.AddWithValue("@p5", dataGridView1.Rows[secilen2].Cells[5].Value.ToString());
            tamamla.Parameters.AddWithValue("@p6", dataGridView1.Rows[secilen2].Cells[6].Value.ToString());
            

            tamamla.ExecuteNonQuery();
            
            MessageBox.Show("Sipariş Tamamlandı.");
            SqlCommand sil2 = new SqlCommand("delete from ElbiseSiparis where siparisid=@s1", baglanti);
            sil2.Parameters.AddWithValue("@s1", id.Text);
            sil2.ExecuteNonQuery();
            baglanti.Close();
            listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Tamamlanan tamamlanan = new Tamamlanan();
            tamamlanan.Show();
        }
    }
}
