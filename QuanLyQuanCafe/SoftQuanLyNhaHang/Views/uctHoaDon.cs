using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftQuanLyNhaHang
{
    public partial class uctHoaDon : UserControl
    {
        public uctHoaDon()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Decimal tien = Convert.ToInt32(lblTongTien.Text);
            lblTienThua.Text = (tien - numTienNhan.Value).ToString() + " VNĐ";
        }

        private void uctHoaDon_Load(object sender, EventArgs e)
        {
            txtIDHoaDon.Text = Models.connection.ExcuteScalar(string.Format("select IdHoaDon= dbo.fcgetIdHoaDon()"));
        }
    }
}
