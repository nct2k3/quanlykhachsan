using DevExpress.XtraSpreadsheet.Mouse;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;


namespace QuanLyKhachSan.DAL
{
    internal class frmMainDAL
    {

        private Database db;

        public frmMainDAL()
        {
            db = new Database();
        }

 

        public void AddFunc(string funcCode, int sort, string decription, bool isGroup, string parent, bool menu, string tips)
        {
            string strSQL = $"INSERT INTO func (FUNC_CODE, SORT, DECRIPTION, ISGROUP, PARENT, MENU, TIPS) VALUES ('{funcCode}', {sort}, '{decription}', {Convert.ToInt32(isGroup)}, '{parent}', {Convert.ToInt32(menu)}, '{tips}')";
            db.ExecuteNonQuery(strSQL);
        }

        public void SuaDong(int funcID, string funcCode, int sort, string decription, bool isGroup, string parent, bool menu, string tips)
        {
            string strSQL = $"UPDATE func SET FUNC_CODE = '{funcCode}', SORT = {sort}, DECRIPTION = '{decription}', ISGROUP = {Convert.ToInt32(isGroup)}, PARENT = '{parent}', MENU = {Convert.ToInt32(menu)}, TIPS = '{tips}' WHERE FUNC_ID = {funcID}";
            db.ExecuteNonQuery(strSQL);
        }

        public void XoaDong(int funcID)
        {
            string strSQL = $"DELETE FROM func WHERE FUNC_ID = {funcID}";
            db.ExecuteNonQuery(strSQL);
        }

        public List<func> LayThongTinTheoDieuKien(string condition)
        {
            string strSQL = $"SELECT * FROM func WHERE {condition}";
            DataTable dt = db.Execute(strSQL);

            List<func> danhSachFunc = new List<func>();
            foreach (DataRow row in dt.Rows)
            {
                func func = new func();
                func.FUNC_ID = Convert.ToInt32(row["FUNC_ID"]);
                func.FUNC_CODE = row["FUNC_CODE"].ToString();
                func.SORT = Convert.ToInt32(row["SORT"]);
                func.DESCRIPTION = row["DESCRIPTION"].ToString();
                func.PARENT = row["PARENT"].ToString();
                func.TIPS = row["TIPS"].ToString();
                danhSachFunc.Add(func);
            }
            return danhSachFunc;
        }

        // Các thuộc tính tương đương với cấu trúc bảng

    }
}
