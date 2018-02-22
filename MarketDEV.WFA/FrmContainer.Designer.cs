namespace MarketDEV.WFA
{
    partial class FrmContainer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContainer));
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroupKategori = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarKategorileriYonet = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupUrun = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemUrunleriYonet = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemStoklariYonet = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTedarikcileriYonet = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupSiparis = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemSiparisleriYonet = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupSatis = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemSatisYonetimi = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroupRaporlama = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItemRaporla = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroupKategori;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroupKategori,
            this.navBarGroupUrun,
            this.navBarGroupSiparis,
            this.navBarGroupSatis,
            this.navBarGroupRaporlama});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarKategorileriYonet,
            this.navBarItemUrunleriYonet,
            this.navBarItemSiparisleriYonet,
            this.navBarItemStoklariYonet,
            this.navBarItemSatisYonetimi,
            this.navBarItemTedarikcileriYonet,
            this.navBarItemRaporla});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 212;
            this.navBarControl1.Size = new System.Drawing.Size(212, 489);
            this.navBarControl1.TabIndex = 1;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroupKategori
            // 
            this.navBarGroupKategori.Caption = "KATEGORİLER";
            this.navBarGroupKategori.Expanded = true;
            this.navBarGroupKategori.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarKategorileriYonet)});
            this.navBarGroupKategori.Name = "navBarGroupKategori";
            // 
            // navBarKategorileriYonet
            // 
            this.navBarKategorileriYonet.Caption = "Kategorileri Yönet";
            this.navBarKategorileriYonet.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarKategorileriYonet.ImageOptions.SmallImage")));
            this.navBarKategorileriYonet.Name = "navBarKategorileriYonet";
            this.navBarKategorileriYonet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarKategorileriYonet_LinkClicked);
            // 
            // navBarGroupUrun
            // 
            this.navBarGroupUrun.Caption = "ÜRÜNLER";
            this.navBarGroupUrun.Expanded = true;
            this.navBarGroupUrun.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupUrun.ImageOptions.LargeImage")));
            this.navBarGroupUrun.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemUrunleriYonet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemStoklariYonet),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTedarikcileriYonet)});
            this.navBarGroupUrun.Name = "navBarGroupUrun";
            // 
            // navBarItemUrunleriYonet
            // 
            this.navBarItemUrunleriYonet.Caption = "Ürünleri Yönet";
            this.navBarItemUrunleriYonet.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemUrunleriYonet.ImageOptions.SmallImage")));
            this.navBarItemUrunleriYonet.Name = "navBarItemUrunleriYonet";
            this.navBarItemUrunleriYonet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemUrunleriYonet_LinkClicked);
            // 
            // navBarItemStoklariYonet
            // 
            this.navBarItemStoklariYonet.Caption = "Stok Yönetimi";
            this.navBarItemStoklariYonet.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemStoklariYonet.ImageOptions.SmallImage")));
            this.navBarItemStoklariYonet.Name = "navBarItemStoklariYonet";
            this.navBarItemStoklariYonet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemStoklariYonet_LinkClicked);
            // 
            // navBarItemTedarikcileriYonet
            // 
            this.navBarItemTedarikcileriYonet.Caption = "Tedarikçileri Yönet";
            this.navBarItemTedarikcileriYonet.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTedarikcileriYonet.ImageOptions.LargeImage")));
            this.navBarItemTedarikcileriYonet.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemTedarikcileriYonet.ImageOptions.SmallImage")));
            this.navBarItemTedarikcileriYonet.Name = "navBarItemTedarikcileriYonet";
            this.navBarItemTedarikcileriYonet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTedarikcileriYonet_LinkClicked);
            // 
            // navBarGroupSiparis
            // 
            this.navBarGroupSiparis.Caption = "SİPARİŞLER";
            this.navBarGroupSiparis.Expanded = true;
            this.navBarGroupSiparis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSiparis.ImageOptions.LargeImage")));
            this.navBarGroupSiparis.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSiparisleriYonet)});
            this.navBarGroupSiparis.Name = "navBarGroupSiparis";
            // 
            // navBarItemSiparisleriYonet
            // 
            this.navBarItemSiparisleriYonet.Caption = "Siparişleri Yönet";
            this.navBarItemSiparisleriYonet.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemSiparisleriYonet.ImageOptions.SmallImage")));
            this.navBarItemSiparisleriYonet.Name = "navBarItemSiparisleriYonet";
            this.navBarItemSiparisleriYonet.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSiparisleriYonet_LinkClicked);
            // 
            // navBarGroupSatis
            // 
            this.navBarGroupSatis.Caption = "ÜRÜN SATIŞLARI";
            this.navBarGroupSatis.Expanded = true;
            this.navBarGroupSatis.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupSatis.ImageOptions.LargeImage")));
            this.navBarGroupSatis.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemSatisYonetimi)});
            this.navBarGroupSatis.Name = "navBarGroupSatis";
            // 
            // navBarItemSatisYonetimi
            // 
            this.navBarItemSatisYonetimi.Caption = "Satışları Yönet";
            this.navBarItemSatisYonetimi.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemSatisYonetimi.ImageOptions.SmallImage")));
            this.navBarItemSatisYonetimi.Name = "navBarItemSatisYonetimi";
            this.navBarItemSatisYonetimi.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemSatisYonetimi_LinkClicked);
            // 
            // navBarGroupRaporlama
            // 
            this.navBarGroupRaporlama.Caption = "RAPORLAMA İŞLEMLERİ";
            this.navBarGroupRaporlama.Expanded = true;
            this.navBarGroupRaporlama.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroupRaporlama.ImageOptions.SmallImage")));
            this.navBarGroupRaporlama.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemRaporla)});
            this.navBarGroupRaporlama.Name = "navBarGroupRaporlama";
            // 
            // navBarItemRaporla
            // 
            this.navBarItemRaporla.Caption = "Raporları Yönet";
            this.navBarItemRaporla.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItemRaporla.ImageOptions.LargeImage")));
            this.navBarItemRaporla.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItemRaporla.ImageOptions.SmallImage")));
            this.navBarItemRaporla.Name = "navBarItemRaporla";
            // 
            // FrmContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 489);
            this.Controls.Add(this.navBarControl1);
            this.IsMdiContainer = true;
            this.Name = "FrmContainer";
            this.Text = "MARKET ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupKategori;
        private DevExpress.XtraNavBar.NavBarItem navBarKategorileriYonet;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupUrun;
        private DevExpress.XtraNavBar.NavBarItem navBarItemUrunleriYonet;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupSiparis;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSiparisleriYonet;
        private DevExpress.XtraNavBar.NavBarItem navBarItemStoklariYonet;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupSatis;
        private DevExpress.XtraNavBar.NavBarItem navBarItemSatisYonetimi;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTedarikcileriYonet;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroupRaporlama;
        private DevExpress.XtraNavBar.NavBarItem navBarItemRaporla;
    }
}