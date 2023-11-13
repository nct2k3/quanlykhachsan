using QuanLyKhachSan.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyKhachSan.DTO;
using WinFormsApp1.DAL;

namespace QuanLyKhachSan.DAL
{
    internal class RoomDAL
    {
        private Database db;

        public RoomDAL()
        {
            db = new Database();
        }

        public void AddRoom(RoomDTO roomDTO)
        {
            //string strSQL = $"INSERT INTO room (ROOM_CODE, ROOM_NAME, FLOOR, BUILDING, DEPARTMENT) VALUES ('{roomDTO.RoomCode}', '{roomDTO.RoomName}', '{roomDTO.Floor}', '{roomDTO.Building}', '{roomDTO.Department}')";
            //db.ExecuteNonQuery(strSQL);
        }
        public void UpdateStatus(RoomDTO roomDTO)
        {

            string strSQL = $"UPDATE room SET status = '{roomDTO.status}' WHERE ROOM_ID = '{roomDTO.roomID}'";
            db.ExecuteNonQuery(strSQL);
        }
        public void UpdateRoom(RoomDTO roomDTO)
        {
            //string strSQL = $"UPDATE room SET ROOM_CODE = '{roomDTO.RoomCode}', ROOM_NAME = '{roomDTO.RoomName}', FLOOR = '{roomDTO.Floor}', BUILDING = '{roomDTO.Building}', DEPARTMENT = '{roomDTO.Department}' WHERE ROOM_ID = {roomDTO.RoomID}";
            //db.ExecuteNonQuery(strSQL);
        }

        public void DeleteRoom(int roomID)
        {
            string strSQL = $"DELETE FROM room WHERE ROOM_ID = {roomID}";
            db.ExecuteNonQuery(strSQL);
        }
        public List<RoomDTO> GetRoomsByCondition(string condition)
        {
            string strSQL = $"SELECT * FROM room WHERE {condition}";
            DataTable dt = db.Execute(strSQL);

            List<RoomDTO> roomList = new List<RoomDTO>();
            foreach (DataRow row in dt.Rows)
            {
                RoomDTO roomDTO = new RoomDTO();
                roomDTO.roomID = Convert.ToInt32(row["room_id"]);
                roomDTO.roomName = row["roomName"].ToString();
                roomDTO.status = Convert.ToInt32(row["status"]);
                roomList.Add(roomDTO);
            }
            return roomList;
        }
        public DataTable getAll()
        {
            string strSQL = "SELECT rt.roomTypeName, f.floorName, r.roomName, rt.adultQuantity, rt.childrenQuantity, r.status FROM room r\r\nJOIN roomType rt ON r.roomType_id = rt.roomType_id\r\nJOIN floor f ON r.floor_id = f.floor_id;";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
    }
}