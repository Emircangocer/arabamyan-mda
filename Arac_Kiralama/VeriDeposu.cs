using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arac_Kiralama
{
    internal class VeriDeposu
    {
        public static DateTime AlisTarihi;
        public static DateTime IadeTarihi;
        public static int SecilenAracID;
        public static double ToplamTutar;
        public static string SecilenAracAdi;
       
        public static string SecilenVites;
        public static string SecilenYakit;
        public static string SecilenResimYolu;
        public static string GunlukFiyat;

        public static double GuvenceTutari = 0;
        public static double IndirimTutari = 0;
        public static int MusteriID;
        public static double MusteriBakiye;
        public static string GirisYapanMusteriAdSoyad;
        public static bool GirisYapildiMi;
    }
}
