namespace MarketDEV.WFA
{
    partial class FrmKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategori));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKategoriKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.btnUrunlereGecis = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.gridControlKategori = new DevExpress.XtraGrid.GridControl();
            this.gridViewKategori = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.spinEditKDV = new DevExpress.XtraEditors.SpinEdit();
            this.txtKategoriAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKategoriTanimi = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKategori)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditKDV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriTanimi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.btnKategoriKaydet,
            this.btnGuncelle,
            this.btnSil,
            this.barStaticItem1,
            this.btnUrunlereGecis});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 8;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.PageHeaderItemLinks.Add(this.btnUrunlereGecis);
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.Size = new System.Drawing.Size(893, 139);
            // 
            // btnKategoriKaydet
            // 
            this.btnKategoriKaydet.Caption = "KAYDET";
            this.btnKategoriKaydet.Id = 1;
            this.btnKategoriKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriKaydet.ImageOptions.Image")));
            this.btnKategoriKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKategoriKaydet.ImageOptions.LargeImage")));
            this.btnKategoriKaydet.Name = "btnKategoriKaydet";
            this.btnKategoriKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKategoriKaydet_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "GÜNCELLE";
            this.btnGuncelle.Id = 2;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.LargeImage")));
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "SİL";
            this.btnSil.Id = 3;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Id = 6;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // btnUrunlereGecis
            // 
            this.btnUrunlereGecis.Caption = "btnUrunlereGecis";
            this.btnUrunlereGecis.Hint = "Ürünler Formuna geçmek için tıklayınız..";
            this.btnUrunlereGecis.Id = 7;
            this.btnUrunlereGecis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunlereGecis.ImageOptions.Image")));
            this.btnUrunlereGecis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunlereGecis.ImageOptions.LargeImage")));
            this.btnUrunlereGecis.Name = "btnUrunlereGecis";
            this.btnUrunlereGecis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunlereGecis_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "KATEGORİ İŞLEMLERİ";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnKategoriKaydet);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnGuncelle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // gridControlKategori
            // 
            this.gridControlKategori.Location = new System.Drawing.Point(0, 248);
            this.gridControlKategori.MainView = this.gridViewKategori;
            this.gridControlKategori.MenuManager = this.ribbonControl1;
            this.gridControlKategori.Name = "gridControlKategori";
            this.gridControlKategori.Size = new System.Drawing.Size(893, 173);
            this.gridControlKategori.TabIndex = 1;
            this.gridControlKategori.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewKategori});
            // 
            // gridViewKategori
            // 
            this.gridViewKategori.GridControl = this.gridControlKategori;
            this.gridViewKategori.Name = "gridViewKategori";
            this.gridViewKategori.OptionsBehavior.Editable = false;
            this.gridViewKategori.OptionsBehavior.ReadOnly = true;
            this.gridViewKategori.OptionsFind.AlwaysVisible = true;
            this.gridViewKategori.OptionsFind.FindNullPrompt = "Aranacak kelimeyi giriniz...";
            this.gridViewKategori.OptionsView.ShowGroupPanel = false;
            this.gridViewKategori.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewKategori_RowClick);
            this.gridViewKategori.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.spinEditKDV);
            this.layoutControl1.Controls.Add(this.txtKategoriAdi);
            this.layoutControl1.Controls.Add(this.txtKategoriTanimi);
            this.layoutControl1.Location = new System.Drawing.Point(0, 139);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(473, 161, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(893, 106);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // spinEditKDV
            // 
            this.spinEditKDV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditKDV.Location = new System.Drawing.Point(12, 68);
            this.spinEditKDV.MenuManager = this.ribbonControl1;
            this.spinEditKDV.Name = "spinEditKDV";
            this.spinEditKDV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditKDV.Properties.Mask.EditMask = "N00";
            this.spinEditKDV.Properties.MaxValue = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.spinEditKDV.Size = new System.Drawing.Size(507, 20);
            this.spinEditKDV.StyleController = this.layoutControl1;
            this.spinEditKDV.TabIndex = 6;
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(12, 28);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(507, 20);
            this.txtKategoriAdi.StyleController = this.layoutControl1;
            this.txtKategoriAdi.TabIndex = 4;
            // 
            // txtKategoriTanimi
            // 
            this.txtKategoriTanimi.Location = new System.Drawing.Point(523, 28);
            this.txtKategoriTanimi.Name = "txtKategoriTanimi";
            this.txtKategoriTanimi.Size = new System.Drawing.Size(358, 20);
            this.txtKategoriTanimi.StyleController = this.layoutControl1;
            this.txtKategoriTanimi.TabIndex = 5;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(893, 106);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtKategoriAdi;
            this.layoutControlItem1.CustomizationFormText = "KategoriAdi";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(511, 40);
            this.layoutControlItem1.Text = "Kategori Adı:";
            this.layoutControlItem1.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize;
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(62, 13);
            this.layoutControlItem1.TextToControlDistance = 3;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.txtKategoriTanimi;
            this.layoutControlItem2.CustomizationFormText = "KategoriTanimi";
            this.layoutControlItem2.Location = new System.Drawing.Point(511, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(81, 40);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(362, 86);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "Kategori Tanımı:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.spinEditKDV;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 40);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(511, 46);
            this.layoutControlItem3.Text = "KDV Oranı(%):";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // FrmKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 421);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.gridControlKategori);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "FrmKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KATEGORİ İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmKategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewKategori)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spinEditKDV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKategoriTanimi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnKategoriKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.XtraGrid.GridControl gridControlKategori;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewKategori;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit txtKategoriAdi;
        private DevExpress.XtraEditors.TextEdit txtKategoriTanimi;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraBars.BarButtonItem btnUrunlereGecis;
        private DevExpress.XtraEditors.SpinEdit spinEditKDV;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}

