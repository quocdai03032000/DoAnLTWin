using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCuoiKi
{
    public partial class FHoaDon : Form
    {
        DBE dbee = new DBE();
        string key;
        public FHoaDon()
        {
            InitializeComponent();
            LoadData();
        }
        public FHoaDon(string key) : this()
        {
            this.key = key;
            LoadData();
            TinhLuong();
            DGVShowData.Hide();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Date: " + DateTime.Now.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(25, 160));
        }

        private void btnXuatHoaDon_Click(object sender, EventArgs e)
        {
           
        }

        void LoadData()
        {
            DBE dbe = new DBE();
            var result = from nv in dbe.ChamCongs
                             where nv.MaNV == key
                         select  new { TenNV = nv.NhanVien.TenNV, LuongNV = nv.LuongNV.Luong, SoNgayNghi = nv.SoNgayNghi, SoNgayTangCa = nv.SoNgayTangCa, TamUng = nv.TamUng, ViPham = nv.ViPham, Thuong = nv.Thuong };
            DGVShowData.DataSource = result.ToList();

            txbTenNV.DataBindings.Clear();
            txbTenNV.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "TenNV"));
            txbLuong.DataBindings.Clear();
            txbLuong.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "LuongNV"));
            txbSoNgayNghi.DataBindings.Clear();
            txbSoNgayNghi.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "SoNgayNghi"));
            txbSoNgayTangCa.DataBindings.Clear();
            txbSoNgayTangCa.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "SoNgayTangCa"));
            txbTamUng.DataBindings.Clear();
            txbTamUng.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "TamUng"));
            txbViPham.DataBindings.Clear();
            txbViPham.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "ViPham"));
            txbThuong.DataBindings.Clear();
            txbThuong.DataBindings.Add(new Binding("text", DGVShowData.DataSource, "Thuong"));

            txbSoNgayLam.Text = "30";

            

        }

        void TinhLuong()
        {
           
            string Luong="";
            string NgayLam = "";
            string TangCa = "";
            string NgayNghi = "";
            string TamUng = "";
            string ViPham = "";
            string Thuong = "";
            var fg = from u in dbee.ChamCongs
                     where u.MaNV==key
                     select u;
            foreach(var data in fg)
            {
                Luong = data.LuongNV.Luong.ToString();
                TangCa = data.SoNgayTangCa.ToString();
                NgayNghi = data.SoNgayNghi.ToString();
                TamUng = data.TamUng.ToString();
                ViPham = data.ViPham.ToString();
                Thuong = data.Thuong.ToString();
            }

            int total1 = int.Parse(Luong) + (int.Parse(TangCa) * 100000);
            int total2 = (int.Parse(NgayNghi) * 100000) + int.Parse(TamUng) + int.Parse(ViPham);
            int total = total1 - total2 + int.Parse(Thuong);
            txbTongTru.Text = total2.ToString();
            txbTongNhan.Text = total1.ToString();


            CultureInfo culture = new CultureInfo("vi-VN");


            LbTotal.Text = total.ToString("c", culture);




        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanh toán thành công ", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
} 
