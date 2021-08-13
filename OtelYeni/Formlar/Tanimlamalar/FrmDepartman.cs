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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        DbOtelEntities1 db = new DbOtelEntities1();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db.TblDepartman.Load();
            bindingSource1.DataSource = db.TblDepartman.Local;
            DurumRepositoryLookUpEdit.DataSource = (from x in db.TblDurum
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

        private void SilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
