
namespace OtelYeni.Formlar.Tanimlamalar
{
    partial class FrmGorev
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
            this.GorevAd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Departman = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DepartmanRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.Durum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DurumRepositoryItemLookUpEdit = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanRepositoryItemLookUpEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurumRepositoryItemLookUpEdit)).BeginInit();
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
            this.DepartmanRepositoryItemLookUpEdit,
            this.DurumRepositoryItemLookUpEdit});
            this.gridControl1.Size = new System.Drawing.Size(482, 353);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.GorevAd,
            this.Departman,
            this.Durum});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
            this.gridView1.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridView1_CellValueChanged);
            // 
            // GorevAd
            // 
            this.GorevAd.Caption = "Görev Adı";
            this.GorevAd.FieldName = "GorevAd";
            this.GorevAd.MinWidth = 25;
            this.GorevAd.Name = "GorevAd";
            this.GorevAd.Visible = true;
            this.GorevAd.VisibleIndex = 0;
            this.GorevAd.Width = 94;
            // 
            // Departman
            // 
            this.Departman.Caption = "Departman";
            this.Departman.ColumnEdit = this.DepartmanRepositoryItemLookUpEdit;
            this.Departman.FieldName = "Departman";
            this.Departman.MinWidth = 25;
            this.Departman.Name = "Departman";
            this.Departman.Visible = true;
            this.Departman.VisibleIndex = 1;
            this.Departman.Width = 94;
            // 
            // DepartmanRepositoryItemLookUpEdit
            // 
            this.DepartmanRepositoryItemLookUpEdit.AutoHeight = false;
            this.DepartmanRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DepartmanRepositoryItemLookUpEdit.DisplayMember = "DepartmanAd";
            this.DepartmanRepositoryItemLookUpEdit.Name = "DepartmanRepositoryItemLookUpEdit";
            this.DepartmanRepositoryItemLookUpEdit.NullText = "Departman Ekle";
            this.DepartmanRepositoryItemLookUpEdit.ValueMember = "DepartmanId";
            // 
            // Durum
            // 
            this.Durum.Caption = "Durum";
            this.Durum.ColumnEdit = this.DurumRepositoryItemLookUpEdit;
            this.Durum.FieldName = "Durum";
            this.Durum.MinWidth = 25;
            this.Durum.Name = "Durum";
            this.Durum.Visible = true;
            this.Durum.VisibleIndex = 2;
            this.Durum.Width = 94;
            // 
            // DurumRepositoryItemLookUpEdit
            // 
            this.DurumRepositoryItemLookUpEdit.AutoHeight = false;
            this.DurumRepositoryItemLookUpEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DurumRepositoryItemLookUpEdit.DisplayMember = "DurumAd";
            this.DurumRepositoryItemLookUpEdit.Name = "DurumRepositoryItemLookUpEdit";
            this.DurumRepositoryItemLookUpEdit.NullText = "Durum Ekle";
            this.DurumRepositoryItemLookUpEdit.ValueMember = "DurumId";
            // 
            // FrmGorev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.gridControl1);
            this.MinimizeBox = false;
            this.Name = "FrmGorev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Görev Tanımları";
            this.Load += new System.EventHandler(this.FrmGorev_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DepartmanRepositoryItemLookUpEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurumRepositoryItemLookUpEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn GorevAd;
        private DevExpress.XtraGrid.Columns.GridColumn Departman;
        private DevExpress.XtraGrid.Columns.GridColumn Durum;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DepartmanRepositoryItemLookUpEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit DurumRepositoryItemLookUpEdit;
    }
}