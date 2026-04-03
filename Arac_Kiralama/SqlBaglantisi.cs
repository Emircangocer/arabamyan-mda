using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace Arac_Kiralama
{
    public class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            
            SqlConnection baglan = new SqlConnection(@"Data Source=Emircan\SQLEXPRESS; Initial Catalog=AracKiralama; Integrated Security=True; TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
    public static class KullaniciBilgisi
    {
        public static string AdSoyad = "";
        public static bool GirisYapildiMi = false;
    }
}
