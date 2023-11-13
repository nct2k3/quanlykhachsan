using QuanLyKhachSan.DAL;
using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;

namespace QuanLyKhachSan.DAL
{
    internal class FloorDAL
    {
        private Database db;

        public FloorDAL()
        {
            db = new Database();
        }

        public void AddFloor(string floorCode, string floorName, string building)
        {
            string strSQL = $"INSERT INTO floor (FLOOR_CODE, FLOOR_NAME, BUILDING) VALUES ('{floorCode}', '{floorName}', '{building}')";
            db.ExecuteNonQuery(strSQL);
        }

        public void UpdateFloor(int floorID, string floorCode, string floorName, string building)
        {
            string strSQL = $"UPDATE floor SET FLOOR_CODE = '{floorCode}', FLOOR_NAME = '{floorName}', BUILDING = '{building}' WHERE FLOOR_ID = {floorID}";
            db.ExecuteNonQuery(strSQL);
        }

        public void DeleteFloor(int floorID)
        {
            string strSQL = $"DELETE FROM floor WHERE FLOOR_ID = {floorID}";
            db.ExecuteNonQuery(strSQL);
        }

        public List<Floor> GetFloorsByCondition(string condition)
        {
            string strSQL = $"SELECT * FROM floor WHERE {condition}";
            DataTable dt = db.Execute(strSQL);

            List<Floor> floorList = new List<Floor>();
            foreach (DataRow row in dt.Rows)
            {
                Floor floor = new Floor();
                floor.floorId = Convert.ToInt32(row["floor_id"]);
                floor.floorName = row["floorName"].ToString();
                floor.defaultRoomType = Convert.ToInt32(row["defaultRoomType"]);
                floor.roomQuantity = Convert.ToInt32(row["roomQuantity"]);
                floor.status = Convert.ToInt32(row["status"]);
                floor.note = row["note"].ToString();
                floorList.Add(floor);
            }
            return floorList;
        }
        public DataTable getAll()
        {
            DataTable dt = new DataTable();
            string strSQL = $"SELECT floor_id,floorName,status,note FROM floor ";
            dt = db.Execute(strSQL);
            return dt;
        }
    }
}