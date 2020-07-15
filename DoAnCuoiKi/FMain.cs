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
    public partial class FMain : Form
    {
        DBE dbe = new DBE();
        public FMain()
        {
            InitializeComponent();
            LoadData();
        }


        private void FMain_Load(object sender, EventArgs e)
        {
            LoadData();
        }

       

        /* -------------- combobox show list nhan vien lọc theo bộ phận --------------------*/
        private void CbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if(CbShow.Text == "Tất cả")
            {
                var flag = from nv in dbe.NhanViens select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if(CbShow.Text == "Quản lí")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP6"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if (CbShow.Text == "Thu ngân")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP1"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if (CbShow.Text == "Pha chế")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP5"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if (CbShow.Text == "Vệ sinh")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP2"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if (CbShow.Text == "Phục vụ")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP4"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
            else if (CbShow.Text == "Bếp")
            {
                var flag = from nv in dbe.NhanViens
                           where nv.MaBoPhan == "BP3"
                           select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, MaNV = nv.MaNV };
                DGVShow.DataSource = flag.ToList();
                LbMaNV.DataBindings.Clear();
                LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
                LbHoTen.DataBindings.Clear();
                LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
                LbCapBac.DataBindings.Clear();
                LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
                LBBoPhan.DataBindings.Clear();
                LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
                LbGiaiDoan.DataBindings.Clear();
                LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));
            }
        }



        void LoadData()
        {
            var flag = from nv in dbe.NhanViens select new { TenNV = nv.TenNV, SoDienThoai = nv.SoDienThoai, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan,MaNV=nv.MaNV };
            DGVShow.DataSource = flag.ToList();

            CbShow.DataSource = dbe.BoPhans.ToList();
            CbShow.DisplayMember = "TenBoPhan";

            /*--- bindings ---*/
            LbMaNV.DataBindings.Clear();
            LbMaNV.DataBindings.Add(new Binding("text", DGVShow.DataSource, "MaNV"));
            LbHoTen.DataBindings.Clear();
            LbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
            LbCapBac.DataBindings.Clear();
            LbCapBac.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ChucVu"));
            LBBoPhan.DataBindings.Clear();
            LBBoPhan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "BoPhan"));
            LbGiaiDoan.DataBindings.Clear();
            LbGiaiDoan.DataBindings.Add(new Binding("text", DGVShow.DataSource, "GiaiDoan"));


        }

        private void chỉnhSửaThôngTinNVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FThemXoaSua f = new FThemXoaSua();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FNhanVienChiTiet f = new FNhanVienChiTiet(LbMaNV.Text);
            f.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePass f = new ChangePass();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FChamCong f = new FChamCong(LbMaNV.Text);
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FHoaDon f = new FHoaDon(LbMaNV.Text);
            f.Show();
        }
    }
}
