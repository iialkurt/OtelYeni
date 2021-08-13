using DevExpress.XtraEditors;
using OtelYeni.Entitiy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeni.Formlar.Tanimlamalar
{
    public partial class FrmBirim : Form
    {
        public FrmBirim()
        {
            InitializeComponent();
        }

        DbOtelEntities1 db = new DbOtelEntities1();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            db.TblBirim.Load();
            bindingSource1.DataSource = db.TblBirim.Local;

            
            DurumRepositoryLookUpEdit.DataSource = (from x in db.TblDurum
                                                    select new
                                                    {
                                                        x.DurumId,
                                                        x.DurumAd
                                                    }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
                XtraMessageBox.Show("Birim Başarılı Şekilde Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Birim Eklenemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void birimSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                bindingSource1.RemoveCurrent();
                db.SaveChanges();
                XtraMessageBox.Show("Birim Başarılı Şekilde Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Birim Silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
