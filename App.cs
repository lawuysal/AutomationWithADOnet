using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace adonettest
{
    internal class App
    {
        public static int siraNo = 1;
        
        
        public static Dictionary<string, Dictionary<int, Dictionary<int, string>>> initializedPoliklinikler = new Dictionary<string, Dictionary<int, Dictionary<int, string>>>();
        public static Dictionary<string, Dictionary<int, double>> initializedIslemler = new Dictionary<string, Dictionary<int, double>>();
        public static int seciliPoliklinikID;
        public static int seciliDoktorID;
        public static int seciliIslemID;

        public static string seciliDosyaNo;
        public static string seciliHastaAdi;
        public static string seciliHastaSoyadi;
        public static DateTime seciliHastaDogumTarihi;
        public static string seciliHastaCinsiyet;
        public static string seciliHastaAdresi;
        public static DateTime seciliSevkTarihi;
        public static DateTime? seciliHastaTaburcuTarihi;
        public static string seciliHastaTaburcuDurumu;

        public static string SorguDonustur(string input)
        {
            Dictionary<char, char> charMap = new Dictionary<char, char>
            {
                {'ı', 'I'}, {'i', 'I'}, {'ğ', 'G'}, {'ü', 'U'}, {'ş', 'S'}, {'ö', 'O'}, {'ç', 'C'},
                {'İ', 'I'}, {'I', 'I'}, {'Ğ', 'G'}, {'Ü', 'U'}, {'Ş', 'S'}, {'Ö', 'O'}, {'Ç', 'C'}
            };

            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                if (c != ' ')
                {
                    if (charMap.ContainsKey(c))
                    {
                        result.Append(charMap[c]);
                    }
                    else
                    {
                        result.Append(char.ToUpper(c));
                    }
                }
            }

            return result.ToString();
        }




        /// çalışmadı
        public static string kayitSelectorCMD = $"" +
            $"select distinct pol.poliklinik_isim Poliklinik, dok.doktor_adi + ' ' + dok.doktor_soyadi Doktor,\r\n" +
            $"isl.islem_isim İşlem, kay.sira_no SıraNo, CAST(kay.kayit_tarihi AS DATE) Tarih,\r\n" +
            $"isl.fiyat Ücret\r\n" +
            $"from kayitlar as kay \r\n" +
            $"join hasta as has on kay.hasta_id =  '{App.seciliDosyaNo}'\r\n" +
            $"join poliklinik as pol on kay.poliklinik_id = pol.poliklinik_id\r\n" +
            $"join doktor as dok on kay.doktor_id = dok.doktor_id\r\n" +
            $"join islemler as isl on kay.islem_id = isl.islem_id";
    }
}
