namespace QuanLyKhachSan.DTO
{
    public class BookingRoomDTO
    {
        public int ticketId {  get; set; }
        public int roomId { get; set; }
        public BookingRoomDTO() { }
        public BookingRoomDTO(int ticketId, int roomId)
        {
            this.ticketId = ticketId;
            this.roomId = roomId;
        }
    }
}