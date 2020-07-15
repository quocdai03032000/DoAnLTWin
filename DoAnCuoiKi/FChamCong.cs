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
    public partial class FChamCong : Form
    {
        string key;
        public FChamCong()
        {
            InitializeComponent();
            LoadData();
        }
        public FChamCong(string key) : this()
        {
            this.key = key;
            LoadData();
            DGVShow.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        void LoadData()
        {
            DBE dbe = new DBE();
            var result = from nv in dbe.ChamCongs
                         where nv.MaNV == key
                         select new { TenNV = nv.NhanVien.TenNV,LuongNV=nv.LuongNV.Luong, SoNgayNghi=nv.SoNgayNghi,SoNgayTangCa=nv.SoNgayTangCa,TamUng=nv.TamUng,ViPham=nv.ViPham,Thuong=nv.Thuong};
            DGVShow.DataSource = result.ToList();

            txbHoTen.DataBindings.Clear();
            txbHoTen.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TenNV"));
            txbLuong.DataBindings.Clear();
            txbLuong.DataBindings.Add(new Binding("text", DGVShow.DataSource, "LuongNV"));
            txbNghi.DataBindings.Clear();
            txbNghi.DataBindings.Add(new Binding("text", DGVShow.DataSource, "SoNgayNghi"));
            txbTangCa.DataBindings.Clear();
            txbTangCa.DataBindings.Add(new Binding("text", DGVShow.DataSource, "SoNgayTangCa"));
            txbTamUng.DataBindings.Clear();
            txbTamUng.DataBindings.Add(new Binding("text", DGVShow.DataSource, "TamUng"));
            txbViPham.DataBindings.Clear();
            txbViPham.DataBindings.Add(new Binding("text", DGVShow.DataSource, "ViPham"));
            txbThuong.DataBindings.Clear();
            txbThuong.DataBindings.Add(new Binding("text", DGVShow.DataSource, "Thuong"));
        }

        void Update()
        {
            DBE dbeUpdate = new DBE();
            
            string maNV = key;
            ChamCong NV = dbeUpdate.ChamCongs.Where(nv => nv.MaNV == maNV).SingleOrDefault();
            NV.SoNgayNghi =txbNghi.Text;
            NV.SoNgayTangCa = txbTangCa.Text;
            NV.TamUng = txbTamUng.Text;
            NV.ViPham = txbViPham.Text;
            NV.Thuong = txbThuong.Text;
            dbeUpdate.SaveChanges();            
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbNghi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txbTangCa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txbTamUng_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txbViPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }

        private void txbThuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar == '-'))
            {
                e.Handled = true;
            }
        }
    }
}
