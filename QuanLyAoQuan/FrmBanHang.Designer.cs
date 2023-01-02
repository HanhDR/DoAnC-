namespace QuanLyAoQuan
{
    partial class FrmBanHang
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.datasanpham = new System.Windows.Forms.DataGridView();
            this.masp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tensp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnthemkh = new System.Windows.Forms.Button();
            this.dtngaymua = new System.Windows.Forms.DateTimePicker();
            this.txtsl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmkh = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txttkh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtmsp = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtmhd = new System.Windows.Forms.TextBox();
            this.btnmhd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncan = new System.Windows.Forms.Button();
            this.btnrs = new System.Windows.Forms.Button();
            this.btnthanhtoan = new System.Windows.Forms.Button();
            this.btnthemsp = new System.Windows.Forms.Button();
            this.btnthemhd = new System.Windows.Forms.Button();
            this.datahoadon = new System.Windows.Forms.DataGridView();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txttong = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txttensp);
            this.panel1.Controls.Add(this.btnsearch);
            this.panel1.Controls.Add(this.datasanpham);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 505);
            this.panel1.TabIndex = 0;
            // 
            // datasanpham
            // 
            this.datasanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datasanpham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.masp,
            this.tensp,
            this.gia});
            this.datasanpham.Location = new System.Drawing.Point(-1, 81);
            this.datasanpham.Name = "datasanpham";
            this.datasanpham.RowHeadersWidth = 51;
            this.datasanpham.RowTemplate.Height = 24;
            this.datasanpham.Size = new System.Drawing.Size(303, 423);
            this.datasanpham.TabIndex = 0;
            this.datasanpham.Click += new System.EventHandler(this.datasanpham_Click);
            // 
            // masp
            // 
            this.masp.DataPropertyName = "masp";
            this.masp.HeaderText = "Mã Sản Phẩm";
            this.masp.MinimumWidth = 6;
            this.masp.Name = "masp";
            this.masp.Width = 125;
            // 
            // tensp
            // 
            this.tensp.DataPropertyName = "tensp";
            this.tensp.HeaderText = "Tên Sản Phẩm";
            this.tensp.MinimumWidth = 6;
            this.tensp.Name = "tensp";
            this.tensp.Width = 125;
            // 
            // gia
            // 
            this.gia.DataPropertyName = "gia";
            this.gia.HeaderText = "Giá";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnthemkh);
            this.panel2.Controls.Add(this.dtngaymua);
            this.panel2.Controls.Add(this.txtsl);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtmkh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtsdt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txttkh);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtmsp);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtsp);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(301, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 140);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnthemkh
            // 
            this.btnthemkh.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnthemkh.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemkh.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthemkh.Location = new System.Drawing.Point(466, 8);
            this.btnthemkh.Name = "btnthemkh";
            this.btnthemkh.Size = new System.Drawing.Size(108, 31);
            this.btnthemkh.TabIndex = 6;
            this.btnthemkh.Text = "Thêm KH";
            this.btnthemkh.UseVisualStyleBackColor = false;
            this.btnthemkh.Click += new System.EventHandler(this.btnthemkh_Click);
            // 
            // dtngaymua
            // 
            this.dtngaymua.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtngaymua.Location = new System.Drawing.Point(552, 108);
            this.dtngaymua.Name = "dtngaymua";
            this.dtngaymua.Size = new System.Drawing.Size(166, 22);
            this.dtngaymua.TabIndex = 5;
            // 
            // txtsl
            // 
            this.txtsl.Location = new System.Drawing.Point(175, 110);
            this.txtsl.Name = "txtsl";
            this.txtsl.Size = new System.Drawing.Size(159, 22);
            this.txtsl.TabIndex = 4;
            this.txtsl.TextChanged += new System.EventHandler(this.txtsl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 27);
            this.label8.TabIndex = 3;
            this.label8.Text = "Số Lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(401, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 27);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ngày Mua";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtmkh
            // 
            this.txtmkh.Location = new System.Drawing.Point(552, 80);
            this.txtmkh.Name = "txtmkh";
            this.txtmkh.Size = new System.Drawing.Size(166, 22);
            this.txtmkh.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Mã Khách Hàng";
            this.label1.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(552, 49);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(166, 22);
            this.txtsdt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 27);
            this.label5.TabIndex = 3;
            this.label5.Text = "Số Điện Thoại";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txttkh
            // 
            this.txttkh.Location = new System.Drawing.Point(307, 12);
            this.txttkh.Name = "txttkh";
            this.txttkh.Size = new System.Drawing.Size(147, 22);
            this.txttkh.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên Khách Hàng";
            // 
            // txtmsp
            // 
            this.txtmsp.Location = new System.Drawing.Point(174, 77);
            this.txtmsp.Name = "txtmsp";
            this.txtmsp.Size = new System.Drawing.Size(160, 22);
            this.txtmsp.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 27);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã Sản Phẩm";
            // 
            // txtsp
            // 
            this.txtsp.Location = new System.Drawing.Point(175, 49);
            this.txtsp.Name = "txtsp";
            this.txtsp.Size = new System.Drawing.Size(160, 22);
            this.txtsp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 27);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Sản Phẩm";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(0, 144);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(772, 361);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.txttong);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtmhd);
            this.panel4.Controls.Add(this.btnmhd);
            this.panel4.Controls.Add(this.dataGridView1);
            this.panel4.Controls.Add(this.btncan);
            this.panel4.Controls.Add(this.btnrs);
            this.panel4.Controls.Add(this.btnthanhtoan);
            this.panel4.Controls.Add(this.btnthemsp);
            this.panel4.Controls.Add(this.btnthemhd);
            this.panel4.Controls.Add(this.datahoadon);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(301, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(841, 371);
            this.panel4.TabIndex = 2;
            // 
            // txtmhd
            // 
            this.txtmhd.Location = new System.Drawing.Point(700, 127);
            this.txtmhd.Name = "txtmhd";
            this.txtmhd.Size = new System.Drawing.Size(103, 27);
            this.txtmhd.TabIndex = 9;
            // 
            // btnmhd
            // 
            this.btnmhd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnmhd.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmhd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnmhd.Location = new System.Drawing.Point(701, 89);
            this.btnmhd.Name = "btnmhd";
            this.btnmhd.Size = new System.Drawing.Size(102, 32);
            this.btnmhd.TabIndex = 8;
            this.btnmhd.Text = "MãHD";
            this.btnmhd.UseVisualStyleBackColor = false;
            this.btnmhd.Click += new System.EventHandler(this.btnmhd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD});
            this.dataGridView1.Location = new System.Drawing.Point(641, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(188, 82);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaHD
            // 
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã Hóa Đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            this.MaHD.Width = 125;
            // 
            // btncan
            // 
            this.btncan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btncan.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btncan.Location = new System.Drawing.Point(624, 324);
            this.btncan.Name = "btncan";
            this.btncan.Size = new System.Drawing.Size(118, 35);
            this.btncan.TabIndex = 1;
            this.btncan.Text = "Cancel";
            this.btncan.UseVisualStyleBackColor = false;
            this.btncan.Click += new System.EventHandler(this.btncan_Click);
            // 
            // btnrs
            // 
            this.btnrs.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnrs.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrs.Location = new System.Drawing.Point(456, 324);
            this.btnrs.Name = "btnrs";
            this.btnrs.Size = new System.Drawing.Size(118, 35);
            this.btnrs.TabIndex = 1;
            this.btnrs.Text = "Reset";
            this.btnrs.UseVisualStyleBackColor = false;
            // 
            // btnthanhtoan
            // 
            this.btnthanhtoan.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnthanhtoan.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthanhtoan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthanhtoan.Location = new System.Drawing.Point(647, 283);
            this.btnthanhtoan.Name = "btnthanhtoan";
            this.btnthanhtoan.Size = new System.Drawing.Size(169, 35);
            this.btnthanhtoan.TabIndex = 1;
            this.btnthanhtoan.Text = "Thanh Toán";
            this.btnthanhtoan.UseVisualStyleBackColor = false;
            this.btnthanhtoan.Click += new System.EventHandler(this.btnthanhtoan_Click);
            // 
            // btnthemsp
            // 
            this.btnthemsp.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnthemsp.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemsp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthemsp.Location = new System.Drawing.Point(250, 324);
            this.btnthemsp.Name = "btnthemsp";
            this.btnthemsp.Size = new System.Drawing.Size(118, 35);
            this.btnthemsp.TabIndex = 1;
            this.btnthemsp.Text = "Thêm SP";
            this.btnthemsp.UseVisualStyleBackColor = false;
            this.btnthemsp.Click += new System.EventHandler(this.btnthemsp_Click_1);
            // 
            // btnthemhd
            // 
            this.btnthemhd.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnthemhd.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemhd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnthemhd.Location = new System.Drawing.Point(68, 324);
            this.btnthemhd.Name = "btnthemhd";
            this.btnthemhd.Size = new System.Drawing.Size(118, 35);
            this.btnthemhd.TabIndex = 1;
            this.btnthemhd.Text = "Tạo Mới HĐ";
            this.btnthemhd.UseVisualStyleBackColor = false;
            this.btnthemhd.Click += new System.EventHandler(this.btnthemsp_Click);
            // 
            // datahoadon
            // 
            this.datahoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahoadon.Location = new System.Drawing.Point(-1, 1);
            this.datahoadon.Name = "datahoadon";
            this.datahoadon.RowHeadersWidth = 51;
            this.datahoadon.RowTemplate.Height = 24;
            this.datahoadon.Size = new System.Drawing.Size(642, 270);
            this.datahoadon.TabIndex = 0;
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnsearch.Location = new System.Drawing.Point(79, 50);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(90, 26);
            this.btnsearch.TabIndex = 1;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txttensp
            // 
            this.txttensp.Location = new System.Drawing.Point(24, 22);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(221, 22);
            this.txttensp.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tổng Tiền:";
            // 
            // txttong
            // 
            this.txttong.Location = new System.Drawing.Point(109, 271);
            this.txttong.Name = "txttong";
            this.txttong.Size = new System.Drawing.Size(226, 27);
            this.txttong.TabIndex = 11;
            // 
            // FrmBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 507);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmBanHang";
            this.Text = "FrmBanHang";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datasanpham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datahoadon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView datasanpham;
        private System.Windows.Forms.DateTimePicker dtngaymua;
        private System.Windows.Forms.TextBox txtsl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttkh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtmsp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncan;
        private System.Windows.Forms.Button btnrs;
        private System.Windows.Forms.Button btnthanhtoan;
        private System.Windows.Forms.Button btnthemsp;
        private System.Windows.Forms.Button btnthemhd;
        private System.Windows.Forms.DataGridView datahoadon;
        private System.Windows.Forms.DataGridViewTextBoxColumn masp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tensp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.Button btnthemkh;
        private System.Windows.Forms.TextBox txtmkh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtmhd;
        private System.Windows.Forms.Button btnmhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txttong;
        private System.Windows.Forms.Label label7;
    }
}