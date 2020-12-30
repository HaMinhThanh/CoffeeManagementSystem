using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang.Views
{
    public partial class uctThuChi : UserControl
    {
        public uctThuChi()
        {
            InitializeComponent();
        }

        public static uctThuChi uctTC = new uctThuChi();

        private void button1_Click(object sender, EventArgs e)
        {
            tinhtien();
            uctThuChi_Load(sender, e);
        }
        public void HienThiDanhSachHoaDon()
        {
            dgvDanhSachHD.DataSource = Models.HoaDonMod.FillDataSetHoaDon().Tables[0];
            dgvDanhSachHD.Dock = DockStyle.Fill;
            dgvDanhSachHD.RowHeadersVisible = false;
            dgvDanhSachHD.BorderStyle = BorderStyle.Fixed3D;
        }
        public void HienThiDanhSachThucDonMuaNhieu()
        {
            DataTable dt = new DataTable();
            dt = Controllers.ThongKeCtrl.FillDataSet_getThucDonByTime(dtpNgayThang.Value).Tables[0];
            dgvHangPhoBien.DataSource = dt;
        }   
        
        public void HienThiGioMuaNhieu()
        {
            DataTable dt = new DataTable();
            dt = Controllers.ThongKeCtrl.FillDataSet_getTimeOrder(dtpNgayThang.Value).Tables[0];
            dgvTimeOrder.DataSource = dt;
        }
        public void HienThiLichSuBC()
        {
            dgvLichSuBC.DataSource = Models.ThongKeMod.FillDataSetThongKe().Tables[0];
            dgvLichSuBC.Dock = DockStyle.Fill;
            dgvLichSuBC.RowHeadersVisible = false;
            dgvLichSuBC.BorderStyle = BorderStyle.Fixed3D;
        }

        private void uctThuChi_Load(object sender, EventArgs e)
        {
            ClearText();
            Set();
            dtpNgayThang.Value = DateTime.Now;
            HienThiDanhSachHoaDon();
            HienThiDanhSachThucDonMuaNhieu();
            HienThiGioMuaNhieu();
            HienThiLichSuBC();
            tinhtien();
        }
        public void ClearText()
        {
            lblTongThu.Text = "";
            lblTongChi.Text = "";
            lblDoanhThu.Text = "";
        }
        public void Set()
        {
            lblTongThu.Text = "6500000";
            lblTongChi.Text = "2000000";
            lblDoanhThu.Text = "4500000";
        }

        public void tinhtien()
        {
            dgvDanhSachHD.DataSource = Models.HoaDonMod.FillDataSetHoaDon().Tables[0];
            try
            {
                int tien = dgvDanhSachHD.Rows.Count;
                decimal thanhtien = 0;
                for (int i = 0; i < tien; i++)
                {
                    //thanhtien += decimal.Parse(dgvDanhSachHD.Rows[i].Cells["Số Tiền"].Value.ToString());
                    //lblTongThu.Text = dgvDanhSachHD.Rows[i].Cells["Số Tiền"].Value.ToString();
                }
                //lblTongThu.Text = thanhtien.ToString("#,###") + " VND";
                //lblTongThu.ForeColor = SystemColors.HotTrack;
            }
            catch
            {
                MessageBox.Show("Bạn chưa thiết lập thống kê", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);             
            }
        }
    }
}
