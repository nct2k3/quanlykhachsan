using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DAL
{
    internal class TowerDAL
    {
        private Database db;

        public TowerDAL()
        {
            db = new Database();
        }
        public DataTable getAll()
        {
            string strQuery = "SELECT * FROM tower ORDER BY tower_id ASC;";
            return db.Execute(strQuery);

        }
    }
}
