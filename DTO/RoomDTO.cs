namespace QuanLyKhachSan.DTO
{
    public class RoomDTO
    {
        public int roomID { get; set; }
        public string roomName { get; set; }
        public int roomTypeId { get; set; }
        public int floorId { get; set; }
        public int status { get; set; }
        public string note { get; set; }
        public RoomDTO() { }
        public RoomDTO(int roomId, string roomName, int roomTypeId, int floorId, int status, string note)
        {
            this.roomID = roomId;
            this.roomName = roomName;
            this.roomTypeId = roomTypeId;
            this.floorId = floorId;
            this.status = status;
            this.note = note;
        }
    }
}