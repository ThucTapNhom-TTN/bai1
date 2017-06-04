using ConsoleApplication1.Entity;
using Controller;
using QLNS.HelperClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLNS.Add
{
    public partial class AddStaff : winform
    {
        private NhanVienController contr = new NhanVienController();
        public AddStaff()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            CreateNhanVienMoi();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            Rectangle rc = ClientRectangle;
            if (rc.IsEmpty)
                return;
            if (rc.Width == 0 || rc.Height == 0)
                return;
            using (LinearGradientBrush brush = new LinearGradientBrush(rc, Color.White, Color.FromArgb(196, 232, 250), 90F))
            {
                e.Graphics.FillRectangle(brush, rc);
            }
        }
        private void CreateNhanVienMoi()
        {

            txtMaNV.Text = "NV" + contr.getAllNhanVien().Count;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            TblTTNVCoBan nvcb = new TblTTNVCoBan();
            nvcb.MaNV = txtMaNV.Text;
            nvcb.HoTen = txtTenNV.Text;
            nvcb.GioiTinh = cbbGioiTinh.Text;
            nvcb.MaBoPhan = cbbBophan.SelectedValue.ToString();
            nvcb.MaPhong = cbbPhongBan.SelectedValue.ToString();
            nvcb.BiDanh = txtBiDanh.Text;
            nvcb.NgaySinh = dtimeNgaySinh.Value;
            nvcb.TTHonNhan = cbbTTHonNhan.SelectedText;
            nvcb.CMTND = txtCMND.Text;
            nvcb.NgayCap = dtimeNgayCap.Value;
            nvcb.NoiCap = txtNoiCap.Text;
            nvcb.ChucVu = txtChucVu.Text;
            nvcb.ChucDanh = txtChucDanh.Text;
            nvcb.LoaiHD = "";
            nvcb.NgayKy = dtimeNgayKiHD.Value;
            nvcb.NgayHetHan = dtimeNgayHHHD.Value;
            nvcb.Anh = "";
            nvcb.GhiChu = txtGhiChuCoBan.Text;
            TblTTCaNhan nvcn = new TblTTCaNhan();
            nvcn.MaNV = txtMaNV.Text;
            nvcn.NoiSinh = txtNoiSinh.Text;
            nvcn.NguyenQuan = txtQueQuan.Text;
            nvcn.QuocTich = txtQuoctich.Text;
            nvcn.DanToc = txtDanToc.Text;
            nvcn.SDT = txtSDT.Text;
            nvcn.TrinhDoNN = txtTrinhDoNN.Text;
            nvcn.HocVan = txtHocVan.Text;
            nvcn.GhiChu = txtGhiChu.Text;
            try
            {
                contr.addNhanVien(nvcb, nvcn);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm mới nhân viên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
