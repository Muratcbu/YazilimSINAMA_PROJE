using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace YS_scrtaskboard
{
    public class VeriDoldur
    {
        SqlConnection baglan=Baglan.Baglanti();

        public DataTable cmbProjeAdDoldur()
        {
            DataTable ret = new DataTable();
            using (baglan) 
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT ProjeNo, ProjeAd FROM tblProjeler", Baglan.Baglanti()))
                {
                    dataAdapter.Fill(ret);
                }
            }
            return ret;
        }

        public DataTable cmbTeknikUzmanDoldur()
        {
            DataTable ret = new DataTable();
            using (baglan) 
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT KisiID, KisiAdSoyad FROM tblKisiler", Baglan.Baglanti()))
                {
                    dataAdapter.Fill(ret);
                }
            }
            return ret;
        }

        internal object cmbKartNoDoldur()
        {
            DataTable ret = new DataTable();
            using (baglan)
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT KartNo FROM tblTeknikKart", Baglan.Baglanti()))
                {
                    dataAdapter.Fill(ret);
                }
            }
            return ret;
        }

        public DataTable teknikGridDoldur(string projno)
        {
            projno = projno.Trim();
            int sprojno = Convert.ToInt32(projno);
            DataTable ret = new DataTable();
            using (baglan)
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT KisiAdSoyad, GorevDurumTarih, DurumAd,GorevAd, " +
                    "GorevDurumAciklama, Ort_Bitirme_Gün FROM dbo.f_TeknikKartDetay(" + sprojno + ")", Baglan.Baglanti()))
                {
                    da.Fill(ret);
                }
            }
            return ret;
        }

        public DataTable tododoldur()
        {
            DataTable ret = new DataTable();
            using (baglan)
            {
                using (SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM vw_Todo", Baglan.Baglanti()))
                {
                    da.Fill(ret);
                }
            }
            return ret;
        }


        public DateTime kucukTahmin(int kisiNo)
        {
            try
            {
                //set the connection string
                string connString = @"Server =.\SQLEXPRESS; Database = YSproje; Trusted_Connection = True;";
                //sql bağlantı nesnesi
                using (SqlConnection conn = new SqlConnection(connString))
                {

                    //sorgu metni
                    string query = @"SELECT [dbo].[f_TarihEkle](@KisiID) AS YeniTarih";

                    //sql komut nesnesi bildirimi
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //parametre değeri ayarlanıyor
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@KisiID";
                    param1.SqlDbType = SqlDbType.Int;
                    param1.Value = kisiNo;

                    //parametre sql komutuna geçiliyor
                    cmd.Parameters.Add(param1);

                    //bağlantı açılıyor
                    conn.Open();

                    //sql komutu çalıştırılıyor
                    DateTime  sonuc = (DateTime)cmd.ExecuteScalar();

                    //bağlantı kapatılıyor
                    conn.Close();
                    return sonuc;
                }
            }
            catch (Exception ex)
            {
                //hata mesjı gösteriliyor
                MessageBox.Show("Bir hata oluştu\n" + ex.Message, "HATA..!");
                return DateTime.Now;
            }

        }
    }

}
    

