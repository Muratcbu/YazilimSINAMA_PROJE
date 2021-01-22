using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YS_scrtaskboard.Entities;
using System.Data.SqlClient;

namespace YS_scrtaskboard.Formlar
{
    public partial class frmTeknikKart : Form
    {
        public frmTeknikKart()
        {
            InitializeComponent();
        }

        YSprojeEntities db = new YSprojeEntities();
        
        VeriDoldur vd = new VeriDoldur();
        private void frmTeknikKart_Load(object sender, EventArgs e)
        {
            cmbProjeAd.ValueMember= "ProjeNo";
            cmbProjeAd.DisplayMember = "ProjeAd";            
            cmbProjeAd.DataSource = vd.cmbProjeAdDoldur();
            //cmbProjeAd.Text = "";
            //txtProjeNo.Text = "";
            //gridControl1.DataSource = null;

            cmbTeknikUzman.ValueMember = "KisiID";
            cmbTeknikUzman.DisplayMember = "KisiAdSoyad";
            cmbTeknikUzman.DataSource = vd.cmbTeknikUzmanDoldur();
            //cmbTeknikUzman.Text = "";
            dtKartTarih.EditValue = DateTime.Now;
            dtGercekBitis.EditValue = DateTime.Now;
            projebitisTarih();
        }

        public void projebitisTarih()
        {
            //Ekranda seçilmiş olan projede görev alan personelin tümünün ortalama iş bitirme sürelerinin ortalaması alınıyor!
            gridView1.Columns["Ort_Bitirme_Gün"].Summary.Add(DevExpress.Data.SummaryItemType.Average, "Ort_Bitirme_Gün");
            string ortalama = gridView1.Columns["Ort_Bitirme_Gün"].SummaryItem.SummaryValue.ToString();
            double ort = Convert.ToDouble(ortalama);
            int ortint = (int)ort;
            int enbuyuk = -1, enkucuk = 20000;
            int i = 0;
            //Ekranda seçilen projede görev alan personelden en kısa ve en uzun ortalama iş bitirme süreleri bulunuyor!
            for (i = 0; i <= gridView1.RowCount - 1; i++)
            {
                if (enbuyuk < Convert.ToInt32(gridView1.GetRowCellValue(i, "Ort_Bitirme_Gün").ToString()))
                {
                    enbuyuk = Convert.ToInt32(gridView1.GetRowCellValue(i, "Ort_Bitirme_Gün").ToString());
                }
                if (enkucuk > Convert.ToInt32(gridView1.GetRowCellValue(i, "Ort_Bitirme_Gün").ToString()))
                {
                    enkucuk = Convert.ToInt32(gridView1.GetRowCellValue(i, "Ort_Bitirme_Gün").ToString());
                }
            }
            //int toplamgorev = gridView1.RowCount;
            int projegorevsuresi = 0;
            //Ortalama görev sürelerinin ortalaması bir personelin ortalama görev süresinden kısa ise 
            if (enbuyuk > ortint)
                projegorevsuresi = enbuyuk + enkucuk;//en uzun görev süresine en kısa görev süresi ekleniyor.
            //Bazı görevler birbirine bağlı olabilir. Biri bitmeden diğeri başlayamayabilir
            //düşüncesiyle böyle bir yöntem kullanıldı!
            else
                //Ortalama görev sürelerinin ortalaması en uzun ortalama çalışma süresine eşit veya küçükse
                //en kısa ortalama iş bitirme süresine ortalama iş bitirme sürelerinin ortalaması eklenerek 
                //projenin toplam bitirme süresi tahmin edilmeye çalışılıyor.
                projegorevsuresi = enkucuk + ortint;
           /* MessageBox.Show("En uzun ortalama görev süresi= " + enbuyuk.ToString() + " gün!" +
                "\nEn kısa ortalama görev süresi= " + enkucuk.ToString() + " gün!" +
                "\nHer bir çalışanın ortalama iş yapma sürelerinin ortalaması= " + ortint.ToString() + " gün!" +
                "\nProjenin tamamının tahmini bitiş süresi: " + projegorevsuresi + " gün!");*/
            DateTime dateTime = new DateTime();
            dateTime = dtKartTarih.DateTime;
            //Hesaplanan proje tahmini bitiş tarihi form üzerinde controle gönderiliyor!
            dtProjeTahmin.DateTime = dateTime.AddDays(projegorevsuresi);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            try
            {
                Baglan.Baglanti().Close();
                SqlCommand komut = new SqlCommand("sp_GorevEkle", Baglan.Baglanti());
                komut.CommandType = CommandType.StoredProcedure;

                int ProjID = Convert.ToInt32(cmbProjeAd.SelectedValue);
                komut.Parameters.Add("@ProjID", SqlDbType.Int);
                komut.Parameters["@ProjID"].Value = ProjID;


                int kisiID = Convert.ToInt32(cmbTeknikUzman.SelectedValue);
                komut.Parameters.Add("@KisiID", SqlDbType.Int);
                komut.Parameters["@KisiID"].Value = kisiID;

                komut.Parameters.Add("@KartTarih", SqlDbType.DateTime);
                komut.Parameters["@KartTarih"].Value = dtKartTarih.DateTime.ToString();


                komut.Parameters.Add("@Tahmin", SqlDbType.DateTime);
                komut.Parameters["@Tahmin"].Value = dtTahmin.DateTime.ToString();

                komut.Parameters.Add("@GercekBitis", SqlDbType.DateTime);
                komut.Parameters["@GercekBitis"].Value = dtGercekBitis.DateTime.ToString();

                komut.Parameters.Add("@GorevAd", SqlDbType.NVarChar, 200);
                komut.Parameters["@GorevAd"].Value = txtGorevAdi.Text;

                komut.Parameters.Add("@GorevAciklama", SqlDbType.NVarChar, 2500);
                komut.Parameters["@GorevAciklama"].Value = txtAciklama.Text;


                komut.Parameters.Add("@GorevNotlar", SqlDbType.NVarChar, 2500);
                komut.Parameters["@GorevNotlar"].Value = txtNotlar.Text;

                komut.Parameters.Add("@KartNo", SqlDbType.Int).Direction = ParameterDirection.Output;


                komut.ExecuteNonQuery();
                txtKartNo.Text = komut.Parameters["@KartNo"].Value.ToString();

                MessageBox.Show("Görev KAYDEDİLDİ!\nTutulan Proje ID= " + ProjID, "BİLGİLENDİRME");
                
                gridControl1.DataSource = vd.teknikGridDoldur(ProjID.ToString());
            }
            catch(Exception hata)
            {
                MessageBox.Show("Bir hata oluştu! Kontrol ediniz!\n" +
                    hata.Message);
            }

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void cmbProjeAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProjeNo.Text = cmbProjeAd.SelectedValue.ToString();

            gridControl1.DataSource = vd.teknikGridDoldur(cmbProjeAd.SelectedValue.ToString());
            projebitisTarih();
        }

        private void labelControl5_Click(object sender, EventArgs e)
        {

        }

        private void cmbTeknikUzman_SelectedIndexChanged(object sender, EventArgs e)
        {
            int kisiID = Convert.ToInt32(cmbTeknikUzman.SelectedValue);

            dtTahmin.DateTime = vd.kucukTahmin(kisiID);
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnYeniKart_Click(object sender, EventArgs e)
        {
            frmTeknikKart_Load(null, null);
        }

        private void dtKartTarih_EditValueChanged(object sender, EventArgs e)
        {
            projebitisTarih();
        }
    }
}
