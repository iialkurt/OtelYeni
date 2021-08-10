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

      DbOtelEntities db = new DbOtelEntities();
        private void FrmBirim_Load(object sender, EventArgs e)
        {
            db.TblBirim.Load();
            bindingSource1.DataSource = db.TblBirim.Local;


        }
    }
}