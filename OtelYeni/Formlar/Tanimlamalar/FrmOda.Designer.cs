
namespace OtelYeni.Formlar.Tanimlamalar
{
    partial class FrmOda
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
            this.OdaNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Kapasite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.odaSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.gridControl1.Size = new System.Drawing.Size(682, 353);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.OdaNo,
            this.Kat,
            this.Kapasite,
            this.Telefon,
            this.Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // OdaNo
            // 
            this.OdaNo.Caption = "Oda No";
            this.OdaNo.FieldName = "OdaNo";
            this.OdaNo.MinWidth = 25;
            this.OdaNo.Name = "OdaNo";
            this.OdaNo.Visible = true;
            this.OdaNo.VisibleIndex = 0;
            this.OdaNo.Width = 94;
            // 
            // Kat
            // 
            this.Kat.Caption = "Bulunduğu Kat";
            this.Kat.FieldName = "Kat";
            this.Kat.MinWidth = 25;
            this.Kat.Name = "Kat";
            this.Kat.Visible = true;
            this.Kat.VisibleIndex = 1;
            this.Kat.Width = 94;
            // 
            // Kapasite
            // 
            this.Kapasite.Caption = "Kapasite";
            this.Kapasite.FieldName = "Kapasite";
            this.Kapasite.MinWidth = 25;
            this.Kapasite.Name = "Kapasite";
            this.Kapasite.Visible = true;
            this.Kapasite.VisibleIndex = 2;
            this.Kapasite.Width = 94;
            // 
            // Telefon
            // 
            this.Telefon.Caption = "Telefon";
            this.Telefon.FieldName = "Telefon";
            this.Telefon.MinWidth = 25;
            this.Telefon.Name = "Telefon";
            this.Telefon.Visible = true;
            this.Telefon.VisibleIndex = 3;
            this.Telefon.Width = 94;
            // 
            // Durum
            // 
            this.Durum.Caption = "Durumu";
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
            this.DurumRepositoryItemLookUpEdit.NullText = "Durum  Değiştir";
            this.DurumRepositoryItemLookUpEdit.ValueMember = "DurumId";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odaSilToolStripMenuItem,
            this.vazgeçToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(127, 52);
            // 
            // odaSilToolStripMenuItem
            // 
            this.odaSilToolStripMenuItem.Name = "odaSilToolStripMenuItem";
            this.odaSilToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.odaSilToolStripMenuItem.Text = "Oda Sil";
            this.odaSilToolStripMenuItem.Click += new System.EventHandler(this.odaSilToolStripMenuItem_Click);
            // 
            // vazgeçToolStripMenuItem
            // 
            this.vazgeçToolStripMenuItem.Name = "vazgeçToolStripMenuItem";
            this.vazgeçToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.vazgeçToolStripMenuItem.Text = "Vazgeç";
            // 
            // FrmOda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 353);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gridControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmOda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOda";
            this.Load += new System.EventHandler(this.FrmOda_Load);
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
        private DevExpress.XtraGrid.Columns.GridColumn OdaNo;
        private DevExpress.XtraGrid.Columns.GridColumn Kat;
        private DevExpress.XtraGrid.Columns.GridColumn Kapasite;
        private DevExpress.XtraGrid.Columns.GridColumn Telefon;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DurumRepositoryItemLookUpEdit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odaSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vazgeçToolStripMenuItem;
    }
}