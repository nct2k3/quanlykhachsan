namespace QuanLyKhachSan.DTO
{
    public class RoomTypeDTO
    {
        public int roomTypeId { get; set; }
        public string roomTypeName { get; set; }
        public int adultQuantity { get; set; }
        public int childQuantity { get; set; }
        public string note { get; set; }
        public RoomTypeDTO() { }
        public RoomTypeDTO(int roomTypeId, string roomTypeName, int adultQuantity, int childQuantity, string note)
        {
            this.roomTypeId = roomTypeId;
            this.roomTypeName = roomTypeName;
            this.adultQuantity = adultQuantity;
            this.childQuantity = childQuantity;
            this.note = note;
        }
    }
}