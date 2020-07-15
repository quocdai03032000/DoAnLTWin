namespace DoAnCuoiKi
{
    partial class FChamCong
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
            this.label1 = new System.Windows.Forms.Label();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNghi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbTangCa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTamUng = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbViPham = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbThuong = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txbLuong = new System.Windows.Forms.TextBox();
            this.DGVShow = new System.Windows.Forms.DataGridView();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LuongNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayNghi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayTangCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TamUng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVShow)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên:";
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(161, 26);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.ReadOnly = true;
            this.txbHoTen.Size = new System.Drawing.Size(126, 20);
            this.txbHoTen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số ngày nghỉ:";
            // 
            // txbNghi
            // 
            this.txbNghi.Location = new System.Drawing.Point(161, 83);
            this.txbNghi.Name = "txbNghi";
            this.txbNghi.Size = new System.Drawing.Size(126, 20);
            this.txbNghi.TabIndex = 1;
            this.txbNghi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNghi_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số ngày tăng ca:";
            // 
            // txbTangCa
            // 
            this.txbTangCa.Location = new System.Drawing.Point(161, 116);
            this.txbTangCa.Name = "txbTangCa";
            this.txbTangCa.Size = new System.Drawing.Size(126, 20);
            this.txbTangCa.TabIndex = 1;
            this.txbTangCa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTangCa_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tạm ứng:";
            // 
            // txbTamUng
            // 
            this.txbTamUng.Location = new System.Drawing.Point(161, 146);
            this.txbTamUng.Name = "txbTamUng";
            this.txbTamUng.Size = new System.Drawing.Size(126, 20);
            this.txbTamUng.TabIndex = 1;
            this.txbTamUng.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTamUng_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Vi phạm trừ :";
            // 
            // txbViPham
            // 
            this.txbViPham.Location = new System.Drawing.Point(161, 180);
            this.txbViPham.Name = "txbViPham";
            this.txbViPham.Size = new System.Drawing.Size(126, 20);
            this.txbViPham.TabIndex = 1;
            this.txbViPham.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbViPham_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tiền thưởng:";
            // 
            // txbThuong
            // 
            this.txbThuong.Location = new System.Drawing.Point(161, 216);
            this.txbThuong.Name = "txbThuong";
            this.txbThuong.Size = new System.Drawing.Size(126, 20);
            this.txbThuong.TabIndex = 1;
            this.txbThuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbThuong_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cập nhật";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lương cơ bản:";
            // 
            // txbLuong
            // 
            this.txbLuong.Location = new System.Drawing.Point(161, 55);
            this.txbLuong.Name = "txbLuong";
            this.txbLuong.ReadOnly = true;
            this.txbLuong.Size = new System.Drawing.Size(126, 20);
            this.txbLuong.TabIndex = 1;
            // 
            // DGVShow
            // 
            this.DGVShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNV,
            this.LuongNV,
            this.SoNgayNghi,
            this.SoNgayTangCa,
            this.TamUng,
            this.ViPham,
            this.Thuong});
            this.DGVShow.Location = new System.Drawing.Point(474, 83);
            this.DGVShow.Name = "DGVShow";
            this.DGVShow.Size = new System.Drawing.Size(337, 150);
            this.DGVShow.TabIndex = 3;
            // 
            // TenNV
            // 
            this.TenNV.DataPropertyName = "TenNV";
            this.TenNV.HeaderText = "ten";
            this.TenNV.Name = "TenNV";
            // 
            // LuongNV
            // 
            this.LuongNV.DataPropertyName = "LuongNV";
            this.LuongNV.HeaderText = "Column1";
            this.LuongNV.Name = "LuongNV";
            // 
            // SoNgayNghi
            // 
            this.SoNgayNghi.DataPropertyName = "SoNgayNghi";
            this.SoNgayNghi.HeaderText = "Column1";
            this.SoNgayNghi.Name = "SoNgayNghi";
            // 
            // SoNgayTangCa
            // 
            this.SoNgayTangCa.DataPropertyName = "SoNgayTangCa";
            this.SoNgayTangCa.HeaderText = "Column1";
            this.SoNgayTangCa.Name = "SoNgayTangCa";
            // 
            // TamUng
            // 
            this.TamUng.DataPropertyName = "TamUng";
            this.TamUng.HeaderText = "Column1";
            this.TamUng.Name = "TamUng";
            // 
            // ViPham
            // 
            this.ViPham.DataPropertyName = "ViPham";
            this.ViPham.HeaderText = "Column1";
            this.ViPham.Name = "ViPham";
            // 
            // Thuong
            // 
            this.Thuong.DataPropertyName = "Thuong";
            this.Thuong.HeaderText = "Thuong";
            this.Thuong.Name = "Thuong";
            // 
            // FChamCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 324);
            this.Controls.Add(this.DGVShow);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbThuong);
            this.Controls.Add(this.txbViPham);
            this.Controls.Add(this.txbTamUng);
            this.Controls.Add(this.txbTangCa);
            this.Controls.Add(this.txbLuong);
            this.Controls.Add(this.txbNghi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FChamCong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FChamCong";
            ((System.ComponentModel.ISupportInitialize)(this.DGVShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNghi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTangCa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTamUng;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbViPham;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbThuong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbLuong;
        private System.Windows.Forms.DataGridView DGVShow;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn LuongNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayNghi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayTangCa;
        private System.Windows.Forms.DataGridViewTextBoxColumn TamUng;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thuong;
    }
}