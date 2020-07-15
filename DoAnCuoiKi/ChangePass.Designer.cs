namespace DoAnCuoiKi
{
    partial class ChangePass
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
            this.btnThayDoi = new System.Windows.Forms.Button();
            this.txbMKcu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMKmoi = new System.Windows.Forms.TextBox();
            this.checkHidePass = new System.Windows.Forms.CheckBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập mật khẩu cũ:";
            // 
            // btnThayDoi
            // 
            this.btnThayDoi.Location = new System.Drawing.Point(50, 132);
            this.btnThayDoi.Name = "btnThayDoi";
            this.btnThayDoi.Size = new System.Drawing.Size(106, 29);
            this.btnThayDoi.TabIndex = 3;
            this.btnThayDoi.Text = "Thay đổi";
            this.btnThayDoi.UseVisualStyleBackColor = true;
            this.btnThayDoi.Click += new System.EventHandler(this.btnThayDoi_Click);
            // 
            // txbMKcu
            // 
            this.txbMKcu.Location = new System.Drawing.Point(173, 37);
            this.txbMKcu.Name = "txbMKcu";
            this.txbMKcu.Size = new System.Drawing.Size(130, 20);
            this.txbMKcu.TabIndex = 0;
            this.txbMKcu.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập mật khẩu mới:";
            // 
            // txbMKmoi
            // 
            this.txbMKmoi.Location = new System.Drawing.Point(173, 72);
            this.txbMKmoi.Name = "txbMKmoi";
            this.txbMKmoi.Size = new System.Drawing.Size(130, 20);
            this.txbMKmoi.TabIndex = 1;
            this.txbMKmoi.UseSystemPasswordChar = true;
            // 
            // checkHidePass
            // 
            this.checkHidePass.AutoSize = true;
            this.checkHidePass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkHidePass.Location = new System.Drawing.Point(173, 98);
            this.checkHidePass.Name = "checkHidePass";
            this.checkHidePass.Size = new System.Drawing.Size(105, 19);
            this.checkHidePass.TabIndex = 2;
            this.checkHidePass.Text = "Hiện mật khẩu";
            this.checkHidePass.UseVisualStyleBackColor = true;
            this.checkHidePass.CheckedChanged += new System.EventHandler(this.checkHidePass_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnThoat.Location = new System.Drawing.Point(173, 132);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 29);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ChangePass
            // 
            this.AcceptButton = this.btnThayDoi;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(349, 194);
            this.Controls.Add(this.checkHidePass);
            this.Controls.Add(this.txbMKmoi);
            this.Controls.Add(this.txbMKcu);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThayDoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi mật khẩu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThayDoi;
        private System.Windows.Forms.TextBox txbMKcu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMKmoi;
        private System.Windows.Forms.CheckBox checkHidePass;
        private System.Windows.Forms.Button btnThoat;
    }
}