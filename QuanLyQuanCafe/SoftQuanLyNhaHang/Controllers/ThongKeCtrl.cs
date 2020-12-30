using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Controllers
{
    class ThongKeCtrl
    {
        public static DataSet FillDataSet_getThucDonByTime(DateTime NgayThang)
        {
            try
            {
                Models.ThongKeMod tke = new Models.ThongKeMod(NgayThang);
                return tke.FillDataSet_getThucDonByTime();

            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_getTimeOrder(DateTime NgayThang)
        {
            try
            {
                Models.ThongKeMod tke = new Models.ThongKeMod(NgayThang);
                return tke.FillDataSet_getTimeOrder();

            }
            catch
            {
                return null;
            }
        }
    }
}
