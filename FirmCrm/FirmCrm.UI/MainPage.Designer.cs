using System;

namespace FirmCrm.UI
{
    partial class MainPage
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DASHBOARD");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Add Product");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Search Product");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PRODUCT", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Add Order");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Search Order");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("ORDER", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Add Customer");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Search Customer");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("CUSTOMER", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Add Supplier");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Search Supplier");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("SUPPLIER", new System.Windows.Forms.TreeNode[] {
            treeNode15,
            treeNode16});
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Add Category");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Search Category");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("CATEGORY", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("STOCK");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.grpbHeader = new System.Windows.Forms.GroupBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.trvMenu = new System.Windows.Forms.TreeView();
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.grpbHeader.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.grpbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1902, 100);
            this.pnlHeader.TabIndex = 4;
            // 
            // grpbHeader
            // 
            this.grpbHeader.BackColor = System.Drawing.Color.DarkSlateGray;
            this.grpbHeader.Controls.Add(this.pnlTitle);
            this.grpbHeader.Controls.Add(this.lblTime);
            this.grpbHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpbHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grpbHeader.Location = new System.Drawing.Point(0, 0);
            this.grpbHeader.Name = "grpbHeader";
            this.grpbHeader.Size = new System.Drawing.Size(1900, 97);
            this.grpbHeader.TabIndex = 1;
            this.grpbHeader.TabStop = false;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.label1);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTitle.Location = new System.Drawing.Point(3, 18);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(194, 76);
            this.pnlTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firm CRM";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTime.Location = new System.Drawing.Point(1712, 64);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(152, 17);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "16-mei-2016 10:34:23 ";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnlLeft
            // 
            this.pnlLeft.Controls.Add(this.monthCalendar1);
            this.pnlLeft.Controls.Add(this.trvMenu);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 100);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.pnlLeft.Size = new System.Drawing.Size(231, 798);
            this.pnlLeft.TabIndex = 5;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar1.Location = new System.Drawing.Point(4, 595);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 11;
            // 
            // trvMenu
            // 
            this.trvMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.trvMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trvMenu.HideSelection = false;
            this.trvMenu.HotTracking = true;
            this.trvMenu.Location = new System.Drawing.Point(4, 4);
            this.trvMenu.Margin = new System.Windows.Forms.Padding(0);
            this.trvMenu.Name = "trvMenu";
            treeNode1.Name = "Node1";
            treeNode1.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            treeNode1.Text = "DASHBOARD";
            treeNode2.Name = "Node1";
            treeNode2.Text = "";
            treeNode3.Name = "trvAddProduct";
            treeNode3.Text = "Add Product";
            treeNode4.Name = "trvSearchProduct";
            treeNode4.Text = "Search Product";
            treeNode5.Checked = true;
            treeNode5.Name = "trvProduct";
            treeNode5.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            treeNode5.Text = "PRODUCT";
            treeNode6.Name = "Node0";
            treeNode6.Text = "";
            treeNode7.Name = "trvAddOrder";
            treeNode7.Text = "Add Order";
            treeNode8.Name = "trvSearchOrder";
            treeNode8.Text = "Search Order";
            treeNode9.Checked = true;
            treeNode9.Name = "trvOrder";
            treeNode9.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            treeNode9.Text = "ORDER";
            treeNode10.Name = "Node15";
            treeNode10.Text = "";
            treeNode11.Name = "trvAddCustomer";
            treeNode11.Text = "Add Customer";
            treeNode12.Name = "trvSearchCustomer";
            treeNode12.Text = "Search Customer";
            treeNode13.Checked = true;
            treeNode13.Name = "trvCustomer";
            treeNode13.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            treeNode13.Text = "CUSTOMER";
            treeNode14.Name = "Node0";
            treeNode14.Text = "";
            treeNode15.Name = "trvAddSupplier";
            treeNode15.Text = "Add Supplier";
            treeNode16.Name = "trvSearchupplier";
            treeNode16.Text = "Search Supplier";
            treeNode17.Checked = true;
            treeNode17.Name = "trvSupplier";
            treeNode17.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F);
            treeNode17.Text = "SUPPLIER";
            treeNode18.Name = "Node2";
            treeNode18.Text = "";
            treeNode19.Name = "trvAddCategory";
            treeNode19.Text = "Add Category";
            treeNode20.Name = "trvSearchCategory";
            treeNode20.Text = "Search Category";
            treeNode21.Name = "trvCategory";
            treeNode21.Text = "CATEGORY";
            treeNode22.Name = "Node5";
            treeNode22.Text = "";
            treeNode23.Checked = true;
            treeNode23.Name = "trvStock";
            treeNode23.NodeFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            treeNode23.Text = "STOCK";
            this.trvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode6,
            treeNode9,
            treeNode10,
            treeNode13,
            treeNode14,
            treeNode17,
            treeNode18,
            treeNode21,
            treeNode22,
            treeNode23});
            this.trvMenu.Scrollable = false;
            this.trvMenu.ShowNodeToolTips = true;
            this.trvMenu.ShowPlusMinus = false;
            this.trvMenu.ShowRootLines = false;
            this.trvMenu.Size = new System.Drawing.Size(227, 587);
            this.trvMenu.TabIndex = 10;
            this.trvMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvMenu_AfterSelect_1);
            // 
            // pnlView
            // 
            this.pnlView.BackColor = System.Drawing.SystemColors.Window;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(4, 4);
            this.pnlView.Name = "pnlView";
            this.pnlView.Padding = new System.Windows.Forms.Padding(4);
            this.pnlView.Size = new System.Drawing.Size(1663, 790);
            this.pnlView.TabIndex = 31;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.pnlView);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(231, 100);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(4);
            this.pnlMain.Size = new System.Drawing.Size(1671, 798);
            this.pnlMain.TabIndex = 6;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1902, 898);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FirmCrm: your best workforce";
            this.pnlHeader.ResumeLayout(false);
            this.grpbHeader.ResumeLayout(false);
            this.grpbHeader.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.GroupBox grpbHeader;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TreeView trvMenu;
        private System.Windows.Forms.Panel pnlView;
        private System.Windows.Forms.Panel pnlMain;
    }
}