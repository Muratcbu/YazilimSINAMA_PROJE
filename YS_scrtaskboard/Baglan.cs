using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YS_scrtaskboard
{
    public class Baglan
    {
        public static SqlConnection Baglanti()
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source = .\SQLEXPRESS; Initial Catalog = YSproje; Integrated Security = True");
            try
            {
                baglanti.Open();
                //MessageBox.Show("Veri tabanına bağlantı başarılı!");
            }
            catch (Exception)
            {
                MessageBox.Show("Veri tabanına bağlantıda bir sorun var!");
                throw;
            }
            return baglanti;

        }
    }
}
