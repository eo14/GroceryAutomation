namespace MarketDEV.WFA
{
    partial class FrmSatis
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
            this.layoutControlSatis = new DevExpress.XtraLayout.LayoutControl();
            this.lblTotalUcret = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControlSatis = new DevExpress.XtraGrid.GridControl();
            this.contextMenuSepetIslemleri = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sepettenÇıkartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünAdetiArttırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünAdetiAzaltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepetModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdet = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnAlisverisiTamamla = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditAdet = new DevExpress.XtraEditors.SpinEdit();
            this.txtSatisBarkod = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSatis)).BeginInit();
            this.layoutControlSatis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatis)).BeginInit();
            this.contextMenuSepetIslemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sepetModelBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAdet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisBarkod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControlSatis
            // 
            this.layoutControlSatis.Controls.Add(this.lblTotalUcret);
            this.layoutControlSatis.Controls.Add(this.labelControl1);
            this.layoutControlSatis.Controls.Add(this.gridControlSatis);
            this.layoutControlSatis.Controls.Add(this.btnAlisverisiTamamla);
            this.layoutControlSatis.Controls.Add(this.spinEditAdet);
            this.layoutControlSatis.Controls.Add(this.txtSatisBarkod);
            this.layoutControlSatis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControlSatis.Location = new System.Drawing.Point(0, 0);
            this.layoutControlSatis.Name = "layoutControlSatis";
            this.layoutControlSatis.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(347, 188, 650, 400);
            this.layoutControlSatis.Root = this.layoutControlGroup1;
            this.layoutControlSatis.Size = new System.Drawing.Size(773, 395);
            this.layoutControlSatis.TabIndex = 0;
            this.layoutControlSatis.Text = "layoutControl1";
            // 
            // lblTotalUcret
            // 
            this.lblTotalUcret.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTotalUcret.Appearance.Options.UseFont = true;
            this.lblTotalUcret.Location = new System.Drawing.Point(148, 290);
            this.lblTotalUcret.Name = "lblTotalUcret";
            this.lblTotalUcret.Size = new System.Drawing.Size(613, 44);
            this.lblTotalUcret.StyleController = this.layoutControlSatis;
            this.lblTotalUcret.TabIndex = 10;
            this.lblTotalUcret.Text = "labelControl2";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Red;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 290);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(132, 44);
            this.labelControl1.StyleController = this.layoutControlSatis;
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "TOPLAM ÜCRET:";
            // 
            // gridControlSatis
            // 
            this.gridControlSatis.ContextMenuStrip = this.contextMenuSepetIslemleri;
            this.gridControlSatis.DataSource = this.sepetModelBindingSource1;
            this.gridControlSatis.Location = new System.Drawing.Point(12, 68);
            this.gridControlSatis.MainView = this.gridView1;
            this.gridControlSatis.Name = "gridControlSatis";
            this.gridControlSatis.Size = new System.Drawing.Size(749, 218);
            this.gridControlSatis.TabIndex = 8;
            this.gridControlSatis.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuSepetIslemleri
            // 
            this.contextMenuSepetIslemleri.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sepettenÇıkartToolStripMenuItem,
            this.ürünAdetiArttırToolStripMenuItem,
            this.ürünAdetiAzaltToolStripMenuItem});
            this.contextMenuSepetIslemleri.Name = "contextMenuSepetIslemleri";
            this.contextMenuSepetIslemleri.Size = new System.Drawing.Size(162, 70);
            // 
            // sepettenÇıkartToolStripMenuItem
            // 
            this.sepettenÇıkartToolStripMenuItem.Name = "sepettenÇıkartToolStripMenuItem";
            this.sepettenÇıkartToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sepettenÇıkartToolStripMenuItem.Text = "Sepetten Çıkart";
            this.sepettenÇıkartToolStripMenuItem.Click += new System.EventHandler(this.sepettenÇıkartToolStripMenuItem_Click);
            // 
            // ürünAdetiArttırToolStripMenuItem
            // 
            this.ürünAdetiArttırToolStripMenuItem.Name = "ürünAdetiArttırToolStripMenuItem";
            this.ürünAdetiArttırToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ürünAdetiArttırToolStripMenuItem.Text = "Ürün Adeti Arttır";
            this.ürünAdetiArttırToolStripMenuItem.Click += new System.EventHandler(this.ürünAdetiArttırToolStripMenuItem_Click);
            // 
            // ürünAdetiAzaltToolStripMenuItem
            // 
            this.ürünAdetiAzaltToolStripMenuItem.Name = "ürünAdetiAzaltToolStripMenuItem";
            this.ürünAdetiAzaltToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ürünAdetiAzaltToolStripMenuItem.Text = "Ürün Adeti Azalt";
            this.ürünAdetiAzaltToolStripMenuItem.Click += new System.EventHandler(this.ürünAdetiAzaltToolStripMenuItem_Click);
            // 
            // sepetModelBindingSource1
            // 
            this.sepetModelBindingSource1.DataSource = typeof(MarketEntity.Models.SepetModel);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBarkod,
            this.colUrunAdi,
            this.colAdet,
            this.colKDV,
            this.colBirimFiyat,
            this.colTotal});
            this.gridView1.GridControl = this.gridControlSatis;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colBarkod
            // 
            this.colBarkod.Caption = "BARKOD";
            this.colBarkod.FieldName = "Barkod";
            this.colBarkod.Name = "colBarkod";
            this.colBarkod.Visible = true;
            this.colBarkod.VisibleIndex = 0;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "ÜRÜN ADI";
            this.colUrunAdi.FieldName = "UrunAdi";
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            // 
            // colAdet
            // 
            this.colAdet.Caption = "ADET";
            this.colAdet.FieldName = "Adet";
            this.colAdet.Name = "colAdet";
            this.colAdet.Visible = true;
            this.colAdet.VisibleIndex = 2;
            // 
            // colKDV
            // 
            this.colKDV.Caption = "KDV %";
            this.colKDV.FieldName = "KDV";
            this.colKDV.Name = "colKDV";
            this.colKDV.Visible = true;
            this.colKDV.VisibleIndex = 3;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Caption = "ÜRÜN BİRİM FİYATI";
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 4;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "TOPLAM";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 5;
            // 
            // btnAlisverisiTamamla
            // 
            this.btnAlisverisiTamamla.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAlisverisiTamamla.Appearance.Options.UseFont = true;
            this.btnAlisverisiTamamla.Location = new System.Drawing.Point(12, 338);
            this.btnAlisverisiTamamla.Name = "btnAlisverisiTamamla";
            this.btnAlisverisiTamamla.Size = new System.Drawing.Size(749, 45);
            this.btnAlisverisiTamamla.StyleController = this.layoutControlSatis;
            this.btnAlisverisiTamamla.TabIndex = 7;
            this.btnAlisverisiTamamla.Text = "ALIŞVERİŞİ TAMAMLA";
            this.btnAlisverisiTamamla.Click += new System.EventHandler(this.btnAlisverisiTamamla_Click);
            // 
            // spinEditAdet
            // 
            this.spinEditAdet.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAdet.Location = new System.Drawing.Point(12, 28);
            this.spinEditAdet.Name = "spinEditAdet";
            this.spinEditAdet.Properties.Appearance.Options.UseTextOptions = true;
            this.spinEditAdet.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.spinEditAdet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditAdet.Properties.IsFloatValue = false;
            this.spinEditAdet.Properties.Mask.EditMask = "N00";
            this.spinEditAdet.Properties.MaxValue = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.spinEditAdet.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditAdet.Size = new System.Drawing.Size(372, 20);
            this.spinEditAdet.StyleController = this.layoutControlSatis;
            this.spinEditAdet.TabIndex = 5;
            // 
            // txtSatisBarkod
            // 
            this.txtSatisBarkod.Location = new System.Drawing.Point(388, 28);
            this.txtSatisBarkod.Name = "txtSatisBarkod";
            this.txtSatisBarkod.Size = new System.Drawing.Size(373, 20);
            this.txtSatisBarkod.StyleController = this.layoutControlSatis;
            this.txtSatisBarkod.TabIndex = 4;
            this.txtSatisBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSatisBarkod_KeyDown_1);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem5});
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(773, 395);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.spinEditAdet;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(151, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(376, 42);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.Text = "ADET:";
            this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnAlisverisiTamamla;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 326);
            this.layoutControlItem4.MinSize = new System.Drawing.Size(78, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(753, 49);
            this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 42);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(753, 14);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.txtSatisBarkod;
            this.layoutControlItem1.Location = new System.Drawing.Point(376, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(54, 41);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(377, 42);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.Text = "BARKOD:";
            this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(45, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelControl1;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 278);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(67, 17);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(136, 48);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.lblTotalUcret;
            this.layoutControlItem6.Location = new System.Drawing.Point(136, 278);
            this.layoutControlItem6.MinSize = new System.Drawing.Size(67, 17);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(617, 48);
            this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.gridControlSatis;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 56);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(753, 222);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // FrmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 395);
            this.Controls.Add(this.layoutControlSatis);
            this.Name = "FrmSatis";
            this.Text = "SATIN ALMA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlSatis)).EndInit();
            this.layoutControlSatis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlSatis)).EndInit();
            this.contextMenuSepetIslemleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sepetModelBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditAdet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSatisBarkod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControlSatis;
        private DevExpress.XtraEditors.SimpleButton btnAlisverisiTamamla;
        private DevExpress.XtraEditors.SpinEdit spinEditAdet;
        private DevExpress.XtraEditors.TextEdit txtSatisBarkod;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraGrid.GridControl gridControlSatis;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraGrid.Columns.GridColumn colBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn colAdet;
        private System.Windows.Forms.BindingSource sepetModelBindingSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colKDV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraEditors.LabelControl lblTotalUcret;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private System.Windows.Forms.ContextMenuStrip contextMenuSepetIslemleri;
        private System.Windows.Forms.ToolStripMenuItem sepettenÇıkartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünAdetiArttırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünAdetiAzaltToolStripMenuItem;
    }
}