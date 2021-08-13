using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnDurum_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmDurum frmDurum = new Formlar.Tanimlamalar.FrmDurum();
            frmDurum.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmBirim fr = new Formlar.Tanimlamalar.FrmBirim();
            fr.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmDepartman fr = new Formlar.Tanimlamalar.FrmDepartman();
            fr.Show();
        }

        private void BtnGorevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmGorev fr = new Formlar.Tanimlamalar.FrmGorev();
            fr.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmKasa fr = new Formlar.Tanimlamalar.FrmKasa();
            fr.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmKur fr = new Formlar.Tanimlamalar.FrmKur();
            fr.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanimlamalar.FrmOda fr = new Formlar.Tanimlamalar.FrmOda();
            fr.Show();
        }
    }
}
