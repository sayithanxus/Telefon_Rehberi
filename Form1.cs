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

namespace Telefon_Rehberi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sistem_islemleri();
            tablo_cek();
            tablo_sonrasi_duzenlemeler();
        }
        SqlConnection baglanti = new SqlConnection("server=LAPTOP-95FHUSSK;database=rehber_veritabani;Trusted_Connection=yes");
        SqlCommand komutlarim;
        SqlDataAdapter komut;
        DataSet tablo_seti = new DataSet();
        string id=" ";

        private void Form1_Load(object sender ,EventArgs e)
        {
           
        }
        private void sistem_islemleri()
        {
            arama_konusu_combo.Items.Add("AD GORE");
            arama_konusu_combo.Items.Add("SOYAD GORE");
            arama_konusu_combo.Items.Add("TELEFONA GORE");
            arama_konusu_combo.SelectedIndex = 2;
            telefon_turu_combo.Items.Add("EV");
            telefon_turu_combo.Items.Add("CEP");
            telefon_turu_combo.SelectedIndex = 1;
        }

        private void tablo_cek()
        {
            try
            {
                tablo_seti.Clear();
                baglanti.Open();
                komut = new SqlDataAdapter("select id,ad,soyad,telefon,(case telefon_turu when 0 then 'EV' when 1 then 'CEP' END) AS tt  from rehberim", baglanti);
                komut.Fill(tablo_seti, "rehberim");
                baglanti.Close();
                tablo_goster_dgv.DataSource = tablo_seti.Tables["rehberim"];
                rehberdeki_kisi_sayisi();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void tablo_sonrasi_duzenlemeler()
        {
            tablo_goster_dgv.Columns["id"].HeaderText = "ID";
            tablo_goster_dgv.Columns["ad"].HeaderText = "AD";
            tablo_goster_dgv.Columns["soyad"].HeaderText = "SOYAD";
            tablo_goster_dgv.Columns["telefon"].HeaderText = "TELEFON";
            tablo_goster_dgv.Columns["tt"].HeaderText = "TELEFON TÜRÜ";

            tablo_goster_dgv.Columns["id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablo_goster_dgv.Columns["ad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablo_goster_dgv.Columns["soyad"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablo_goster_dgv.Columns["telefon"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            tablo_goster_dgv.Columns["tt"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

   
        private void tablo_goster_dgv_Click(object sender, EventArgs e)
        {
            id = tablo_goster_dgv.CurrentRow.Cells[0].Value.ToString();
            if (goster_cb.Checked == true)
            {
                
                ad_tb.Text = tablo_goster_dgv.CurrentRow.Cells[1].Value.ToString();
                soyad_tb.Text = tablo_goster_dgv.CurrentRow.Cells[2].Value.ToString();
                telefon_masketb.Text = tablo_goster_dgv.CurrentRow.Cells[3].ToString();
                telefon_turu_combo.SelectedIndex = telefon_turu_combo.Items.IndexOf(tablo_goster_dgv.CurrentRow.Cells[4].ToString());
            }
            
        }

        private void ekle_btn_Click(object sender, EventArgs e)
        {

            try {
                
                baglanti.Open();

                komutlarim = new SqlCommand("insert into rehberim values('" + ad_tb.Text + "','" + soyad_tb.Text + "','" + telefon_masketb.Text + "','" + telefon_turu_combo.SelectedIndex + "')", baglanti);
                komutlarim.ExecuteNonQuery();
                baglanti.Close();
                tablo_cek();
                MessageBox.Show(ad_tb.Text.ToUpper() + " " + soyad_tb.Text.ToUpper()+ " "+  "REHBERE EKLENDİ ", "EKLENDI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch(Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void duzenle_btn_Click(object sender, EventArgs e)
        {

            try
            {

                if (id != " ")
                {
                    baglanti.Open();
                    komutlarim = new SqlCommand("update rehberim set ad='" + ad_tb.Text + "',soyad='" + soyad_tb.Text + "',telefon='" + telefon_masketb.Text + "',telefon_turu=" + telefon_turu_combo.SelectedIndex + " where id=" + id + " ", baglanti);
                    komutlarim.ExecuteNonQuery();
                    baglanti.Close();
                    tablo_cek();
                    MessageBox.Show(ad_tb.Text.ToUpper() + " " + soyad_tb.Text.ToUpper()+" " + "başarıyla güncellendi", "DÜZENLEME", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("Tablodan Seçim Yapınız..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void telefona_gore_sil_btn_Click(object sender, EventArgs e)
        {

            try
            {

                baglanti.Open();
                komutlarim = new SqlCommand("delete from rehberim where telefon='"+telefon_masketb.Text+"'",baglanti);
                komutlarim.ExecuteNonQuery();
                baglanti.Close();
                tablo_cek();
                MessageBox.Show("SİLME İŞLEMİ BAŞARIYLA UYGULANDI ", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void temizle_btn_Click(object sender, EventArgs e)
        {
            ad_tb.Text = soyad_tb.Text = telefon_masketb.Text = " ";
            telefon_turu_combo.SelectedIndex = 1;

        }

        private void arama_yap_btn_Click(object sender, EventArgs e)
        {
            try
            {
                tablo_seti.Clear();
                baglanti.Open();
                if (arama_konusu_combo.SelectedIndex == 0)
                {
                    komut = new SqlDataAdapter("select id,ad,soyad,telefon,(case telefon_turu when 0 then 'EV' when 1 then 'CEP' END) AS tt  from rehberim where ad like '%" + arama_bilgisi_tb.Text + "%'", baglanti);
                }
                else if (arama_konusu_combo.SelectedIndex == 1)
                {
                    komut = new SqlDataAdapter("select id,ad,soyad,telefon,(case telefon_turu when 0 then 'EV' when 1 then 'CEP' END) AS tt  from rehberim where soyad like '%" + arama_bilgisi_tb.Text + "%'", baglanti);
                }
                else if (arama_konusu_combo.SelectedIndex == 2)
                {
                    komut = new SqlDataAdapter("select id,ad,soyad,telefon,(case telefon_turu when 0 then 'EV' when 1 then 'CEP' END) AS tt  from rehberim where telefon like '%" + arama_bilgisi_tb.Text + "%'", baglanti);
                }

                komut.Fill(tablo_seti, "rehberim");
                baglanti.Close();
                tablo_goster_dgv.DataSource = tablo_seti.Tables["rehberim"];
                rehberdeki_kisi_sayisi();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void secili_sil_btn_Click(object sender, EventArgs e)
        {
            if (tablo_goster_dgv.CurrentRow.Cells[0].Value.ToString() != "")
            {
                
            try
            {

                baglanti.Open();
                komutlarim = new SqlCommand("delete from rehberim where id="+id,baglanti);
                komutlarim.ExecuteNonQuery();
                baglanti.Close();
                tablo_cek();
                MessageBox.Show("SEÇİLİ SATIR SİLME İŞLEMİ BAŞARIYLA UYGULANDI ", "SİLME", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString(), "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else
            {
                MessageBox.Show("Tablodan Seçim Yapınız..", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void rehberdeki_kisi_sayisi()
        {
            kisi_sayisi_label.Text = "Kişi Sayısı:" + (tablo_goster_dgv.RowCount-1);
        }
    }
}
