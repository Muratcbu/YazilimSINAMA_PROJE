using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
//using System.Data.SqlClient;
//using System.Windows.Forms;
using YS_scrtaskboard;

namespace UnitTestTaskBoard
{
    [TestClass]
    public class YSscrtaskboardTEST
    {
        [TestMethod]
        //VeriDoldur sınıfına erişim test ediliyor! Sınıf public mi?
        public void VeriDoldurSinifinaErisim()
        {
            VeriDoldur veridoldur = new YS_scrtaskboard.VeriDoldur();
        }

        VeriDoldur doldur = new VeriDoldur();
        [TestMethod]
        //Kayıtlı bir kişi ID girildiğinde iş yapma süresini veriyor mu?
        public void KisiIDdenTarihBul()//
        {//6 no'lu kişinin ortalama iş bitirme süresi 10 gün.
            DateTime sonuc = doldur.kucukTahmin(6);
            //Fonksiyon işe başlama tarihi olarak bugünü kabul edip 6 no'lu kişinin
            //işi ne zaman bitirebileceğini hesaplıyor
            Assert.AreEqual(DateTime.Now.AddDays(10).Date, sonuc);
        }

        [TestMethod]
        //Kayıtlı OLMAYAN bir kişi ID girildiğinde fonksiyon RunTime'daki tarih saat
        //bilgisini veriyor
        public void OlmayanKisiIDdenTarihBul()//
        {//99999 no'lu kişinin ortalama iş bitirme süresi 10 gün.
            DateTime sonuc = doldur.kucukTahmin(99999);
            //Fonksiyon işe başlama tarihi olarak bugünü kabul edip 6 no'lu kişinin
            //işi ne zaman bitirebileceğini hesaplıyor
            Assert.AreEqual(DateTime.Now, sonuc);
        }





    }
}
