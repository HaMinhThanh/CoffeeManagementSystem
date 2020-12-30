using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftQuanLyNhaHang.Models
{
    class ThongKeMod
    {
        protected string IdThongKe { get; set; }       
        protected DateTime ThoiGian { get; set; }
        protected decimal TongThu { get; set; }
        protected decimal TongChi { get; set; }
        protected decimal DoanhThu { get; set; }

        public ThongKeMod()
        {

        }

        public ThongKeMod(string idThongKe)
        {
            IdThongKe = idThongKe;
        }
        public ThongKeMod(DateTime NgayThang)
        {
            ThoiGian = NgayThang;
        }
        public ThongKeMod(string idThongKe,  DateTime ngayLap,Decimal tongThu, Decimal tongChi, Decimal doanhThu)
        {
            IdThongKe = idThongKe;          
            ThoiGian = ngayLap;
            TongThu = tongThu;
            TongChi = tongChi;
            DoanhThu = doanhThu;
        }
        public int InsertThongKe()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdThongKe", "@ThoiGian", "@TongThu", "@TongChi", "@DoanhThu" };
            object[] values = new object[5] { IdThongKe, ThoiGian, TongThu, TongChi, DoanhThu };
            i = Models.connection.Excute_Sql("spInsertThongKe", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThongKe()
        {
            int i = 0;
            string[] paras = new string[5] { "@IdThongKe", "@ThoiGian", "@TongThu", "@TongChi", "@DoanhThu" };
            object[] values = new object[5] { IdThongKe, ThoiGian, TongThu, TongChi, DoanhThu };
            i = Models.connection.Excute_Sql("spUpdateThongKe", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteThongKe()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdThongKe" };
            object[] values = new object[1] { IdThongKe };
            i = Models.connection.Excute_Sql("spDeleteThongKe", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetThucDonPhoBien()
        {
            return Models.connection.FillDataSet("spgetDSThongKe", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetTimeOrder()
        {
            return Models.connection.FillDataSet("spgetDSThongKe", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetThongKe()
        {
            return Models.connection.FillDataSet("spgetDSThongKe", CommandType.StoredProcedure);
        }

        public DataSet FillDataSet_getHoaDonByTime()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@NgayThang" };
            object[] values = new object[1] { ThoiGian };
            ds = Models.connection.FillDataSet("spgetHoaDonByTime", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_getThucDonByTime()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@NgayThang" };
            object[] values = new object[1] { ThoiGian };
            ds = Models.connection.FillDataSet("spgetThucDonBySoLuong", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_getTimeOrder()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@NgayThang" };
            object[] values = new object[1] { ThoiGian };
            ds = Models.connection.FillDataSet("spgetTimeOrder", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
