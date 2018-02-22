namespace MarketDEV.WFA
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.LookUpKategori = new DevExpress.XtraEditors.LookUpEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lblBarkod = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunAdi = new DevExpress.XtraEditors.LabelControl();
            this.lblUrunResmi = new DevExpress.XtraEditors.LabelControl();
            this.lblAlisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.lblSatisFiyati = new DevExpress.XtraEditors.LabelControl();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.urunPictureEdit = new DevExpress.XtraEditors.PictureEdit();
            this.spinEditAlisFiyati = new DevExpress.XtraEditors.SpinEdit();
            this.spinEditSatisFiyati = new DevExpress.XtraEditors.SpinEdit();
            this.txtBarkod = new DevExpress.XtraEditors.TextEdit();
            this.ribbonControlUrun = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnKaydet = new DevExpress.XtraBars.BarButtonItem();
            this.btnGuncelle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKategoriyeGecis = new DevExpress.XtraBars.BarButtonItem();
            this.btnSil = new DevExpress.XtraBars.BarButtonItem();
            this.btnYeniUrun = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroupIslemler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.barCodeControl1 = new DevExpress.XtraEditors.BarCodeControl();
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridViewUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraOpenFilePencere = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpKategori.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunPictureEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAlisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSatisFiyati.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlUrun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.LookUpKategori);
            this.layoutControl1.Location = new System.Drawing.Point(3, 142);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(462, 254, 650, 400);
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(929, 61);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // LookUpKategori
            // 
            this.LookUpKategori.Location = new System.Drawing.Point(59, 12);
            this.LookUpKategori.Name = "LookUpKategori";
            this.LookUpKategori.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LookUpKategori.Properties.NullText = "";
            this.LookUpKategori.Properties.PopupSizeable = false;
            this.LookUpKategori.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.LookUpKategori.Size = new System.Drawing.Size(858, 20);
            this.LookUpKategori.StyleController = this.layoutControl1;
            this.LookUpKategori.TabIndex = 0;
            this.LookUpKategori.EditValueChanged += new System.EventHandler(this.LookUpKategori_EditValueChanged);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(929, 61);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.LookUpKategori;
            this.layoutControlItem1.CustomizationFormText = "lblKategori";
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(909, 41);
            this.layoutControlItem1.Text = "Kategori:";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(44, 13);
            // 
            // lblBarkod
            // 
            this.lblBarkod.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBarkod.Appearance.Options.UseFont = true;
            this.lblBarkod.Location = new System.Drawing.Point(15, 243);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(45, 13);
            this.lblBarkod.TabIndex = 1;
            this.lblBarkod.Text = "BARKOD:";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.Location = new System.Drawing.Point(15, 267);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(45, 13);
            this.lblUrunAdi.TabIndex = 2;
            this.lblUrunAdi.Text = "Ürün Adi:";
            // 
            // lblUrunResmi
            // 
            this.lblUrunResmi.Location = new System.Drawing.Point(15, 293);
            this.lblUrunResmi.Name = "lblUrunResmi";
            this.lblUrunResmi.Size = new System.Drawing.Size(58, 13);
            this.lblUrunResmi.TabIndex = 3;
            this.lblUrunResmi.Text = "Ürün Resmi:";
            // 
            // lblAlisFiyati
            // 
            this.lblAlisFiyati.Location = new System.Drawing.Point(15, 422);
            this.lblAlisFiyati.Name = "lblAlisFiyati";
            this.lblAlisFiyati.Size = new System.Drawing.Size(49, 13);
            this.lblAlisFiyati.TabIndex = 4;
            this.lblAlisFiyati.Text = "Alış Fiyatı:";
            // 
            // lblSatisFiyati
            // 
            this.lblSatisFiyati.Location = new System.Drawing.Point(15, 447);
            this.lblSatisFiyati.Name = "lblSatisFiyati";
            this.lblSatisFiyati.Size = new System.Drawing.Size(56, 13);
            this.lblSatisFiyati.TabIndex = 5;
            this.lblSatisFiyati.Text = "Satış Fiyatı:";
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(84, 267);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(227, 20);
            this.txtUrunAdi.TabIndex = 6;
            // 
            // urunPictureEdit
            // 
            this.urunPictureEdit.Cursor = System.Windows.Forms.Cursors.Default;
            this.urunPictureEdit.Location = new System.Drawing.Point(84, 293);
            this.urunPictureEdit.Name = "urunPictureEdit";
            this.urunPictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray;
            this.urunPictureEdit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Always;
            this.urunPictureEdit.Size = new System.Drawing.Size(227, 115);
            this.urunPictureEdit.TabIndex = 7;
            this.urunPictureEdit.EditValueChanged += new System.EventHandler(this.urunPictureEdit_EditValueChanged);
            // 
            // spinEditAlisFiyati
            // 
            this.spinEditAlisFiyati.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditAlisFiyati.Location = new System.Drawing.Point(84, 414);
            this.spinEditAlisFiyati.Name = "spinEditAlisFiyati";
            this.spinEditAlisFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAlisFiyati.Size = new System.Drawing.Size(227, 20);
            this.spinEditAlisFiyati.TabIndex = 8;
            // 
            // spinEditSatisFiyati
            // 
            this.spinEditSatisFiyati.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spinEditSatisFiyati.Location = new System.Drawing.Point(84, 440);
            this.spinEditSatisFiyati.Name = "spinEditSatisFiyati";
            this.spinEditSatisFiyati.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditSatisFiyati.Size = new System.Drawing.Size(227, 20);
            this.spinEditSatisFiyati.TabIndex = 9;
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(84, 240);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(227, 20);
            this.txtBarkod.TabIndex = 10;
            // 
            // ribbonControlUrun
            // 
            this.ribbonControlUrun.ExpandCollapseItem.Id = 0;
            this.ribbonControlUrun.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControlUrun.ExpandCollapseItem,
            this.btnKaydet,
            this.btnGuncelle,
            this.btnKategoriyeGecis,
            this.btnSil,
            this.btnYeniUrun});
            this.ribbonControlUrun.Location = new System.Drawing.Point(0, 0);
            this.ribbonControlUrun.MaxItemId = 8;
            this.ribbonControlUrun.Name = "ribbonControlUrun";
            this.ribbonControlUrun.PageHeaderItemLinks.Add(this.btnKategoriyeGecis);
            this.ribbonControlUrun.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControlUrun.Size = new System.Drawing.Size(929, 139);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Caption = "KAYDET";
            this.btnKaydet.Hint = "Ürün kaydet";
            this.btnKaydet.Id = 1;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.LargeImage")));
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKaydet_ItemClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Caption = "ÜRÜN GÜNCELLE";
            this.btnGuncelle.Id = 4;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.LargeImage")));
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGuncelle_ItemClick);
            // 
            // btnKategoriyeGecis
            // 
            this.btnKategoriyeGecis.Caption = "Kategori";
            this.btnKategoriyeGecis.Id = 5;
            this.btnKategoriyeGecis.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriyeGecis.ImageOptions.Image")));
            this.btnKategoriyeGecis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKategoriyeGecis.ImageOptions.LargeImage")));
            this.btnKategoriyeGecis.Name = "btnKategoriyeGecis";
            this.btnKategoriyeGecis.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKategoriyeGecis_ItemClick);
            // 
            // btnSil
            // 
            this.btnSil.Caption = "SİL";
            this.btnSil.Id = 6;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.LargeImage")));
            this.btnSil.Name = "btnSil";
            this.btnSil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSil_ItemClick);
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.Caption = "YENİ ÜRÜN EKLE";
            this.btnYeniUrun.Id = 7;
            this.btnYeniUrun.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniUrun.ImageOptions.Image")));
            this.btnYeniUrun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnYeniUrun.ImageOptions.LargeImage")));
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnYeniUrun_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroupIslemler,
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // ribbonPageGroupIslemler
            // 
            this.ribbonPageGroupIslemler.ItemLinks.Add(this.btnYeniUrun);
            this.ribbonPageGroupIslemler.ItemLinks.Add(this.btnGuncelle);
            this.ribbonPageGroupIslemler.ItemLinks.Add(this.btnSil);
            this.ribbonPageGroupIslemler.Name = "ribbonPageGroupIslemler";
            this.ribbonPageGroupIslemler.Text = "İşlemler Grubu";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnKaydet);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // barCodeControl1
            // 
            this.barCodeControl1.Location = new System.Drawing.Point(84, 209);
            this.barCodeControl1.Name = "barCodeControl1";
            this.barCodeControl1.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.barCodeControl1.Size = new System.Drawing.Size(227, 23);
            this.barCodeControl1.Symbology = code128Generator1;
            this.barCodeControl1.TabIndex = 12;
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Location = new System.Drawing.Point(331, 208);
            this.gridControlUrunler.MainView = this.gridViewUrunler;
            this.gridControlUrunler.MenuManager = this.ribbonControlUrun;
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.Size = new System.Drawing.Size(589, 252);
            this.gridControlUrunler.TabIndex = 14;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUrunler});
            // 
            // gridViewUrunler
            // 
            this.gridViewUrunler.GridControl = this.gridControlUrunler;
            this.gridViewUrunler.Name = "gridViewUrunler";
            this.gridViewUrunler.OptionsBehavior.Editable = false;
            this.gridViewUrunler.OptionsFind.AlwaysVisible = true;
            this.gridViewUrunler.OptionsFind.FindNullPrompt = "Aranacak kelimeyi giriniz...";
            this.gridViewUrunler.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewUrunler_RowClick);
            // 
            // xtraOpenFilePencere
            // 
            this.xtraOpenFilePencere.FileName = "xtraOpenFileDialog1";
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 466);
            this.Controls.Add(this.gridControlUrunler);
            this.Controls.Add(this.barCodeControl1);
            this.Controls.Add(this.ribbonControlUrun);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.spinEditSatisFiyati);
            this.Controls.Add(this.spinEditAlisFiyati);
            this.Controls.Add(this.urunPictureEdit);
            this.Controls.Add(this.txtUrunAdi);
            this.Controls.Add(this.lblSatisFiyati);
            this.Controls.Add(this.lblAlisFiyati);
            this.Controls.Add(this.lblUrunResmi);
            this.Controls.Add(this.lblUrunAdi);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpKategori.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunPictureEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAlisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditSatisFiyati.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControlUrun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.LookUpEdit LookUpKategori;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.LabelControl lblBarkod;
        private DevExpress.XtraEditors.LabelControl lblUrunAdi;
        private DevExpress.XtraEditors.LabelControl lblUrunResmi;
        private DevExpress.XtraEditors.LabelControl lblAlisFiyati;
        private DevExpress.XtraEditors.LabelControl lblSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private DevExpress.XtraEditors.PictureEdit urunPictureEdit;
        private DevExpress.XtraEditors.SpinEdit spinEditAlisFiyati;
        private DevExpress.XtraEditors.SpinEdit spinEditSatisFiyati;
        private DevExpress.XtraEditors.TextEdit txtBarkod;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControlUrun;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroupIslemler;
        private DevExpress.XtraBars.BarButtonItem btnKaydet;
        private DevExpress.XtraBars.BarButtonItem btnGuncelle;
        private DevExpress.XtraBars.BarButtonItem btnKategoriyeGecis;
        private DevExpress.XtraBars.BarButtonItem btnSil;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.BarCodeControl barCodeControl1;
        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUrunler;
        private DevExpress.XtraEditors.XtraOpenFileDialog xtraOpenFilePencere;
        private DevExpress.XtraBars.BarButtonItem btnYeniUrun;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    }
}