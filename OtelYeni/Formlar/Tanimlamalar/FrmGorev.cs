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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        DbOtelEntities1 db = new DbOtelEntities1();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorev.Load();
            bindingSource1.DataSource = db.TblGorev.Local;
            DepartmanRepositoryItemLookUpEdit.DataSource = (from x in db.TblDepartman
                                                            select new
                                                            {
                                                                x.DepartmanAd,
                                                                x.DepartmanId
                                                               
                                                            }).ToList();
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
    }
}
