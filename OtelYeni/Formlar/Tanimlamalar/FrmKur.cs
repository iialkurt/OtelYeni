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
    public partial class FrmKur : Form
    {
        public FrmKur()
        {
            InitializeComponent();
        }
        DbOtelEntities1 db = new DbOtelEntities1();
        private void FrmKur_Load(object sender, EventArgs e)
        {
            db.TblKur.Load();
            bindingSource1.DataSource = db.TblKur.Local;
            DurumRepositoryItemLookUpEdit.DataSource = (from x in db.TblDurum
                                                        select new
                                                        {
                                                            x.DurumAd,
                                                            x.DurumId
                                                        }).ToList();

        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void kurSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
