using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class FThemXoaSua : Form
    {
        DBE dbe = new DBE();
        public FThemXoaSua()
        {
            InitializeComponent();
            LoadData();
        }

        #region EVENT
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận thêm ?", "Thông báo",MessageBoxButtons.OKCancel)==System.Windows.Forms.DialogResult.OK)
            {
                AddNhanVien();
            }           

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xoá ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                DelNhanVien();
            }            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận sửa ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                FixNhanVien();
            }            
        }
        #endregion

        void LoadData()
        {
            /*đổ data vào datagview*/

            var flag = from nv in dbe.NhanViens select new { MaNV = nv.MaNV, TenNV=nv.TenNV,NgaySinh=nv.NgaySinh,SoDienThoai=nv.SoDienThoai,GioiTinh=nv.GioiTinh,DanToc=nv.DanToc,QuocTich=nv.QuocTich,TonGiao=nv.TonGiao,BoPhan=nv.BoPhan.TenBoPhan,ChucVu=nv.ChucVu.TenChucVu, GiaiDoan=nv.GiaiDoan.TenGiaiDoan, NgayNhanViec=nv.NgayNhanViec };
            DGVShowList.DataSource = flag.ToList();

            cbBoPhan.DataSource = dbe.BoPhans.ToList();
            cbBoPhan.DisplayMember = "TenBoPhan";
            cbChucVu.DataSource = dbe.ChucVus.ToList();
            cbChucVu.DisplayMember = "TenChucVu";
            cbGiaiDoan.DataSource = dbe.GiaiDoans.ToList();
            cbGiaiDoan.DisplayMember = "TenGiaiDoan";

            /*bindling*/
            txbMaNV.DataBindings.Clear();
            txbMaNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "MaNV"));
            txbTenNV.DataBindings.Clear();
            txbTenNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "TenNV"));
            txbSDT.DataBindings.Clear();
            txbSDT.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "SoDienThoai"));
            txbGioiTinhNV.DataBindings.Clear();
            txbGioiTinhNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "GioiTinh"));
            txbDanTocNV.DataBindings.Clear();
            txbDanTocNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "DanToc"));
            txbQuocTichNV.DataBindings.Clear();
            txbQuocTichNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "QuocTich"));
            txbTonGiaoNV.DataBindings.Clear();
            txbTonGiaoNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "TonGiao"));
            DTPNgaySinhNV.DataBindings.Clear();
            DTPNgaySinhNV.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "NgaySinh"));
            DTPNgayBatDau.DataBindings.Clear();
            DTPNgayBatDau.DataBindings.Add("text", DGVShowList.DataSource, "NgayNhanViec");
            cbBoPhan.DataBindings.Clear();
            cbBoPhan.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "BoPhan"));
            cbChucVu.DataBindings.Clear();
            cbChucVu.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "ChucVu"));
            cbGiaiDoan.DataBindings.Clear();
            cbGiaiDoan.DataBindings.Add(new Binding("text", DGVShowList.DataSource, "GiaiDoan"));           

        }

        void AddNhanVien()
        {
            DBE dbeAdd = new DBE();
            string maNV = txbMaNV.Text;
            NhanVien NV = dbeAdd.NhanViens.Where(nv => nv.MaNV == maNV).SingleOrDefault();
            if(NV==null)
            {
                NhanVien item = new NhanVien();
                item.MaNV = txbMaNV.Text;
                item.TenNV = txbTenNV.Text;
                item.NgaySinh = DTPNgaySinhNV.Value;
                item.SoDienThoai = txbSDT.Text;
                item.GioiTinh = txbGioiTinhNV.Text;
                item.DanToc = txbDanTocNV.Text;
                item.TonGiao = txbTonGiaoNV.Text;
                item.NgayNhanViec = DTPNgayBatDau.Value;
                item.QuocTich = txbQuocTichNV.Text;
                item.MaChucVu = ((ChucVu)cbChucVu.SelectedValue).MaChucVu;
                item.MaBoPhan = ((BoPhan)cbBoPhan.SelectedValue).MaBoPhan;
                item.MaGiaiDoan = ((GiaiDoan)cbGiaiDoan.SelectedValue).MaGiaiDoan;
                dbeAdd.NhanViens.Add(item);
                dbeAdd.SaveChanges();
                LoadData();
            } else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã nhân viên", "Thông báo");
            }
        }
        void DelNhanVien()
        {
            DBE delNV = new DBE();
            string maNV = txbMaNV.Text;
            NhanVien NV = delNV.NhanViens.Where(nv => nv.MaNV == maNV).SingleOrDefault();
            if(NV!=null)
            {
                delNV.NhanViens.Remove(NV);
                delNV.SaveChanges();
                LoadData();
            }else
            {
                MessageBox.Show("Kiểm tra lại mã nhân viên", "Thông báo");
            }
        }
        void FixNhanVien()
        {
            DBE updateNV = new DBE();
            string maNV = txbMaNV.Text;
            NhanVien NV = updateNV.NhanViens.Where(nv => nv.MaNV == maNV).SingleOrDefault();
            if(NV!=null)
            {
                NV.MaNV = txbMaNV.Text;
                NV.TenNV = txbTenNV.Text;
                NV.NgaySinh = DTPNgaySinhNV.Value;
                NV.SoDienThoai = txbSDT.Text;
                NV.GioiTinh = txbGioiTinhNV.Text;
                NV.DanToc = txbDanTocNV.Text;
                NV.TonGiao = txbTonGiaoNV.Text;
                NV.NgayNhanViec = DTPNgayBatDau.Value;
                NV.QuocTich = txbQuocTichNV.Text;
                NV.MaChucVu = ((ChucVu)cbChucVu.SelectedValue).MaChucVu;
                NV.MaBoPhan = ((BoPhan)cbBoPhan.SelectedValue).MaBoPhan;
                NV.MaGiaiDoan = ((GiaiDoan)cbGiaiDoan.SelectedValue).MaGiaiDoan;
                updateNV.SaveChanges();
                LoadData();
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại mã nhân viên", "Thông báo");
            }
            
        }
    }
}
