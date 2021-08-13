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
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        DbOtelEntities1 db = new DbOtelEntities1();
        private void FrmKasa_Load(object sender, EventArgs e)
        {
            db.TblKasa.Load();
            bindingSource1.DataSource = db.TblKasa.Local;

            DurumRepositoryItemLookUpEdit.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumAd,
                                                            x.DurumId
                                                        }).ToList();

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
                XtraMessageBox.Show("Kayıt Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Kayıt Başarısız", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kasaSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            XtraMessageBox.Show("Kayıt Başarıyla Silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
