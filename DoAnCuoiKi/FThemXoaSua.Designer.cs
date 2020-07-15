namespace DoAnCuoiKi
{
    partial class FThemXoaSua
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
            this.DGVShowList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbMaNV = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTenNV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbGioiTinhNV = new System.Windows.Forms.TextBox();
            this.DTPNgaySinhNV = new System.Windows.Forms.DateTimePicker();
            this.cbChucVu = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txbDanTocNV = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbQuocTichNV = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbTonGiaoNV = new System.Windows.Forms.TextBox();
            this.DTPNgayLam = new System.Windows.Forms.Label();
            this.DTPNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.cbBoPhan = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbGiaiDoan = new System.Windows.Forms.ComboBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DanToc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuocTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TonGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhanViec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaiDoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowList)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVShowList
            // 
            this.DGVShowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShowList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.SDT,
            this.GioiTinh,
            this.DanToc,
            this.QuocTich,
            this.TonGiao,
            this.NgayNhanViec,
            this.ChucVu,
            this.BoPhan,
            this.GiaiDoan});
            this.DGVShowList.Location = new System.Drawing.Point(12, 12);
            this.DGVShowList.Name = "DGVShowList";
            this.DGVShowList.Size = new System.Drawing.Size(427, 426);
            this.DGVShowList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(463, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã NV:";
            // 
            // txbMaNV
            // 
            this.txbMaNV.Location = new System.Drawing.Point(537, 18);
            this.txbMaNV.Name = "txbMaNV";
            this.txbMaNV.Size = new System.Drawing.Size(133, 20);
            this.txbMaNV.TabIndex = 2;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(466, 393);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(82, 30);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên NV:";
            // 
            // txbTenNV
            // 
            this.txbTenNV.Location = new System.Drawing.Point(537, 44);
            this.txbTenNV.Name = "txbTenNV";
            this.txbTenNV.Size = new System.Drawing.Size(133, 20);
            this.txbTenNV.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Sinh:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "SĐT:";
            // 
            // txbSDT
            // 
            this.txbSDT.Location = new System.Drawing.Point(537, 99);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(133, 20);
            this.txbSDT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Chức vụ :";
            // 
            // txbGioiTinhNV
            // 
            this.txbGioiTinhNV.Location = new System.Drawing.Point(537, 125);
            this.txbGioiTinhNV.Name = "txbGioiTinhNV";
            this.txbGioiTinhNV.Size = new System.Drawing.Size(133, 20);
            this.txbGioiTinhNV.TabIndex = 2;
            // 
            // DTPNgaySinhNV
            // 
            this.DTPNgaySinhNV.Location = new System.Drawing.Point(537, 70);
            this.DTPNgaySinhNV.Name = "DTPNgaySinhNV";
            this.DTPNgaySinhNV.Size = new System.Drawing.Size(200, 20);
            this.DTPNgaySinhNV.TabIndex = 4;
            // 
            // cbChucVu
            // 
            this.cbChucVu.FormattingEnabled = true;
            this.cbChucVu.Location = new System.Drawing.Point(538, 285);
            this.cbChucVu.Name = "cbChucVu";
            this.cbChucVu.Size = new System.Drawing.Size(133, 21);
            this.cbChucVu.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Giới tính:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(463, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dân tộc:";
            // 
            // txbDanTocNV
            // 
            this.txbDanTocNV.Location = new System.Drawing.Point(537, 155);
            this.txbDanTocNV.Name = "txbDanTocNV";
            this.txbDanTocNV.Size = new System.Drawing.Size(133, 20);
            this.txbDanTocNV.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(463, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quốc tịch:";
            // 
            // txbQuocTichNV
            // 
            this.txbQuocTichNV.Location = new System.Drawing.Point(537, 185);
            this.txbQuocTichNV.Name = "txbQuocTichNV";
            this.txbQuocTichNV.Size = new System.Drawing.Size(133, 20);
            this.txbQuocTichNV.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(463, 218);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Tôn giáo:";
            // 
            // txbTonGiaoNV
            // 
            this.txbTonGiaoNV.Location = new System.Drawing.Point(537, 215);
            this.txbTonGiaoNV.Name = "txbTonGiaoNV";
            this.txbTonGiaoNV.Size = new System.Drawing.Size(133, 20);
            this.txbTonGiaoNV.TabIndex = 2;
            // 
            // DTPNgayLam
            // 
            this.DTPNgayLam.AutoSize = true;
            this.DTPNgayLam.Location = new System.Drawing.Point(463, 253);
            this.DTPNgayLam.Name = "DTPNgayLam";
            this.DTPNgayLam.Size = new System.Drawing.Size(75, 13);
            this.DTPNgayLam.TabIndex = 1;
            this.DTPNgayLam.Text = "Ngày bắt đầu:";
            // 
            // DTPNgayBatDau
            // 
            this.DTPNgayBatDau.Location = new System.Drawing.Point(537, 253);
            this.DTPNgayBatDau.Name = "DTPNgayBatDau";
            this.DTPNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.DTPNgayBatDau.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(463, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Bộ phận :";
            // 
            // cbBoPhan
            // 
            this.cbBoPhan.FormattingEnabled = true;
            this.cbBoPhan.Location = new System.Drawing.Point(538, 316);
            this.cbBoPhan.Name = "cbBoPhan";
            this.cbBoPhan.Size = new System.Drawing.Size(133, 21);
            this.cbBoPhan.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(463, 352);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Giai đoạn :";
            // 
            // cbGiaiDoan
            // 
            this.cbGiaiDoan.FormattingEnabled = true;
            this.cbGiaiDoan.Location = new System.Drawing.Point(538, 349);
            this.cbGiaiDoan.Name = "cbGiaiDoan";
            this.cbGiaiDoan.Size = new System.Drawing.Size(133, 21);
            this.cbGiaiDoan.TabIndex = 5;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(554, 393);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 30);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(642, 393);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 30);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // MaNV
            // 
            this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.Width = 97;
            // 
            // TenNV
            // 
            this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "Tên nhân viên";
            this.TenNV.Name = "TenNV";
            this.TenNV.Width = 101;
            // 
            // NgaySinh
            // 
            this.NgaySinh.DataPropertyName = "NgaySinh";
            this.NgaySinh.HeaderText = "Ngày sinh";
            this.NgaySinh.Name = "NgaySinh";
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SoDienThoai";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.Name = "SDT";
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "GioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.Name = "GioiTinh";
            // 
            // DanToc
            // 
            this.DanToc.DataPropertyName = "DanToc";
            this.DanToc.HeaderText = "Dân tộc";
            this.DanToc.Name = "DanToc";
            // 
            // QuocTich
            // 
            this.QuocTich.DataPropertyName = "QuocTich";
            this.QuocTich.HeaderText = "Quốc tịch";
            this.QuocTich.Name = "QuocTich";
            // 
            // TonGiao
            // 
            this.TonGiao.DataPropertyName = "TonGiao";
            this.TonGiao.HeaderText = "Tôn giáo";
            this.TonGiao.Name = "TonGiao";
            // 
            // NgayNhanViec
            // 
            this.NgayNhanViec.DataPropertyName = "NgayNhanViec";
            this.NgayNhanViec.HeaderText = "Ngày nhận việc";
            this.NgayNhanViec.Name = "NgayNhanViec";
            // 
            // ChucVu
            // 
            this.ChucVu.DataPropertyName = "ChucVu";
            this.ChucVu.HeaderText = "Chức vụ";
            this.ChucVu.Name = "ChucVu";
            // 
            // BoPhan
            // 
            this.BoPhan.DataPropertyName = "BoPhan";
            this.BoPhan.HeaderText = "Bộ phận";
            this.BoPhan.Name = "BoPhan";
            // 
            // GiaiDoan
            // 
            this.GiaiDoan.DataPropertyName = "GiaiDoan";
            this.GiaiDoan.HeaderText = "Giai đoạn";
            this.GiaiDoan.Name = "GiaiDoan";
            // 
            // FThemXoaSua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 472);
            this.Controls.Add(this.cbGiaiDoan);
            this.Controls.Add(this.cbBoPhan);
            this.Controls.Add(this.cbChucVu);
            this.Controls.Add(this.DTPNgayBatDau);
            this.Controls.Add(this.DTPNgaySinhNV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txbTonGiaoNV);
            this.Controls.Add(this.txbQuocTichNV);
            this.Controls.Add(this.txbDanTocNV);
            this.Controls.Add(this.txbGioiTinhNV);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbTenNV);
            this.Controls.Add(this.txbMaNV);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DTPNgayLam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DGVShowList);
            this.Name = "FThemXoaSua";
            this.Text = "Chỉnh sửa Nhân Viên";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShowList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVShowList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMaNV;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTenNV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbGioiTinhNV;
        private System.Windows.Forms.DateTimePicker DTPNgaySinhNV;
        private System.Windows.Forms.ComboBox cbChucVu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbDanTocNV;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbQuocTichNV;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbTonGiaoNV;
        private System.Windows.Forms.Label DTPNgayLam;
        private System.Windows.Forms.DateTimePicker DTPNgayBatDau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBoPhan;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbGiaiDoan;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn DanToc;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuocTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn TonGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhanViec;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaiDoan;
    }
}