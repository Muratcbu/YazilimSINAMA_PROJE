using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_scrtaskboard
{
    public partial class frmAna : Form
    {
        public frmAna()
        {
            InitializeComponent();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnTeknikKart_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmTeknikKart frmTeknik = new Formlar.frmTeknikKart();
            frmTeknik.MdiParent = this;
            frmTeknik.Show();
        }

        private void btnDurumizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.frmDurumizle frmdurum = new Formlar.frmDurumizle();
            frmdurum.MdiParent = this;
            frmdurum.Show();
        }
    }
}
