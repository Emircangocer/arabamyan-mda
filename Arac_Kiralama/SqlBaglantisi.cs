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
            // Kendi SQL Server adını (Emircan\SQLEXPRESS gibi) buraya yazmalısın
            SqlConnection baglan = new SqlConnection(@"Data Source=Emircan\SQLEXPRESS; Initial Catalog=AracKiralama; Integrated Security=True; TrustServerCertificate=True");
            baglan.Open();
            return baglan;
        }
    }
}
