
namespace Telefon_Rehberi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kisi_sayisi_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.telefon_turu_combo = new System.Windows.Forms.ComboBox();
            this.arama_konusu_combo = new System.Windows.Forms.ComboBox();
            this.ad_tb = new System.Windows.Forms.TextBox();
            this.arama_bilgisi_tb = new System.Windows.Forms.TextBox();
            this.soyad_tb = new System.Windows.Forms.TextBox();
            this.telefon_masketb = new System.Windows.Forms.MaskedTextBox();
            this.arama_yap_btn = new System.Windows.Forms.Button();
            this.telefona_gore_sil_btn = new System.Windows.Forms.Button();
            this.duzenle_btn = new System.Windows.Forms.Button();
            this.temizle_btn = new System.Windows.Forms.Button();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tablo_goster_dgv = new System.Windows.Forms.DataGridView();
            this.goster_cb = new System.Windows.Forms.CheckBox();
            this.secili_sil_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablo_goster_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "soyadı:";
            // 
            // kisi_sayisi_label
            // 
            this.kisi_sayisi_label.AutoSize = true;
            this.kisi_sayisi_label.Location = new System.Drawing.Point(386, 244);
            this.kisi_sayisi_label.Name = "kisi_sayisi_label";
            this.kisi_sayisi_label.Size = new System.Drawing.Size(0, 17);
            this.kisi_sayisi_label.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "ARMA İŞLEMLERİ";
            // 
            // telefon_turu_combo
            // 
            this.telefon_turu_combo.FormattingEnabled = true;
            this.telefon_turu_combo.Location = new System.Drawing.Point(112, 214);
            this.telefon_turu_combo.Name = "telefon_turu_combo";
            this.telefon_turu_combo.Size = new System.Drawing.Size(222, 24);
            this.telefon_turu_combo.TabIndex = 7;
            // 
            // arama_konusu_combo
            // 
            this.arama_konusu_combo.FormattingEnabled = true;
            this.arama_konusu_combo.Location = new System.Drawing.Point(30, 46);
            this.arama_konusu_combo.Name = "arama_konusu_combo";
            this.arama_konusu_combo.Size = new System.Drawing.Size(149, 24);
            this.arama_konusu_combo.TabIndex = 8;
            // 
            // ad_tb
            // 
            this.ad_tb.Location = new System.Drawing.Point(79, 112);
            this.ad_tb.Name = "ad_tb";
            this.ad_tb.Size = new System.Drawing.Size(255, 22);
            this.ad_tb.TabIndex = 9;
            // 
            // arama_bilgisi_tb
            // 
            this.arama_bilgisi_tb.Location = new System.Drawing.Point(185, 49);
            this.arama_bilgisi_tb.Name = "arama_bilgisi_tb";
            this.arama_bilgisi_tb.Size = new System.Drawing.Size(171, 22);
            this.arama_bilgisi_tb.TabIndex = 10;
            // 
            // soyad_tb
            // 
            this.soyad_tb.Location = new System.Drawing.Point(79, 147);
            this.soyad_tb.Name = "soyad_tb";
            this.soyad_tb.Size = new System.Drawing.Size(255, 22);
            this.soyad_tb.TabIndex = 11;
            // 
            // telefon_masketb
            // 
            this.telefon_masketb.Location = new System.Drawing.Point(79, 180);
            this.telefon_masketb.Mask = "(999) 000-0000";
            this.telefon_masketb.Name = "telefon_masketb";
            this.telefon_masketb.Size = new System.Drawing.Size(255, 22);
            this.telefon_masketb.TabIndex = 12;
            // 
            // arama_yap_btn
            // 
            this.arama_yap_btn.Location = new System.Drawing.Point(362, 49);
            this.arama_yap_btn.Name = "arama_yap_btn";
            this.arama_yap_btn.Size = new System.Drawing.Size(105, 23);
            this.arama_yap_btn.TabIndex = 13;
            this.arama_yap_btn.Text = "ARAMA YAP";
            this.arama_yap_btn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.arama_yap_btn.UseVisualStyleBackColor = true;
            this.arama_yap_btn.Click += new System.EventHandler(this.arama_yap_btn_Click);
            // 
            // telefona_gore_sil_btn
            // 
            this.telefona_gore_sil_btn.Location = new System.Drawing.Point(340, 179);
            this.telefona_gore_sil_btn.Name = "telefona_gore_sil_btn";
            this.telefona_gore_sil_btn.Size = new System.Drawing.Size(127, 23);
            this.telefona_gore_sil_btn.TabIndex = 14;
            this.telefona_gore_sil_btn.Text = "telefona göre sil";
            this.telefona_gore_sil_btn.UseVisualStyleBackColor = true;
            this.telefona_gore_sil_btn.Click += new System.EventHandler(this.telefona_gore_sil_btn_Click);
            // 
            // duzenle_btn
            // 
            this.duzenle_btn.Location = new System.Drawing.Point(340, 143);
            this.duzenle_btn.Name = "duzenle_btn";
            this.duzenle_btn.Size = new System.Drawing.Size(127, 23);
            this.duzenle_btn.TabIndex = 15;
            this.duzenle_btn.Text = "düzenle";
            this.duzenle_btn.UseVisualStyleBackColor = true;
            this.duzenle_btn.Click += new System.EventHandler(this.duzenle_btn_Click);
            // 
            // temizle_btn
            // 
            this.temizle_btn.Location = new System.Drawing.Point(340, 208);
            this.temizle_btn.Name = "temizle_btn";
            this.temizle_btn.Size = new System.Drawing.Size(127, 23);
            this.temizle_btn.TabIndex = 16;
            this.temizle_btn.Text = "temizle";
            this.temizle_btn.UseVisualStyleBackColor = true;
            this.temizle_btn.Click += new System.EventHandler(this.temizle_btn_Click);
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(340, 111);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(127, 23);
            this.ekle_btn.TabIndex = 17;
            this.ekle_btn.Text = "ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 217);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "telefon turu:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(232, 17);
            this.label12.TabIndex = 22;
            this.label12.Text = "Rehber Ekleme ve Güncelleme Yeri";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 17);
            this.label13.TabIndex = 23;
            this.label13.Text = "telefon";
            // 
            // tablo_goster_dgv
            // 
            this.tablo_goster_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tablo_goster_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.tablo_goster_dgv.Location = new System.Drawing.Point(17, 265);
            this.tablo_goster_dgv.Name = "tablo_goster_dgv";
            this.tablo_goster_dgv.RowHeadersWidth = 51;
            this.tablo_goster_dgv.RowTemplate.Height = 24;
            this.tablo_goster_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablo_goster_dgv.Size = new System.Drawing.Size(450, 145);
            this.tablo_goster_dgv.TabIndex = 24;
            this.tablo_goster_dgv.Click += new System.EventHandler(this.tablo_goster_dgv_Click);
            // 
            // goster_cb
            // 
            this.goster_cb.AutoSize = true;
            this.goster_cb.Location = new System.Drawing.Point(17, 420);
            this.goster_cb.Name = "goster_cb";
            this.goster_cb.Size = new System.Drawing.Size(217, 21);
            this.goster_cb.TabIndex = 25;
            this.goster_cb.Text = "Seçili kişilerin bilgilerini göster";
            this.goster_cb.UseVisualStyleBackColor = true;
            // 
            // secili_sil_btn
            // 
            this.secili_sil_btn.Location = new System.Drawing.Point(340, 412);
            this.secili_sil_btn.Name = "secili_sil_btn";
            this.secili_sil_btn.Size = new System.Drawing.Size(127, 29);
            this.secili_sil_btn.TabIndex = 26;
            this.secili_sil_btn.Text = "Seçili olanı sil";
            this.secili_sil_btn.UseVisualStyleBackColor = true;
            this.secili_sil_btn.Click += new System.EventHandler(this.secili_sil_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.secili_sil_btn);
            this.Controls.Add(this.goster_cb);
            this.Controls.Add(this.tablo_goster_dgv);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.temizle_btn);
            this.Controls.Add(this.duzenle_btn);
            this.Controls.Add(this.telefona_gore_sil_btn);
            this.Controls.Add(this.arama_yap_btn);
            this.Controls.Add(this.telefon_masketb);
            this.Controls.Add(this.soyad_tb);
            this.Controls.Add(this.arama_bilgisi_tb);
            this.Controls.Add(this.ad_tb);
            this.Controls.Add(this.arama_konusu_combo);
            this.Controls.Add(this.telefon_turu_combo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.kisi_sayisi_label);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tablo_goster_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label kisi_sayisi_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox telefon_turu_combo;
        private System.Windows.Forms.ComboBox arama_konusu_combo;
        private System.Windows.Forms.TextBox ad_tb;
        private System.Windows.Forms.TextBox arama_bilgisi_tb;
        private System.Windows.Forms.TextBox soyad_tb;
        private System.Windows.Forms.MaskedTextBox telefon_masketb;
        private System.Windows.Forms.Button arama_yap_btn;
        private System.Windows.Forms.Button telefona_gore_sil_btn;
        private System.Windows.Forms.Button duzenle_btn;
        private System.Windows.Forms.Button temizle_btn;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView tablo_goster_dgv;
        private System.Windows.Forms.CheckBox goster_cb;
        private System.Windows.Forms.Button secili_sil_btn;
    }
}

