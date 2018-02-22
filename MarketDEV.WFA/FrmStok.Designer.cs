namespace MarketDEV.WFA
{
    partial class FrmStok
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
            this.xtraTabControlStok = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageStokDurumu = new DevExpress.XtraTab.XtraTabPage();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.lookUpStokKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControlStokUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewStokUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStok)).BeginInit();
            this.xtraTabControlStok.SuspendLayout();
            this.xtraTabPageStokDurumu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStokKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControlStok
            // 
            this.xtraTabControlStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControlStok.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControlStok.Name = "xtraTabControlStok";
            this.xtraTabControlStok.SelectedTabPage = this.xtraTabPageStokDurumu;
            this.xtraTabControlStok.Size = new System.Drawing.Size(840, 477);
            this.xtraTabControlStok.TabIndex = 0;
            this.xtraTabControlStok.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageStokDurumu});
            // 
            // xtraTabPageStokDurumu
            // 
            this.xtraTabPageStokDurumu.Controls.Add(this.layoutControl1);
            this.xtraTabPageStokDurumu.Name = "xtraTabPageStokDurumu";
            this.xtraTabPageStokDurumu.Size = new System.Drawing.Size(838, 452);
            this.xtraTabPageStokDurumu.Text = "Stok Durumunu İzle";
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.lookUpStokKategori);
            this.layoutControl1.Controls.Add(this.gridControlStokUrunler);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(521, 258, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(838, 449);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // lookUpStokKategori
            // 
            this.lookUpStokKategori.Location = new System.Drawing.Point(94, 22);
            this.lookUpStokKategori.Name = "lookUpStokKategori";
            this.lookUpStokKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpStokKategori.Properties.NullText = "";
            this.lookUpStokKategori.Properties.PopupSizeable = false;
            this.lookUpStokKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpStokKategori.Size = new System.Drawing.Size(263, 20);
            this.lookUpStokKategori.StyleController = this.layoutControl1;
            this.lookUpStokKategori.TabIndex = 8;
            this.lookUpStokKategori.EditValueChanged += new System.EventHandler(this.lookUpEditSTOKKategori_EditValueChanged);
            // 
            // gridControlStokUrunler
            // 
            this.gridControlStokUrunler.Location = new System.Drawing.Point(361, 12);
            this.gridControlStokUrunler.MainView = this.gridViewStokUrunler;
            this.gridControlStokUrunler.Name = "gridControlStokUrunler";
            this.gridControlStokUrunler.Size = new System.Drawing.Size(465, 425);
            this.gridControlStokUrunler.TabIndex = 5;
            this.gridControlStokUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewStokUrunler});
            // 
            // gridViewStokUrunler
            // 
            this.gridViewStokUrunler.GridControl = this.gridControlStokUrunler;
            this.gridViewStokUrunler.Name = "gridViewStokUrunler";
            this.gridViewStokUrunler.OptionsBehavior.Editable = false;
            this.gridViewStokUrunler.OptionsFind.AlwaysVisible = true;
            this.gridViewStokUrunler.OptionsFind.FindNullPrompt = "Aranacak kelime giriniz...";
            this.gridViewStokUrunler.OptionsView.ShowGroupPanel = false;
            this.gridViewStokUrunler.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewStokUrunler_RowClick);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem5,
            this.emptySpaceItem6,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(838, 449);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 44);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(349, 385);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(349, 10);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 34);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(349, 10);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.lookUpStokKategori;
            this.layoutControlItem1.CustomizationFormText = "Ürün Seçiniz:";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 10);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(349, 24);
            this.layoutControlItem1.Text = "Kategori Seçiniz:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(79, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.gridControlStokUrunler;
            this.layoutControlItem2.Location = new System.Drawing.Point(349, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(469, 429);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // FrmStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 477);
            this.Controls.Add(this.xtraTabControlStok);
            this.Name = "FrmStok";
            this.Text = "STOK";
            this.Load += new System.EventHandler(this.FrmStok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControlStok)).EndInit();
            this.xtraTabControlStok.ResumeLayout(false);
            this.xtraTabPageStokDurumu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpStokKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlStokUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewStokUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControlStok;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageStokDurumu;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraGrid.GridControl gridControlStokUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStokUrunler;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.LookUpEdit lookUpStokKategori;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}