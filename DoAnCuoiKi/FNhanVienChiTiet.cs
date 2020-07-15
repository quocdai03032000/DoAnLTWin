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
    public partial class FNhanVienChiTiet : Form
    {
        
        string key;
        public FNhanVienChiTiet()
        {
            InitializeComponent();
        }
        public FNhanVienChiTiet(string key):this()
        {
            this.key = key;
            LoadData();
        }

        void LoadData()
        {
            // Đổ data
            DBE dbe = new DBE();
            var result = from nv in dbe.NhanViens
                         where nv.MaNV == key
                         select  new { MaNV = nv.MaNV, TenNV = nv.TenNV, NgaySinh = nv.NgaySinh, SoDienThoai = nv.SoDienThoai, GioiTinh = nv.GioiTinh, DanToc = nv.DanToc, QuocTich = nv.QuocTich, TonGiao = nv.TonGiao, BoPhan = nv.BoPhan.TenBoPhan, ChucVu = nv.ChucVu.TenChucVu, GiaiDoan = nv.GiaiDoan.TenGiaiDoan, NgayNhanViec = nv.NgayNhanViec };
            DGVShowThongTin.DataSource = result.ToList();

            LbMaNV.Text = key;

            // Bindings

            //LbMaNV.DataBindings.Clear();
            //LbMaNV.DataBindings.Add(new Binding ("text", DGVShowThongTin, "MaNV"));
            LbeHoTen.DataBindings.Clear();
            LbeHoTen.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "TenNV"));
            LbeSDT.DataBindings.Clear();
            LbeSDT.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "SoDienThoai"));
            LbeGioiTinh.DataBindings.Clear();
            LbeGioiTinh.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "GioiTinh"));
            LbeDanToc.DataBindings.Clear();
            LbeDanToc.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "DanToc"));
            LbeQuocTich.DataBindings.Clear();
            LbeQuocTich.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "QuocTich"));
            LbeTonGiao.DataBindings.Clear();
            LbeTonGiao.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "TonGiao"));
            LbeNgaySinh.DataBindings.Clear();
            LbeNgaySinh.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "NgaySinh"));
            LbeNgayVao.DataBindings.Clear();
            LbeNgayVao.DataBindings.Add("text", DGVShowThongTin.DataSource, "NgayNhanViec");
            //Lb.DataBindings.Clear();
            //cbBoPhan.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "BoPhan"));
            LbeChucVu.DataBindings.Clear();
            LbeChucVu.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "ChucVu"));
            LbeGiaiDoan.DataBindings.Clear();
            LbeGiaiDoan.DataBindings.Add(new Binding("text", DGVShowThongTin.DataSource, "GiaiDoan"));
            DGVShowThongTin.Hide();
        }
    }
}
