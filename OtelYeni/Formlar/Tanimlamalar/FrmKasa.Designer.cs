
namespace OtelYeni.Formlar.Tanimlamalar
{
    partial class FrmKasa
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
            this.KasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Bakiye = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Giren = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cikan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kasaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.KasaAdi,
            this.Bakiye,
            this.Giren,
            this.Cikan,
            this.Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // KasaAdi
            // 
            this.KasaAdi.Caption = "Kasa Adı";
            this.KasaAdi.FieldName = "KasaAdi";
            this.KasaAdi.MinWidth = 25;
            this.KasaAdi.Name = "KasaAdi";
            this.KasaAdi.Visible = true;
            this.KasaAdi.VisibleIndex = 0;
            this.KasaAdi.Width = 94;
            // 
            // Bakiye
            // 
            this.Bakiye.Caption = "Bakiye";
            this.Bakiye.FieldName = "Bakiye";
            this.Bakiye.MinWidth = 25;
            this.Bakiye.Name = "Bakiye";
            this.Bakiye.Visible = true;
            this.Bakiye.VisibleIndex = 1;
            this.Bakiye.Width = 94;
            // 
            // Giren
            // 
            this.Giren.Caption = "Giren";
            this.Giren.FieldName = "Giren";
            this.Giren.MinWidth = 25;
            this.Giren.Name = "Giren";
            this.Giren.Visible = true;
            this.Giren.VisibleIndex = 2;
            this.Giren.Width = 94;
            // 
            // Cikan
            // 
            this.Cikan.Caption = "Çıkan";
            this.Cikan.FieldName = "Cikan";
            this.Cikan.MinWidth = 25;
            this.Cikan.Name = "Cikan";
            this.Cikan.Visible = true;
            this.Cikan.VisibleIndex = 3;
            this.Cikan.Width = 94;
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
            this.DurumRepositoryItemLookUpEdit.NullText = "Durumu Değiştir";
            this.DurumRepositoryItemLookUpEdit.ValueMember = "DurumId";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kasaSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 52);
            // 
            // kasaSilToolStripMenuItem
            // 
            this.kasaSilToolStripMenuItem.Name = "kasaSilToolStripMenuItem";
            this.kasaSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.kasaSilToolStripMenuItem.Text = "Kasa Sil";
            this.kasaSilToolStripMenuItem.Click += new System.EventHandler(this.kasaSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // FrmKasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kasa Tanımları";
            this.Load += new System.EventHandler(this.FrmKasa_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn KasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn Bakiye;
        private DevExpress.XtraGrid.Columns.GridColumn Giren;
        private DevExpress.XtraGrid.Columns.GridColumn Cikan;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DurumRepositoryItemLookUpEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kasaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
    }
}