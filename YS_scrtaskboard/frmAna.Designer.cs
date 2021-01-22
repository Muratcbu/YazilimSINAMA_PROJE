
namespace YS_scrtaskboard
{
    partial class frmAna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAna));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.skinDropDownButtonItem1 = new DevExpress.XtraBars.SkinDropDownButtonItem();
            this.btnTeknikKart = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeknikKartGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnTeknikKartSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorevEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnGorevSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnDurumizle = new DevExpress.XtraBars.BarButtonItem();
            this.GorevTahtasi = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.skinDropDownButtonItem1,
            this.btnTeknikKart,
            this.btnTeknikKartGuncelle,
            this.btnTeknikKartSil,
            this.btnGorevEkle,
            this.btnGorevSil,
            this.btnDurumizle});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.GorevTahtasi});
            this.ribbonControl1.Size = new System.Drawing.Size(1021, 161);
            this.ribbonControl1.Click += new System.EventHandler(this.ribbonControl1_Click);
            // 
            // skinDropDownButtonItem1
            // 
            this.skinDropDownButtonItem1.Id = 1;
            this.skinDropDownButtonItem1.Name = "skinDropDownButtonItem1";
            // 
            // btnTeknikKart
            // 
            this.btnTeknikKart.Caption = "Teknik Kart Ekle";
            this.btnTeknikKart.Hint = "Teknik Kart Ekleme";
            this.btnTeknikKart.Id = 2;
            this.btnTeknikKart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeknikKart.ImageOptions.SvgImage")));
            this.btnTeknikKart.Name = "btnTeknikKart";
            this.btnTeknikKart.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.btnTeknikKart.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnTeknikKart_ItemClick);
            // 
            // btnTeknikKartGuncelle
            // 
            this.btnTeknikKartGuncelle.Caption = "Teknik Kart Güncelle";
            this.btnTeknikKartGuncelle.Id = 3;
            this.btnTeknikKartGuncelle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeknikKartGuncelle.ImageOptions.SvgImage")));
            this.btnTeknikKartGuncelle.Name = "btnTeknikKartGuncelle";
            // 
            // btnTeknikKartSil
            // 
            this.btnTeknikKartSil.Caption = "Teknik Kart Sil";
            this.btnTeknikKartSil.Id = 4;
            this.btnTeknikKartSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTeknikKartSil.ImageOptions.SvgImage")));
            this.btnTeknikKartSil.Name = "btnTeknikKartSil";
            // 
            // btnGorevEkle
            // 
            this.btnGorevEkle.Caption = "Görev Ekle";
            this.btnGorevEkle.Id = 5;
            this.btnGorevEkle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGorevEkle.ImageOptions.SvgImage")));
            this.btnGorevEkle.Name = "btnGorevEkle";
            // 
            // btnGorevSil
            // 
            this.btnGorevSil.Caption = "Görev Sil";
            this.btnGorevSil.Id = 6;
            this.btnGorevSil.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnGorevSil.ImageOptions.SvgImage")));
            this.btnGorevSil.Name = "btnGorevSil";
            // 
            // btnDurumizle
            // 
            this.btnDurumizle.Caption = "Durum İzle";
            this.btnDurumizle.Id = 7;
            this.btnDurumizle.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDurumizle.ImageOptions.SvgImage")));
            this.btnDurumizle.Name = "btnDurumizle";
            this.btnDurumizle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDurumizle_ItemClick);
            // 
            // GorevTahtasi
            // 
            this.GorevTahtasi.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.GorevTahtasi.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("GorevTahtasi.ImageOptions.SvgImage")));
            this.GorevTahtasi.Name = "GorevTahtasi";
            this.GorevTahtasi.Text = "Görev Tahtası";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.CaptionButtonVisible = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTeknikKart);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnDurumizle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTeknikKartGuncelle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnTeknikKartSil);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGorevEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGorevSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // frmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 832);
            this.Controls.Add(this.ribbonControl1);
            this.IsMdiContainer = true;
            this.Name = "frmAna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yazılım Sınama Projesi - Scrum Task Board";
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage GorevTahtasi;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.SkinDropDownButtonItem skinDropDownButtonItem1;
        private DevExpress.XtraBars.BarButtonItem btnTeknikKart;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.BarButtonItem btnTeknikKartGuncelle;
        private DevExpress.XtraBars.BarButtonItem btnTeknikKartSil;
        private DevExpress.XtraBars.BarButtonItem btnGorevEkle;
        private DevExpress.XtraBars.BarButtonItem btnGorevSil;
        private DevExpress.XtraBars.BarButtonItem btnDurumizle;
    }
}