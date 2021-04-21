
namespace View
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmStorage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItems = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIncome = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmProviders = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPurchases = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClients = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRealSales = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmRoles = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmSalesConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPurchasesConsult = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmView = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbPurchase = new System.Windows.Forms.ToolStripButton();
            this.tsbSale = new System.Windows.Forms.ToolStripButton();
            this.ssAuthor = new System.Windows.Forms.StatusStrip();
            this.tsslAuthor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.ssAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStorage,
            this.tsmIncome,
            this.tsmSales,
            this.tsmAccess,
            this.tsmConsult,
            this.tsmView,
            this.tsmWindows,
            this.tsmHelp,
            this.tsmExit});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.tsmWindows;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(843, 30);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // tsmStorage
            // 
            this.tsmStorage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmCategory,
            this.tsmItems});
            this.tsmStorage.Name = "tsmStorage";
            this.tsmStorage.Size = new System.Drawing.Size(75, 24);
            this.tsmStorage.Text = "Storage";
            // 
            // tsmCategory
            // 
            this.tsmCategory.Name = "tsmCategory";
            this.tsmCategory.Size = new System.Drawing.Size(152, 26);
            this.tsmCategory.Text = "&Category";
            this.tsmCategory.Click += new System.EventHandler(this.tsmCategory_Click);
            // 
            // tsmItems
            // 
            this.tsmItems.Name = "tsmItems";
            this.tsmItems.Size = new System.Drawing.Size(152, 26);
            this.tsmItems.Text = "&Items";
            // 
            // tsmIncome
            // 
            this.tsmIncome.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmProviders,
            this.tsmPurchases});
            this.tsmIncome.Name = "tsmIncome";
            this.tsmIncome.Size = new System.Drawing.Size(72, 24);
            this.tsmIncome.Text = "Income";
            // 
            // tsmProviders
            // 
            this.tsmProviders.Name = "tsmProviders";
            this.tsmProviders.Size = new System.Drawing.Size(156, 26);
            this.tsmProviders.Text = "&Providers";
            // 
            // tsmPurchases
            // 
            this.tsmPurchases.Name = "tsmPurchases";
            this.tsmPurchases.Size = new System.Drawing.Size(156, 26);
            this.tsmPurchases.Text = "&Purchases";
            // 
            // tsmSales
            // 
            this.tsmSales.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClients,
            this.tsmRealSales});
            this.tsmSales.Name = "tsmSales";
            this.tsmSales.Size = new System.Drawing.Size(57, 24);
            this.tsmSales.Text = "Sales";
            // 
            // tsmClients
            // 
            this.tsmClients.Name = "tsmClients";
            this.tsmClients.Size = new System.Drawing.Size(136, 26);
            this.tsmClients.Text = "&Clients";
            // 
            // tsmRealSales
            // 
            this.tsmRealSales.Name = "tsmRealSales";
            this.tsmRealSales.Size = new System.Drawing.Size(136, 26);
            this.tsmRealSales.Text = "&Sales";
            // 
            // tsmAccess
            // 
            this.tsmAccess.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmRoles,
            this.tsmUsers});
            this.tsmAccess.Name = "tsmAccess";
            this.tsmAccess.Size = new System.Drawing.Size(67, 24);
            this.tsmAccess.Text = "Access";
            // 
            // tsmRoles
            // 
            this.tsmRoles.Name = "tsmRoles";
            this.tsmRoles.Size = new System.Drawing.Size(128, 26);
            this.tsmRoles.Text = "&Roles";
            // 
            // tsmUsers
            // 
            this.tsmUsers.Name = "tsmUsers";
            this.tsmUsers.Size = new System.Drawing.Size(128, 26);
            this.tsmUsers.Text = "Users";
            // 
            // tsmConsult
            // 
            this.tsmConsult.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmSalesConsult,
            this.tsmPurchasesConsult});
            this.tsmConsult.Name = "tsmConsult";
            this.tsmConsult.Size = new System.Drawing.Size(72, 24);
            this.tsmConsult.Text = "Consult";
            // 
            // tsmSalesConsult
            // 
            this.tsmSalesConsult.Name = "tsmSalesConsult";
            this.tsmSalesConsult.Size = new System.Drawing.Size(209, 26);
            this.tsmSalesConsult.Text = "Sales Consult";
            // 
            // tsmPurchasesConsult
            // 
            this.tsmPurchasesConsult.Name = "tsmPurchasesConsult";
            this.tsmPurchasesConsult.Size = new System.Drawing.Size(209, 26);
            this.tsmPurchasesConsult.Text = "Purchases Consult";
            // 
            // tsmView
            // 
            this.tsmView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem});
            this.tsmView.Name = "tsmView";
            this.tsmView.Size = new System.Drawing.Size(55, 24);
            this.tsmView.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // tsmWindows
            // 
            this.tsmWindows.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.tsmWindows.Name = "tsmWindows";
            this.tsmWindows.Size = new System.Drawing.Size(84, 24);
            this.tsmWindows.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // tsmHelp
            // 
            this.tsmHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.tsmHelp.Name = "tsmHelp";
            this.tsmHelp.Size = new System.Drawing.Size(55, 24);
            this.tsmHelp.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(204, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(47, 24);
            this.tsmExit.Text = "Exit";
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPurchase,
            this.tsbSale});
            this.toolStrip.Location = new System.Drawing.Point(0, 30);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(843, 27);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tsbPurchase
            // 
            this.tsbPurchase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPurchase.Image = global::View.Properties.Resources.compra_m;
            this.tsbPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPurchase.Name = "tsbPurchase";
            this.tsbPurchase.Size = new System.Drawing.Size(29, 24);
            // 
            // tsbSale
            // 
            this.tsbSale.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSale.Image = global::View.Properties.Resources.ventas_m;
            this.tsbSale.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSale.Name = "tsbSale";
            this.tsbSale.Size = new System.Drawing.Size(29, 24);
            // 
            // ssAuthor
            // 
            this.ssAuthor.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssAuthor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAuthor});
            this.ssAuthor.Location = new System.Drawing.Point(0, 671);
            this.ssAuthor.Name = "ssAuthor";
            this.ssAuthor.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssAuthor.Size = new System.Drawing.Size(843, 26);
            this.ssAuthor.TabIndex = 2;
            // 
            // tsslAuthor
            // 
            this.tsslAuthor.Name = "tsslAuthor";
            this.tsslAuthor.Size = new System.Drawing.Size(167, 20);
            this.tsslAuthor.Text = "Developed by Luis Perla";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 697);
            this.Controls.Add(this.ssAuthor);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.Text = "Sales & Purchases System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ssAuthor.ResumeLayout(false);
            this.ssAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip ssAuthor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel tsslAuthor;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmView;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmWindows;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmHelp;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmStorage;
        private System.Windows.Forms.ToolStripMenuItem tsmCategory;
        private System.Windows.Forms.ToolStripMenuItem tsmItems;
        private System.Windows.Forms.ToolStripMenuItem tsmIncome;
        private System.Windows.Forms.ToolStripMenuItem tsmProviders;
        private System.Windows.Forms.ToolStripMenuItem tsmPurchases;
        private System.Windows.Forms.ToolStripMenuItem tsmSales;
        private System.Windows.Forms.ToolStripMenuItem tsmClients;
        private System.Windows.Forms.ToolStripMenuItem tsmRealSales;
        private System.Windows.Forms.ToolStripMenuItem tsmAccess;
        private System.Windows.Forms.ToolStripMenuItem tsmRoles;
        private System.Windows.Forms.ToolStripMenuItem tsmUsers;
        private System.Windows.Forms.ToolStripMenuItem tsmConsult;
        private System.Windows.Forms.ToolStripMenuItem tsmSalesConsult;
        private System.Windows.Forms.ToolStripMenuItem tsmPurchasesConsult;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
        private System.Windows.Forms.ToolStripButton tsbPurchase;
        private System.Windows.Forms.ToolStripButton tsbSale;
    }
}



