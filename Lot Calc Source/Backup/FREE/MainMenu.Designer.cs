namespace FREE
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.clientPanel = new DevExpress.XtraEditors.PanelControl();
            this.navBar = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.ParaGirisCikisnavBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.HaberAnalizinavBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.TakasBilgilerinavBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.JavaMatriksStnavBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.DokumannavBarItem = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItemTakas = new DevExpress.XtraNavBar.NavBarItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).BeginInit();
            this.clientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = null;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.SelectedPage = this.ribbonPage1;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(175, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            this.ribbonPage1.Visible = false;
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 481);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(175, 25);
            // 
            // clientPanel
            // 
            this.clientPanel.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.clientPanel.Controls.Add(this.navBar);
            this.clientPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clientPanel.Location = new System.Drawing.Point(0, 143);
            this.clientPanel.Name = "clientPanel";
            this.clientPanel.Size = new System.Drawing.Size(175, 338);
            this.clientPanel.TabIndex = 2;
            // 
            // navBar
            // 
            this.navBar.ActiveGroup = this.navBarGroup1;
            this.navBar.ContentButtonHint = null;
            this.navBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBar.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBar.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem3,
            this.JavaMatriksStnavBarItem,
            this.navBarItem5,
            this.ParaGirisCikisnavBarItem,
            this.DokumannavBarItem,
            this.HaberAnalizinavBarItem,
            this.TakasBilgilerinavBarItem,
            this.navBarItemTakas});
            this.navBar.Location = new System.Drawing.Point(0, 0);
            this.navBar.Name = "navBar";
            this.navBar.OptionsNavPane.ExpandedWidth = 175;
            this.navBar.Size = new System.Drawing.Size(175, 338);
            this.navBar.TabIndex = 0;
            this.navBar.Text = "Java Matriks ST";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Temel Analiz";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Detay Bilanço ve Gelir Tabloları";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Raporlar";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.ParaGirisCikisnavBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.HaberAnalizinavBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.TakasBilgilerinavBarItem),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItemTakas)});
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SmallImage = global::FREE.Properties.Resources.Charts_and_Graphs_16;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Dip Zirve Analizi";
            this.navBarItem3.Name = "navBarItem3";
            // 
            // ParaGirisCikisnavBarItem
            // 
            this.ParaGirisCikisnavBarItem.Caption = "Para Giriş Çıkışı";
            this.ParaGirisCikisnavBarItem.Name = "ParaGirisCikisnavBarItem";
            this.ParaGirisCikisnavBarItem.SmallImage = global::FREE.Properties.Resources.Money_24;
            this.ParaGirisCikisnavBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.ParaGirisCikisnavBarItem_LinkClicked);
            // 
            // HaberAnalizinavBarItem
            // 
            this.HaberAnalizinavBarItem.Caption = "Haber Analizi";
            this.HaberAnalizinavBarItem.Name = "HaberAnalizinavBarItem";
            this.HaberAnalizinavBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.HaberAnalizinavBarItem_LinkClicked);
            // 
            // TakasBilgilerinavBarItem
            // 
            this.TakasBilgilerinavBarItem.Caption = "Takas Bilgileri";
            this.TakasBilgilerinavBarItem.Name = "TakasBilgilerinavBarItem";
            this.TakasBilgilerinavBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.TakasBilgilerinavBarItem_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Terminal";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.JavaMatriksStnavBarItem)});
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SmallImage = global::FREE.Properties.Resources.chart_organisation;
            // 
            // JavaMatriksStnavBarItem
            // 
            this.JavaMatriksStnavBarItem.Caption = "Java Matriks ST";
            this.JavaMatriksStnavBarItem.LargeImage = global::FREE.Properties.Resources.Line_Graph_with_Markers_24;
            this.JavaMatriksStnavBarItem.Name = "JavaMatriksStnavBarItem";
            this.JavaMatriksStnavBarItem.SmallImage = global::FREE.Properties.Resources.Line_Graph_with_Markers_24;
            this.JavaMatriksStnavBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.JavaMatriksStnavBarItem_LinkClicked);
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Uygulamalar";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.DokumannavBarItem)});
            this.navBarGroup4.LargeImage = global::FREE.Properties.Resources.calculator_add;
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Hesap Makinesi";
            this.navBarItem5.LargeImage = global::FREE.Properties.Resources.Calculator_24;
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImage = global::FREE.Properties.Resources.Calculator_24;
            this.navBarItem5.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem5_LinkClicked);
            // 
            // DokumannavBarItem
            // 
            this.DokumannavBarItem.Caption = "Dökümanlar";
            this.DokumannavBarItem.Name = "DokumannavBarItem";
            this.DokumannavBarItem.SmallImage = global::FREE.Properties.Resources.Bookmark_24;
            this.DokumannavBarItem.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.DokumannavBarItem_LinkClicked);
            // 
            // navBarItemTakas
            // 
            this.navBarItemTakas.Caption = "Takas Rapor";
            this.navBarItemTakas.Name = "navBarItemTakas";
            this.navBarItemTakas.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItemTakas_LinkClicked);
            // 
            // MainMenu
            // 
            this.AutoHideRibbon = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 506);
            this.Controls.Add(this.clientPanel);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.Shown += new System.EventHandler(this.MainMenu_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientPanel)).EndInit();
            this.clientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraEditors.PanelControl clientPanel;
        private DevExpress.XtraNavBar.NavBarControl navBar;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem JavaMatriksStnavBarItem;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem ParaGirisCikisnavBarItem;
        private DevExpress.XtraNavBar.NavBarItem DokumannavBarItem;
        private DevExpress.XtraNavBar.NavBarItem HaberAnalizinavBarItem;
        private DevExpress.XtraNavBar.NavBarItem TakasBilgilerinavBarItem;
        private DevExpress.XtraNavBar.NavBarItem navBarItemTakas;
    }
}