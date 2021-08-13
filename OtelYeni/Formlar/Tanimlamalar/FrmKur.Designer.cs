
namespace OtelYeni.Formlar.Tanimlamalar
{
    partial class FrmKur
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.KurAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Sembol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Deger = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Tarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kurSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vazgeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurumRepositoryItemLookUpEdit)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.bindingSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.DurumRepositoryItemLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(580, 353);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KurAd,
            this.Sembol,
            this.Deger,
            this.Tarih,
            this.Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // KurAd
            // 
            this.KurAd.Caption = "Kur Adı";
            this.KurAd.FieldName = "KurAd";
            this.KurAd.MinWidth = 25;
            this.KurAd.Name = "KurAd";
            this.KurAd.Visible = true;
            this.KurAd.VisibleIndex = 0;
            this.KurAd.Width = 94;
            // 
            // Sembol
            // 
            this.Sembol.Caption = "Sembolü";
            this.Sembol.FieldName = "Sembol";
            this.Sembol.MinWidth = 25;
            this.Sembol.Name = "Sembol";
            this.Sembol.Visible = true;
            this.Sembol.VisibleIndex = 1;
            this.Sembol.Width = 94;
            // 
            // Deger
            // 
            this.Deger.Caption = "Değeri";
            this.Deger.FieldName = "Deger";
            this.Deger.MinWidth = 25;
            this.Deger.Name = "Deger";
            this.Deger.Visible = true;
            this.Deger.VisibleIndex = 2;
            this.Deger.Width = 94;
            // 
            // Tarih
            // 
            this.Tarih.Caption = "Tarih";
            this.Tarih.FieldName = "Tarih";
            this.Tarih.MinWidth = 25;
            this.Tarih.Name = "Tarih";
            this.Tarih.Visible = true;
            this.Tarih.VisibleIndex = 3;
            this.Tarih.Width = 94;
            // 
            // Durum
            // 
            this.Durum.Caption = "Durum";
            this.Durum.ColumnEdit = this.DurumRepositoryItemLookUpEdit;
            this.Durum.FieldName = "Durum";
            this.Durum.MinWidth = 25;
            this.Durum.Name = "Durum";
            this.Durum.Visible = true;
            this.Durum.VisibleIndex = 4;
            this.Durum.Width = 94;
            // 
            // DurumRepositoryItemLookUpEdit
            // 
            this.DurumRepositoryItemLookUpEdit.AutoHeight = false;
            this.DurumRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DurumRepositoryItemLookUpEdit.DisplayMember = "DurumAd";
            this.DurumRepositoryItemLookUpEdit.Name = "DurumRepositoryItemLookUpEdit";
            this.DurumRepositoryItemLookUpEdit.NullText = "Durum Değiştir";
            this.DurumRepositoryItemLookUpEdit.ValueMember = "DurumId";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kurSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(126, 52);
            // 
            // kurSilToolStripMenuItem
            // 
            this.kurSilToolStripMenuItem.Name = "kurSilToolStripMenuItem";
            this.kurSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kurSilToolStripMenuItem.Text = "Kur Sil";
            this.kurSilToolStripMenuItem.Click += new System.EventHandler(this.kurSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // FrmKur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 353);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKur";
            this.Load += new System.EventHandler(this.FrmKur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurumRepositoryItemLookUpEdit)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn KurAd;
        private DevExpress.XtraGrid.Columns.GridColumn Sembol;
        private DevExpress.XtraGrid.Columns.GridColumn Deger;
        private DevExpress.XtraGrid.Columns.GridColumn Tarih;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DurumRepositoryItemLookUpEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kurSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
    }
}