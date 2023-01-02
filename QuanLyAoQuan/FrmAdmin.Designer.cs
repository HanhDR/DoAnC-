namespace QuanLyAoQuan
{
    partial class FrmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdmin));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuhethong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangnhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudangxuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucloai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnudanhmucsp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnukhachhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnutracuu = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnubanhang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuthongke = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Cyan;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuhethong,
            this.mnudanhmuc,
            this.mnutracuu,
            this.mnubanhang,
            this.mnuthongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(10, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1000, 40);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuhethong
            // 
            this.mnuhethong.BackColor = System.Drawing.Color.Transparent;
            this.mnuhethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudangnhap,
            this.mnudangxuat,
            this.mnuthoat});
            this.mnuhethong.Name = "mnuhethong";
            this.mnuhethong.Size = new System.Drawing.Size(134, 36);
            this.mnuhethong.Text = "Hệ Thống";
            // 
            // mnudangnhap
            // 
            this.mnudangnhap.Name = "mnudangnhap";
            this.mnudangnhap.Size = new System.Drawing.Size(224, 36);
            this.mnudangnhap.Text = "Đăng Nhập";
            this.mnudangnhap.Click += new System.EventHandler(this.mnudangnhap_Click);
            // 
            // mnudangxuat
            // 
            this.mnudangxuat.Name = "mnudangxuat";
            this.mnudangxuat.Size = new System.Drawing.Size(224, 36);
            this.mnudangxuat.Text = "Đăng Xuất";
            this.mnudangxuat.Click += new System.EventHandler(this.mnudangxuat_Click);
            // 
            // mnuthoat
            // 
            this.mnuthoat.Name = "mnuthoat";
            this.mnuthoat.Size = new System.Drawing.Size(224, 36);
            this.mnuthoat.Text = "Thoát";
            this.mnuthoat.Click += new System.EventHandler(this.mnuthoat_Click);
            // 
            // mnudanhmuc
            // 
            this.mnudanhmuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnudanhmucloai,
            this.mnudanhmucsp,
            this.mnukhachhang});
            this.mnudanhmuc.Name = "mnudanhmuc";
            this.mnudanhmuc.Size = new System.Drawing.Size(139, 36);
            this.mnudanhmuc.Text = "Danh Mục";
            this.mnudanhmuc.Click += new System.EventHandler(this.mnudanhmuc_Click);
            // 
            // mnudanhmucloai
            // 
            this.mnudanhmucloai.Name = "mnudanhmucloai";
            this.mnudanhmucloai.Size = new System.Drawing.Size(231, 36);
            this.mnudanhmucloai.Text = "Loại";
            this.mnudanhmucloai.Click += new System.EventHandler(this.mnudanhmucloai_Click);
            // 
            // mnudanhmucsp
            // 
            this.mnudanhmucsp.Name = "mnudanhmucsp";
            this.mnudanhmucsp.Size = new System.Drawing.Size(231, 36);
            this.mnudanhmucsp.Text = "Sản Phẩm";
            this.mnudanhmucsp.Click += new System.EventHandler(this.mnudanhmucsp_Click);
            // 
            // mnukhachhang
            // 
            this.mnukhachhang.Name = "mnukhachhang";
            this.mnukhachhang.Size = new System.Drawing.Size(231, 36);
            this.mnukhachhang.Text = "Khách Hàng";
            this.mnukhachhang.Click += new System.EventHandler(this.mnukhachhang_Click);
            // 
            // mnutracuu
            // 
            this.mnutracuu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hóaĐơnBánHàngToolStripMenuItem});
            this.mnutracuu.Name = "mnutracuu";
            this.mnutracuu.Size = new System.Drawing.Size(109, 36);
            this.mnutracuu.Text = "Tra Cứu";
            // 
            // hóaĐơnBánHàngToolStripMenuItem
            // 
            this.hóaĐơnBánHàngToolStripMenuItem.Name = "hóaĐơnBánHàngToolStripMenuItem";
            this.hóaĐơnBánHàngToolStripMenuItem.Size = new System.Drawing.Size(308, 36);
            this.hóaĐơnBánHàngToolStripMenuItem.Text = "Hóa Đơn Bán Hàng";
            this.hóaĐơnBánHàngToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnBánHàngToolStripMenuItem_Click);
            // 
            // mnubanhang
            // 
            this.mnubanhang.Name = "mnubanhang";
            this.mnubanhang.Size = new System.Drawing.Size(132, 36);
            this.mnubanhang.Text = "Bán Hàng";
            this.mnubanhang.Click += new System.EventHandler(this.mnubaocao_Click);
            // 
            // mnuthongke
            // 
            this.mnuthongke.Name = "mnuthongke";
            this.mnuthongke.Size = new System.Drawing.Size(131, 36);
            this.mnuthongke.Text = "Thống Kê";
            this.mnuthongke.Click += new System.EventHandler(this.mnuthongke_Click);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAdmin";
            this.Text = "Quản Lý ShopPoor";
            this.Activated += new System.EventHandler(this.FrmAdmin_Activated);
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuhethong;
        private System.Windows.Forms.ToolStripMenuItem mnudangnhap;
        private System.Windows.Forms.ToolStripMenuItem mnudangxuat;
        private System.Windows.Forms.ToolStripMenuItem mnuthoat;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmuc;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucloai;
        private System.Windows.Forms.ToolStripMenuItem mnudanhmucsp;
        private System.Windows.Forms.ToolStripMenuItem mnutracuu;
        private System.Windows.Forms.ToolStripMenuItem mnubanhang;
        private System.Windows.Forms.ToolStripMenuItem mnuthongke;
        private System.Windows.Forms.ToolStripMenuItem mnukhachhang;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnBánHàngToolStripMenuItem;
    }
}

