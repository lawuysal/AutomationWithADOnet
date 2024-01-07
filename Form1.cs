using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace adonettest
{
    public partial class Form1 : Form
    {
        public static SqlConnection con = new SqlConnection();

        public Form1()
        {
            InitializeComponent();
            SqlConnection conP = new SqlConnection("data source=.\\SQLExpress; database=KEK; Trusted_Connection=true; TrustServerCertificate=true; User ID=raylaw; pwd=7768439; ");

            con = conP;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dosya_no_label_Click(object sender, EventArgs e)
        {

        }

        private void hastaKayit_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dosya_no_bul_button_Click(object sender, EventArgs e)
        {
            hasta_arama_ekran.BringToFront();
        }

        private void dosya_no_tBox_Enter(object sender, EventArgs e)
        {

        }

        // Sorgu ekrani enter tuþu
        private void dosya_no_tBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                hastaKayitEkran.BringToFront();
                App.seciliDosyaNo = dosya_no_tBox.Text;
                try
                {
                    SqlCommand hastaBilgiCmd = new SqlCommand($"select ad Ad, soyad Soyad, CAST(dogum_tarihi as DATE) Dogum, cinsiyet Cinsiyet," +
                        $" adres Adres, CAST(sevk_tarihi as DATE) Sevk, taburcu_tarihi TaburcuT, taburcu_durumu TaburcuD " +
                        $"from Hasta where dosya_no = '{App.seciliDosyaNo}'", con);

                    SqlCommand hastaKayitCmd = new SqlCommand($"" +
                         $"select distinct pol.poliklinik_isim Poliklinik, dok.doktor_adi + ' ' + dok.doktor_soyadi Doktor,\r\n" +
                         $"isl.islem_isim Ýþlem, kay.sira_no SýraNo, CAST(kay.kayit_tarihi AS DATE) Tarih,\r\n" +
                         $"isl.fiyat Ücret, kay.kayit_id KayýtID\r\n" +
                         $"from kayitlar as kay \r\n" +
                         $"join hasta as has on kay.hasta_id =  '{App.seciliDosyaNo}'\r\n" +
                         $"join poliklinik as pol on kay.poliklinik_id = pol.poliklinik_id\r\n" +
                         $"join doktor as dok on kay.doktor_id = dok.doktor_id\r\n" +
                         $"join islemler as isl on kay.islem_id = isl.islem_id", con);

                    SqlCommand YK_poliklinikSecCmd = new SqlCommand($"select pol.poliklinik_id Id, pol.poliklinik_isim Ýsim, pol.doktor_id DoktorId, " +
                        $"dok.doktor_adi + ' ' + dok.doktor_soyadi DoktorAdi from poliklinik pol join doktor dok on pol.doktor_id = dok.doktor_id;", con);

                    SqlCommand YK_islemSecCmd = new SqlCommand($"select islem_id Id, islem_isim Ýsim, fiyat Ücret from islemler;", con);

                    con.Open();
                    SqlDataReader hastaBilgiResult = hastaBilgiCmd.ExecuteReader();

                    SqlDataAdapter hastaKayitlarAdapter = new SqlDataAdapter(hastaKayitCmd);
                    DataTable dataTable = new DataTable();


                    if (hastaBilgiResult.Read())
                    {
                        kayitlar_hasta_adi_tBox.Text = hastaBilgiResult["Ad"].ToString();
                        kayitlar_hasta_soyadi_tBox.Text = hastaBilgiResult["Soyad"].ToString();
                        sevk_tarihi_dateP.Value = Convert.ToDateTime(hastaBilgiResult["Sevk"].ToString());

                        App.seciliDosyaNo = dosya_no_tBox.Text;
                        App.seciliSevkTarihi = Convert.ToDateTime(hastaBilgiResult["Sevk"].ToString());
                        App.seciliHastaAdi = hastaBilgiResult["Ad"].ToString();
                        App.seciliHastaSoyadi = hastaBilgiResult["Soyad"].ToString();
                        App.seciliHastaDogumTarihi = Convert.ToDateTime(hastaBilgiResult["Dogum"].ToString());
                        App.seciliHastaCinsiyet = hastaBilgiResult["Cinsiyet"].ToString();
                        App.seciliHastaAdresi = hastaBilgiResult["Adres"].ToString();
                        App.seciliHastaTaburcuTarihi = hastaBilgiResult["TaburcuT"].ToString() == "" ? null : Convert.ToDateTime(hastaBilgiResult["TaburcuT"].ToString());
                        App.seciliHastaTaburcuDurumu = hastaBilgiResult["TaburcuD"].ToString();
                        if (App.seciliHastaTaburcuDurumu == "False")
                        {
                            nullTaburcu.Visible = true;
                            bilgi_taburcu_tarih.Visible = false;
                        }
                        else
                        {
                            nullTaburcu.Visible = false;
                            bilgi_taburcu_tarih.Visible = true;
                            bilgi_taburcu_tarih.Text = App.seciliHastaTaburcuTarihi.ToString();
                        }


                        bilgi_TC_tBox.Text = App.seciliDosyaNo;
                        bilgi_ad_tBox.Text = App.seciliHastaAdi;
                        bilgi_soyad_tBox.Text = App.seciliHastaSoyadi;
                        bilgi_yas_tBox.Text = (DateTime.Now.Year - App.seciliHastaDogumTarihi.Year).ToString();
                        bilgi_cinsiyet_tBox.Text = App.seciliHastaCinsiyet == "True" ? "Erkek" : "Kadýn";
                        bilgi_adres_tBox.Text = App.seciliHastaAdresi;
                        // if the string is empty, set the value to null
                        bilgi_taburcu_tarih.Text = App.seciliSevkTarihi.ToString() ?? "";
                        bilgi_taburcu_durum_tBox.Text = App.seciliHastaTaburcuDurumu == "True" ? "Taburcu oldu" : "Taburcu olmadý";
                        bilgi_sevk_tarih.Text = App.seciliSevkTarihi.ToString();
                        bilgi_dogum_tarih.Text = App.seciliHastaDogumTarihi.ToString();

                        hastaBilgiResult.Close();

                        hastaKayitlarAdapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                        //MessageBox.Show(dataGridView1.ColumnCount.ToString());
                        hastaKayitlarAdapter.Dispose();
                        dataTable.Dispose();

                        poliklinik_sec_cBox.Text = "";
                        islem_sec_cBox.Text = "";
                        poliklinik_sec_cBox.Items.Clear();
                        islem_sec_cBox.Items.Clear();

                        // Poliklinikleri initialize et
                        List<string> isimler = new List<string>();
                        List<int> IDler = new List<int>();
                        List<int> doktorIDler = new List<int>();
                        List<string> doktorAdlari = new List<string>();
                        List<double> ucretler = new List<double>();

                        SqlDataReader poliklinikSeciciResult = YK_poliklinikSecCmd.ExecuteReader();
                        while (poliklinikSeciciResult.Read())
                        {
                            string isim = poliklinikSeciciResult["Ýsim"].ToString();
                            int id = Convert.ToInt32(poliklinikSeciciResult["Id"]);
                            int doktorID = Convert.ToInt32(poliklinikSeciciResult["DoktorId"]);
                            string doktorAdi = poliklinikSeciciResult["DoktorAdi"].ToString();



                            // Poliklinik Liste'lere ekle
                            isimler.Add(isim);
                            IDler.Add(id);
                            doktorIDler.Add(doktorID);
                            doktorAdlari.Add(doktorAdi);

                        }

                        Dictionary<string, Dictionary<int, Dictionary<int, string>>> tempDictionaryPoliklinikler
                            = new Dictionary<string, Dictionary<int, Dictionary<int, string>>>();

                        for (int i = 0; i < isimler.Count; i++)
                        {
                            string key = isimler[i];
                            int innerKey = IDler[i];
                            int innerinnerKey = doktorIDler[i];
                            string innerinnerValue = doktorAdlari[i];


                            tempDictionaryPoliklinikler.Add(key, new Dictionary<int, Dictionary<int, string>> { { innerKey, new Dictionary<int, string> { { innerinnerKey, innerinnerValue } } } });

                        }

                        App.initializedPoliklinikler = tempDictionaryPoliklinikler;
                        poliklinik_sec_cBox.Items.AddRange(App.initializedPoliklinikler.Keys.ToArray());

                        poliklinikSeciciResult.Close();

                        // Ýþlemleri initialize et
                        Dictionary<string, Dictionary<int, double>> tempDictionaryIslemler = new Dictionary<string, Dictionary<int, double>>();
                        isimler.Clear();
                        IDler.Clear();

                        SqlDataReader islemSeciciResult = YK_islemSecCmd.ExecuteReader();
                        while (islemSeciciResult.Read())
                        {
                            string isim = islemSeciciResult["Ýsim"].ToString();
                            int id = Convert.ToInt32(islemSeciciResult["Id"]);
                            double ucret = Convert.ToDouble(islemSeciciResult["Ücret"]);

                            // Liste'lere ekle
                            isimler.Add(isim);
                            IDler.Add(id);
                            ucretler.Add(ucret);
                        }

                        for (int i = 0; i < isimler.Count; i++)
                        {
                            string key = isimler[i];
                            int innerKey = IDler[i];
                            double innerValue = ucretler[i];

                            tempDictionaryIslemler.Add(key, new Dictionary<int, double> { { innerKey, innerValue } });

                        }

                        App.initializedIslemler = tempDictionaryIslemler;


                        islem_sec_cBox.Items.AddRange(App.initializedIslemler.Keys.ToArray());

                        islemSeciciResult.Close();


                        con.Close();
                        sira_no_tBox.Text = (App.siraNo).ToString();
                        button1.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Dosya numarasý bulunamadý.");
                        con.Close();
                        sira_no_tBox.Text = "";
                        kayitlar_hasta_adi_tBox.Text = "";
                        kayitlar_hasta_soyadi_tBox.Text = "";
                        sevk_tarihi_dateP.Value = DateTime.Now;
                        dataGridView1.DataSource = null;

                        poliklinik_sec_cBox.Text = "";
                        islem_sec_cBox.Text = "";
                        islem_sec_cBox.Items.Clear();
                        poliklinik_sec_cBox.Items.Clear();
                        doktor_isim_tBox.Text = "";
                        islem_ucret_tBox.Text = "";

                        button1.Enabled = false;
                        button2.Enabled = false;

                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Ýþlem seçme combobox'ý
        private void islem_sec_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            App.seciliIslemID = App.initializedIslemler[islem_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Key;
            islem_ucret_tBox.Text = App.initializedIslemler[islem_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Value.ToString();
            App.seciliIslemID = App.initializedIslemler[islem_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Key;
            if (sira_no_tBox.Text != "" && poliklinik_sec_cBox.Text != "" && islem_ucret_tBox.Text != "")
            {
                button2.Enabled = true;
            }

        }

        // Poliklinik seçme combobox'ý
        private void poliklinik_sec_cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            doktor_isim_tBox.Text = App.initializedPoliklinikler[poliklinik_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Value.FirstOrDefault().Value.ToString();
            App.seciliPoliklinikID = App.initializedPoliklinikler[poliklinik_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Key;
            App.seciliDoktorID = App.initializedPoliklinikler[poliklinik_sec_cBox.SelectedItem.ToString()].FirstOrDefault().Value.FirstOrDefault().Key;
            if (sira_no_tBox.Text != "" && poliklinik_sec_cBox.Text != "" && islem_ucret_tBox.Text != "")
            {
                button2.Enabled = true;
            }
        }

        // Kayit ekleme butonu
        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand hastaKayitCmd = new SqlCommand($"" +
            $"select distinct pol.poliklinik_isim Poliklinik, dok.doktor_adi + ' ' + dok.doktor_soyadi Doktor,\r\n" +
            $"isl.islem_isim Ýþlem, kay.sira_no SýraNo, CAST(kay.kayit_tarihi AS DATE) Tarih,\r\n" +
            $"isl.fiyat Ücret, kay.kayit_id KayýtID\r\n" +
            $"from kayitlar as kay \r\n" +
            $"join hasta as has on kay.hasta_id =  '{App.seciliDosyaNo}'\r\n" +
            $"join poliklinik as pol on kay.poliklinik_id = pol.poliklinik_id\r\n" +
            $"join doktor as dok on kay.doktor_id = dok.doktor_id\r\n" +
            $"join islemler as isl on kay.islem_id = isl.islem_id", con);



            try
            {
                using (SqlCommand insertingCmd = new SqlCommand("INSERT INTO kayitlar (hasta_id, doktor_id, poliklinik_id," +
                    " islem_id, sevk_tarihi, kayit_tarihi, sira_no) " +
                    "VALUES (@HastaID, @DoktorID, @PoliklinikID, @IslemID, @SevkTarihi, @KayitTarihi, @SiraNo)", con))
                {
                    insertingCmd.Parameters.AddWithValue("@HastaID", App.seciliDosyaNo);
                    insertingCmd.Parameters.AddWithValue("@DoktorID", App.seciliDoktorID);
                    insertingCmd.Parameters.AddWithValue("@PoliklinikID", App.seciliPoliklinikID);
                    insertingCmd.Parameters.AddWithValue("@IslemID", App.seciliIslemID);
                    insertingCmd.Parameters.AddWithValue("@SevkTarihi", App.seciliSevkTarihi);
                    insertingCmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
                    insertingCmd.Parameters.AddWithValue("@SiraNo", App.siraNo);

                    con.Open();
                    int rowsAffected = insertingCmd.ExecuteNonQuery();

                    MessageBox.Show("Kayýt baþarýlý þekilde eklendi.");


                }

                dataGridView1.DataSource = null;


                SqlDataAdapter hastaKayitlarAdapter = new SqlDataAdapter(hastaKayitCmd);
                DataTable dataTable = new DataTable();
                hastaKayitlarAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                hastaKayitlarAdapter.Dispose();
                dataTable.Dispose();

                App.siraNo++;
                sira_no_tBox.Text = (App.siraNo).ToString();

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Kayit silme butonu
        private void kayit_sil_button_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGridView1.SelectedRows.Count > 0)
            {
                SqlCommand hastaKayitCmd = new SqlCommand($"" +
                        $"select distinct pol.poliklinik_isim Poliklinik, dok.doktor_adi + ' ' + dok.doktor_soyadi Doktor,\r\n" +
                        $"isl.islem_isim Ýþlem, kay.sira_no SýraNo, CAST(kay.kayit_tarihi AS DATE) Tarih,\r\n" +
                        $"isl.fiyat Ücret, kay.kayit_id KayýtID\r\n" +
                        $"from kayitlar as kay \r\n" +
                        $"join hasta as has on kay.hasta_id =  '{App.seciliDosyaNo}'\r\n" +
                        $"join poliklinik as pol on kay.poliklinik_id = pol.poliklinik_id\r\n" +
                        $"join doktor as dok on kay.doktor_id = dok.doktor_id\r\n" +
                        $"join islemler as isl on kay.islem_id = isl.islem_id", con);
                // Get the selected row
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Assuming the identifier (primary key) is in the first cell
                string identifier = selectedRow.Cells[6].Value.ToString(); // Adjust the index based on your data

                // Remove the row from the DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Delete the corresponding record from the database
                using (SqlCommand cmd = new SqlCommand("DELETE FROM kayitlar WHERE kayit_id = @Identifier", con))
                {
                    cmd.Parameters.AddWithValue("@Identifier", identifier);

                    con.Open();
                    cmd.ExecuteNonQuery();

                    dataGridView1.DataSource = null;


                    SqlDataAdapter hastaKayitlarAdapter = new SqlDataAdapter(hastaKayitCmd);
                    DataTable dataTable = new DataTable();
                    hastaKayitlarAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                    hastaKayitlarAdapter.Dispose();
                    dataTable.Dispose();

                    con.Close();
                }
            }

        }

        // Hastanýn tüm bilgilerini getiren buton
        private void button1_Click(object sender, EventArgs e)
        {
            fullHastaBilgiEkran.BringToFront();
        }

        // Sorgu ekranýna dön butonu
        private void button3_Click(object sender, EventArgs e)
        {
            hastaKayitEkran.BringToFront();
        }

        // Hasta aramasýný veritabanýna gönderen buton
        private void button5_Click(object sender, EventArgs e)
        {

            hasta_arama_ekran.ForeColor = Color.Black;
            string aramaMetni = isimArama_tBox.Text; // Arama terimi

            string convertedSearchTerm = App.SorguDonustur(aramaMetni);


            string sorgu = $"select ad + ' ' + soyad HastaAd, dogum_tarihi DogumTarihi, dosya_no TC\r\n" +
                $"from hasta \r\n" +
                $"where REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(REPLACE(UPPER(AD + soyad), 'Ý', 'I'), 'Þ', 'S'), 'Ð', 'G'), 'Ü', 'U'), 'Ç', 'C'), 'Ö', 'O') \r\n" +
                $"like '{convertedSearchTerm}%'";

            SqlCommand cmd = new SqlCommand(sorgu, con);

            con.Open();
            cmd.ExecuteNonQuery();

            dataGridView1.DataSource = null;


            SqlDataAdapter hastaAramaAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            hastaAramaAdapter.Fill(dataTable);
            hasta_arama_gridV.DataSource = dataTable;
            hastaAramaAdapter.Dispose();
            dataTable.Dispose();

            con.Close();



        }

        // Arama ekranýndan yeni hastayý seçtirme butonu
        private void button4_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = hasta_arama_gridV.SelectedRows[0];


            string identifier = selectedRow.Cells[2].Value.ToString();
            dosya_no_tBox.Text = identifier;

            var keyEventArgs = new KeyEventArgs(Keys.Enter);
            dosya_no_tBox_KeyDown(dosya_no_tBox, keyEventArgs);
        }
    }
}