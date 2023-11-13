namespace QuanLyKhachSan.DTO
{
    public class Floor
    {
        public int floorId { get; set; }
        public string floorName { get; set; }
        public int defaultRoomType { get; set; }
        public int roomQuantity { get; set; }
        public int status { get; set; }
        public string note { get; set; }

        public Floor() { }
        public Floor(int floorId, string floorName, int defaultRoomType, int roomQuantity, int status, string note)
        {
            this.floorId = floorId;
            this.floorName = floorName;
            this.defaultRoomType = defaultRoomType;
            this.roomQuantity = roomQuantity;
            this.status = status;
            this.note = note;
        }
    }
}