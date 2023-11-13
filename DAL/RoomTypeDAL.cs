using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    internal class RoomTypeDAL
    {
        Database db;
        public RoomTypeDAL()
        {
            db = new Database();
        }
        public DataTable getAll()
        {
            string strSQL = "SELECT * FROM ROOMTYPE";
            
            return db.Execute(strSQL);
        }
    }
}
