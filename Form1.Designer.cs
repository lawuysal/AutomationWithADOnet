namespace adonettest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            sideBar = new Panel();
            hastaKayitEkran = new Panel();
            kayit_sil_button = new Button();
            groupBox2 = new GroupBox();
            dosya_no_tBox = new TextBox();
            dosya_no_label = new Label();
            button1 = new Button();
            dosya_no_bul_button = new Button();
            label2 = new Label();
            sevk_tarihi_label = new Label();
            kayitlar_hasta_soyadi_tBox = new TextBox();
            sevk_tarihi_dateP = new DateTimePicker();
            label1 = new Label();
            kayitlar_hasta_adi_tBox = new TextBox();
            groupBox1 = new GroupBox();
            doktor_isim_tBox = new TextBox();
            button2 = new Button();
            islem_ucret_tBox = new TextBox();
            label8 = new Label();
            sira_no_tBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            islem_sec_cBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            poliklinik_sec_cBox = new ComboBox();
            dataGridView1 = new DataGridView();
            fullHastaBilgiEkran = new Panel();
            label17 = new Label();
            label15 = new Label();
            bilgi_sevk_tarih = new DateTimePicker();
            bilgi_yas_tBox = new TextBox();
            label12 = new Label();
            label11 = new Label();
            bilgi_dogum_tarih = new DateTimePicker();
            bilgi_soyad_tBox = new TextBox();
            label10 = new Label();
            bilgi_ad_tBox = new TextBox();
            label9 = new Label();
            bilgi_TC_tBox = new TextBox();
            bilgi_TC = new Label();
            groupBox3 = new GroupBox();
            nullTaburcu = new TextBox();
            label16 = new Label();
            button3 = new Button();
            bilgi_adres_tBox = new TextBox();
            bilgi_taburcu_durum_tBox = new TextBox();
            label14 = new Label();
            bilgi_taburcu_tarih = new DateTimePicker();
            bilgi_cinsiyet_tBox = new TextBox();
            label13 = new Label();
            hasta_arama_ekran = new Panel();
            isimArama_tBox = new TextBox();
            groupBox4 = new GroupBox();
            hasta_arama_gridV = new DataGridView();
            button5 = new Button();
            label7 = new Label();
            button4 = new Button();
            hastaKayitEkran.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            fullHastaBilgiEkran.SuspendLayout();
            groupBox3.SuspendLayout();
            hasta_arama_ekran.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hasta_arama_gridV).BeginInit();
            SuspendLayout();
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.LightSkyBlue;
            sideBar.Location = new Point(1, 123);
            sideBar.Name = "sideBar";
            sideBar.Size = new Size(250, 428);
            sideBar.TabIndex = 0;
            // 
            // hastaKayitEkran
            // 
            hastaKayitEkran.BackColor = Color.SteelBlue;
            hastaKayitEkran.Controls.Add(kayit_sil_button);
            hastaKayitEkran.Controls.Add(groupBox2);
            hastaKayitEkran.Controls.Add(groupBox1);
            hastaKayitEkran.Controls.Add(dataGridView1);
            hastaKayitEkran.Location = new Point(257, 12);
            hastaKayitEkran.Name = "hastaKayitEkran";
            hastaKayitEkran.Size = new Size(1237, 706);
            hastaKayitEkran.TabIndex = 1;
            hastaKayitEkran.Paint += hastaKayit_Paint;
            // 
            // kayit_sil_button
            // 
            kayit_sil_button.Location = new Point(595, 624);
            kayit_sil_button.Name = "kayit_sil_button";
            kayit_sil_button.Size = new Size(94, 56);
            kayit_sil_button.TabIndex = 14;
            kayit_sil_button.Text = "Seçili Kaydı Sil";
            kayit_sil_button.UseVisualStyleBackColor = true;
            kayit_sil_button.Click += kayit_sil_button_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dosya_no_tBox);
            groupBox2.Controls.Add(dosya_no_label);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(dosya_no_bul_button);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(sevk_tarihi_label);
            groupBox2.Controls.Add(kayitlar_hasta_soyadi_tBox);
            groupBox2.Controls.Add(sevk_tarihi_dateP);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(kayitlar_hasta_adi_tBox);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(159, 30);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(389, 313);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hasta Bilgileri";
            // 
            // dosya_no_tBox
            // 
            dosya_no_tBox.Location = new Point(64, 67);
            dosya_no_tBox.Name = "dosya_no_tBox";
            dosya_no_tBox.Size = new Size(167, 27);
            dosya_no_tBox.TabIndex = 1;
            dosya_no_tBox.KeyDown += dosya_no_tBox_KeyDown;
            // 
            // dosya_no_label
            // 
            dosya_no_label.AutoSize = true;
            dosya_no_label.ForeColor = SystemColors.ButtonHighlight;
            dosya_no_label.Location = new Point(64, 43);
            dosya_no_label.Name = "dosya_no_label";
            dosya_no_label.Size = new Size(77, 20);
            dosya_no_label.TabIndex = 2;
            dosya_no_label.Text = "Dosya No:";
            dosya_no_label.Click += dosya_no_label_Click;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(237, 197);
            button1.Name = "button1";
            button1.Size = new Size(94, 89);
            button1.TabIndex = 11;
            button1.Text = "Tüm Hasta Bilgileri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dosya_no_bul_button
            // 
            dosya_no_bul_button.ForeColor = SystemColors.ActiveCaptionText;
            dosya_no_bul_button.Location = new Point(237, 67);
            dosya_no_bul_button.Name = "dosya_no_bul_button";
            dosya_no_bul_button.Size = new Size(94, 27);
            dosya_no_bul_button.TabIndex = 3;
            dosya_no_bul_button.Text = "Bul";
            dosya_no_bul_button.UseVisualStyleBackColor = true;
            dosya_no_bul_button.Click += dosya_no_bul_button_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(64, 236);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 10;
            label2.Text = "Soyadı:";
            // 
            // sevk_tarihi_label
            // 
            sevk_tarihi_label.AutoSize = true;
            sevk_tarihi_label.ForeColor = SystemColors.ButtonHighlight;
            sevk_tarihi_label.Location = new Point(64, 111);
            sevk_tarihi_label.Name = "sevk_tarihi_label";
            sevk_tarihi_label.Size = new Size(81, 20);
            sevk_tarihi_label.TabIndex = 5;
            sevk_tarihi_label.Text = "Sevk Tarihi:";
            // 
            // kayitlar_hasta_soyadi_tBox
            // 
            kayitlar_hasta_soyadi_tBox.Location = new Point(64, 259);
            kayitlar_hasta_soyadi_tBox.Name = "kayitlar_hasta_soyadi_tBox";
            kayitlar_hasta_soyadi_tBox.ReadOnly = true;
            kayitlar_hasta_soyadi_tBox.Size = new Size(167, 27);
            kayitlar_hasta_soyadi_tBox.TabIndex = 9;
            // 
            // sevk_tarihi_dateP
            // 
            sevk_tarihi_dateP.Enabled = false;
            sevk_tarihi_dateP.Location = new Point(64, 134);
            sevk_tarihi_dateP.Name = "sevk_tarihi_dateP";
            sevk_tarihi_dateP.Size = new Size(267, 27);
            sevk_tarihi_dateP.TabIndex = 6;
            sevk_tarihi_dateP.Value = new DateTime(2024, 1, 6, 16, 19, 15, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(64, 174);
            label1.Name = "label1";
            label1.Size = new Size(35, 20);
            label1.TabIndex = 8;
            label1.Text = "Adı:";
            // 
            // kayitlar_hasta_adi_tBox
            // 
            kayitlar_hasta_adi_tBox.Location = new Point(64, 197);
            kayitlar_hasta_adi_tBox.Name = "kayitlar_hasta_adi_tBox";
            kayitlar_hasta_adi_tBox.ReadOnly = true;
            kayitlar_hasta_adi_tBox.Size = new Size(167, 27);
            kayitlar_hasta_adi_tBox.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(doktor_isim_tBox);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(islem_ucret_tBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(sira_no_tBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(islem_sec_cBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(poliklinik_sec_cBox);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(554, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(534, 313);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yeni Kayıt";
            // 
            // doktor_isim_tBox
            // 
            doktor_isim_tBox.Location = new Point(65, 203);
            doktor_isim_tBox.Name = "doktor_isim_tBox";
            doktor_isim_tBox.ReadOnly = true;
            doktor_isim_tBox.Size = new Size(170, 27);
            doktor_isim_tBox.TabIndex = 17;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(330, 197);
            button2.Name = "button2";
            button2.Size = new Size(94, 33);
            button2.TabIndex = 16;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // islem_ucret_tBox
            // 
            islem_ucret_tBox.Location = new Point(297, 135);
            islem_ucret_tBox.Name = "islem_ucret_tBox";
            islem_ucret_tBox.ReadOnly = true;
            islem_ucret_tBox.Size = new Size(167, 27);
            islem_ucret_tBox.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(297, 111);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 15;
            label8.Text = "Ücret:";
            // 
            // sira_no_tBox
            // 
            sira_no_tBox.Location = new Point(65, 67);
            sira_no_tBox.Name = "sira_no_tBox";
            sira_no_tBox.ReadOnly = true;
            sira_no_tBox.Size = new Size(170, 27);
            sira_no_tBox.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(297, 43);
            label5.Name = "label5";
            label5.Size = new Size(47, 20);
            label5.TabIndex = 7;
            label5.Text = "İşlem:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(65, 43);
            label6.Name = "label6";
            label6.Size = new Size(61, 20);
            label6.TabIndex = 13;
            label6.Text = "Sıra No:";
            // 
            // islem_sec_cBox
            // 
            islem_sec_cBox.FormattingEnabled = true;
            islem_sec_cBox.Location = new Point(297, 66);
            islem_sec_cBox.Name = "islem_sec_cBox";
            islem_sec_cBox.Size = new Size(167, 28);
            islem_sec_cBox.TabIndex = 6;
            islem_sec_cBox.SelectedIndexChanged += islem_sec_cBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(65, 179);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Doktor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(65, 111);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 3;
            label3.Text = "Poliklinik:";
            // 
            // poliklinik_sec_cBox
            // 
            poliklinik_sec_cBox.FormattingEnabled = true;
            poliklinik_sec_cBox.Location = new Point(65, 134);
            poliklinik_sec_cBox.Name = "poliklinik_sec_cBox";
            poliklinik_sec_cBox.Size = new Size(167, 28);
            poliklinik_sec_cBox.TabIndex = 0;
            poliklinik_sec_cBox.SelectedIndexChanged += poliklinik_sec_cBox_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(223, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(795, 253);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // fullHastaBilgiEkran
            // 
            fullHastaBilgiEkran.BackColor = Color.DarkSeaGreen;
            fullHastaBilgiEkran.Controls.Add(label17);
            fullHastaBilgiEkran.Controls.Add(label15);
            fullHastaBilgiEkran.Controls.Add(bilgi_sevk_tarih);
            fullHastaBilgiEkran.Controls.Add(bilgi_yas_tBox);
            fullHastaBilgiEkran.Controls.Add(label12);
            fullHastaBilgiEkran.Controls.Add(label11);
            fullHastaBilgiEkran.Controls.Add(bilgi_dogum_tarih);
            fullHastaBilgiEkran.Controls.Add(bilgi_soyad_tBox);
            fullHastaBilgiEkran.Controls.Add(label10);
            fullHastaBilgiEkran.Controls.Add(bilgi_ad_tBox);
            fullHastaBilgiEkran.Controls.Add(label9);
            fullHastaBilgiEkran.Controls.Add(bilgi_TC_tBox);
            fullHastaBilgiEkran.Controls.Add(bilgi_TC);
            fullHastaBilgiEkran.Controls.Add(groupBox3);
            fullHastaBilgiEkran.Location = new Point(256, 12);
            fullHastaBilgiEkran.Name = "fullHastaBilgiEkran";
            fullHastaBilgiEkran.Size = new Size(1237, 706);
            fullHastaBilgiEkran.TabIndex = 2;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.ForeColor = SystemColors.ButtonHighlight;
            label17.Location = new Point(518, 161);
            label17.Name = "label17";
            label17.Size = new Size(120, 20);
            label17.TabIndex = 34;
            label17.Text = "Taburcu Durumu:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.ForeColor = SystemColors.ButtonHighlight;
            label15.Location = new Point(519, 314);
            label15.Name = "label15";
            label15.Size = new Size(81, 20);
            label15.TabIndex = 30;
            label15.Text = "Sevk Tarihi:";
            // 
            // bilgi_sevk_tarih
            // 
            bilgi_sevk_tarih.Enabled = false;
            bilgi_sevk_tarih.Location = new Point(518, 340);
            bilgi_sevk_tarih.Name = "bilgi_sevk_tarih";
            bilgi_sevk_tarih.Size = new Size(224, 27);
            bilgi_sevk_tarih.TabIndex = 29;
            bilgi_sevk_tarih.Value = new DateTime(2024, 1, 7, 17, 54, 46, 0);
            // 
            // bilgi_yas_tBox
            // 
            bilgi_yas_tBox.Location = new Point(148, 415);
            bilgi_yas_tBox.Name = "bilgi_yas_tBox";
            bilgi_yas_tBox.ReadOnly = true;
            bilgi_yas_tBox.Size = new Size(224, 27);
            bilgi_yas_tBox.TabIndex = 23;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ButtonHighlight;
            label12.Location = new Point(148, 389);
            label12.Name = "label12";
            label12.Size = new Size(33, 20);
            label12.TabIndex = 24;
            label12.Text = "Yaş:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ButtonHighlight;
            label11.Location = new Point(518, 389);
            label11.Name = "label11";
            label11.Size = new Size(101, 20);
            label11.TabIndex = 22;
            label11.Text = "Doğum Tarihi:";
            // 
            // bilgi_dogum_tarih
            // 
            bilgi_dogum_tarih.Enabled = false;
            bilgi_dogum_tarih.Location = new Point(518, 415);
            bilgi_dogum_tarih.Name = "bilgi_dogum_tarih";
            bilgi_dogum_tarih.Size = new Size(224, 27);
            bilgi_dogum_tarih.TabIndex = 21;
            bilgi_dogum_tarih.Value = new DateTime(2024, 1, 7, 17, 54, 46, 0);
            // 
            // bilgi_soyad_tBox
            // 
            bilgi_soyad_tBox.Location = new Point(148, 340);
            bilgi_soyad_tBox.Name = "bilgi_soyad_tBox";
            bilgi_soyad_tBox.ReadOnly = true;
            bilgi_soyad_tBox.Size = new Size(224, 27);
            bilgi_soyad_tBox.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(148, 314);
            label10.Name = "label10";
            label10.Size = new Size(53, 20);
            label10.TabIndex = 20;
            label10.Text = "Soyad:";
            // 
            // bilgi_ad_tBox
            // 
            bilgi_ad_tBox.Location = new Point(148, 265);
            bilgi_ad_tBox.Name = "bilgi_ad_tBox";
            bilgi_ad_tBox.ReadOnly = true;
            bilgi_ad_tBox.Size = new Size(224, 27);
            bilgi_ad_tBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(148, 239);
            label9.Name = "label9";
            label9.Size = new Size(31, 20);
            label9.TabIndex = 18;
            label9.Text = "Ad:";
            // 
            // bilgi_TC_tBox
            // 
            bilgi_TC_tBox.Location = new Point(148, 187);
            bilgi_TC_tBox.Name = "bilgi_TC_tBox";
            bilgi_TC_tBox.ReadOnly = true;
            bilgi_TC_tBox.Size = new Size(224, 27);
            bilgi_TC_tBox.TabIndex = 15;
            // 
            // bilgi_TC
            // 
            bilgi_TC.AutoSize = true;
            bilgi_TC.ForeColor = SystemColors.ButtonHighlight;
            bilgi_TC.Location = new Point(148, 161);
            bilgi_TC.Name = "bilgi_TC";
            bilgi_TC.Size = new Size(52, 20);
            bilgi_TC.TabIndex = 16;
            bilgi_TC.Text = "TC No:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(nullTaburcu);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(button3);
            groupBox3.Controls.Add(bilgi_adres_tBox);
            groupBox3.Controls.Add(bilgi_taburcu_durum_tBox);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(bilgi_taburcu_tarih);
            groupBox3.Controls.Add(bilgi_cinsiyet_tBox);
            groupBox3.Controls.Add(label13);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(81, 86);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1063, 512);
            groupBox3.TabIndex = 35;
            groupBox3.TabStop = false;
            groupBox3.Text = "Hasta Bilgileri";
            // 
            // nullTaburcu
            // 
            nullTaburcu.Enabled = false;
            nullTaburcu.Location = new Point(437, 179);
            nullTaburcu.Name = "nullTaburcu";
            nullTaburcu.ReadOnly = true;
            nullTaburcu.Size = new Size(224, 27);
            nullTaburcu.TabIndex = 35;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.ForeColor = SystemColors.ButtonHighlight;
            label16.Location = new Point(437, 153);
            label16.Name = "label16";
            label16.Size = new Size(102, 20);
            label16.TabIndex = 32;
            label16.Text = "Taburcu Tarihi:";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(488, 411);
            button3.Name = "button3";
            button3.Size = new Size(123, 56);
            button3.TabIndex = 34;
            button3.Text = "Sorgu Ekranına Dön";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // bilgi_adres_tBox
            // 
            bilgi_adres_tBox.Location = new Point(795, 176);
            bilgi_adres_tBox.Multiline = true;
            bilgi_adres_tBox.Name = "bilgi_adres_tBox";
            bilgi_adres_tBox.ReadOnly = true;
            bilgi_adres_tBox.Size = new Size(224, 180);
            bilgi_adres_tBox.TabIndex = 27;
            // 
            // bilgi_taburcu_durum_tBox
            // 
            bilgi_taburcu_durum_tBox.Location = new Point(437, 98);
            bilgi_taburcu_durum_tBox.Name = "bilgi_taburcu_durum_tBox";
            bilgi_taburcu_durum_tBox.ReadOnly = true;
            bilgi_taburcu_durum_tBox.Size = new Size(224, 27);
            bilgi_taburcu_durum_tBox.TabIndex = 33;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = SystemColors.ButtonHighlight;
            label14.Location = new Point(795, 153);
            label14.Name = "label14";
            label14.Size = new Size(50, 20);
            label14.TabIndex = 28;
            label14.Text = "Adres:";
            // 
            // bilgi_taburcu_tarih
            // 
            bilgi_taburcu_tarih.Enabled = false;
            bilgi_taburcu_tarih.Location = new Point(437, 180);
            bilgi_taburcu_tarih.Name = "bilgi_taburcu_tarih";
            bilgi_taburcu_tarih.Size = new Size(224, 27);
            bilgi_taburcu_tarih.TabIndex = 31;
            bilgi_taburcu_tarih.Value = new DateTime(2024, 1, 7, 17, 54, 46, 0);
            // 
            // bilgi_cinsiyet_tBox
            // 
            bilgi_cinsiyet_tBox.Location = new Point(795, 98);
            bilgi_cinsiyet_tBox.Name = "bilgi_cinsiyet_tBox";
            bilgi_cinsiyet_tBox.ReadOnly = true;
            bilgi_cinsiyet_tBox.Size = new Size(224, 27);
            bilgi_cinsiyet_tBox.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ButtonHighlight;
            label13.Location = new Point(795, 75);
            label13.Name = "label13";
            label13.Size = new Size(63, 20);
            label13.TabIndex = 26;
            label13.Text = "Cinsiyet:";
            // 
            // hasta_arama_ekran
            // 
            hasta_arama_ekran.BackColor = Color.Tan;
            hasta_arama_ekran.Controls.Add(isimArama_tBox);
            hasta_arama_ekran.Controls.Add(groupBox4);
            hasta_arama_ekran.Location = new Point(256, 13);
            hasta_arama_ekran.Name = "hasta_arama_ekran";
            hasta_arama_ekran.Size = new Size(1237, 706);
            hasta_arama_ekran.TabIndex = 3;
            // 
            // isimArama_tBox
            // 
            isimArama_tBox.Location = new Point(452, 216);
            isimArama_tBox.Name = "isimArama_tBox";
            isimArama_tBox.Size = new Size(335, 27);
            isimArama_tBox.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(hasta_arama_gridV);
            groupBox4.Controls.Add(button5);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(button4);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(101, 55);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(1060, 584);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Hasta Adı İle Arama";
            // 
            // hasta_arama_gridV
            // 
            hasta_arama_gridV.AllowUserToAddRows = false;
            hasta_arama_gridV.AllowUserToDeleteRows = false;
            hasta_arama_gridV.AllowUserToOrderColumns = true;
            hasta_arama_gridV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hasta_arama_gridV.Location = new Point(296, 281);
            hasta_arama_gridV.Name = "hasta_arama_gridV";
            hasta_arama_gridV.ReadOnly = true;
            hasta_arama_gridV.RowHeadersWidth = 51;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            hasta_arama_gridV.RowsDefaultCellStyle = dataGridViewCellStyle1;
            hasta_arama_gridV.RowTemplate.Height = 29;
            hasta_arama_gridV.ScrollBars = ScrollBars.Vertical;
            hasta_arama_gridV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hasta_arama_gridV.Size = new Size(428, 188);
            hasta_arama_gridV.TabIndex = 1;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(468, 211);
            button5.Name = "button5";
            button5.Size = new Size(109, 29);
            button5.TabIndex = 2;
            button5.Text = "Ara";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(351, 138);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 1;
            label7.Text = "Hasta Adı:";
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Location = new Point(468, 487);
            button4.Name = "button4";
            button4.Size = new Size(109, 55);
            button4.TabIndex = 0;
            button4.Text = "Seç";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1506, 730);
            Controls.Add(sideBar);
            Controls.Add(fullHastaBilgiEkran);
            Controls.Add(hasta_arama_ekran);
            Controls.Add(hastaKayitEkran);
            Name = "Form1";
            Text = "Form1";
            hastaKayitEkran.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            fullHastaBilgiEkran.ResumeLayout(false);
            fullHastaBilgiEkran.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            hasta_arama_ekran.ResumeLayout(false);
            hasta_arama_ekran.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)hasta_arama_gridV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sideBar;
        private Panel hastaKayitEkran;
        private DataGridView dataGridView1;
        private Label dosya_no_label;
        private TextBox dosya_no_tBox;
        private DateTimePicker sevk_tarihi_dateP;
        private Label sevk_tarihi_label;
        private Button dosya_no_bul_button;
        private GroupBox groupBox1;
        private Button button1;
        private Label label2;
        private TextBox kayitlar_hasta_soyadi_tBox;
        private Label label1;
        private GroupBox groupBox2;
        private ComboBox poliklinik_sec_cBox;
        private Label label3;
        private Label label5;
        private ComboBox islem_sec_cBox;
        private Label label4;
        private TextBox sira_no_tBox;
        private Label label6;
        private TextBox islem_ucret_tBox;
        private Label label8;
        private Button button2;
        public TextBox kayitlar_hasta_adi_tBox;
        private TextBox doktor_isim_tBox;
        private Button kayit_sil_button;
        private Panel fullHastaBilgiEkran;
        private TextBox bilgi_ad_tBox;
        private Label label9;
        private TextBox bilgi_TC_tBox;
        private Label bilgi_TC;
        private DateTimePicker bilgi_dogum_tarih;
        private TextBox bilgi_soyad_tBox;
        private Label label10;
        private TextBox bilgi_yas_tBox;
        private Label label12;
        private Label label11;
        private Label label16;
        private DateTimePicker bilgi_taburcu_tarih;
        private Label label15;
        private DateTimePicker bilgi_sevk_tarih;
        private TextBox bilgi_adres_tBox;
        private Label label14;
        private TextBox bilgi_cinsiyet_tBox;
        private Label label13;
        private TextBox bilgi_taburcu_durum_tBox;
        private Label label17;
        private GroupBox groupBox3;
        private Button button3;
        private TextBox nullTaburcu;
        private Panel hasta_arama_ekran;
        private DataGridView hasta_arama_gridV;
        private TextBox isimArama_tBox;
        private GroupBox groupBox4;
        private Label label7;
        private Button button4;
        private Button button5;
    }
}