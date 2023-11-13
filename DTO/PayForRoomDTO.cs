namespace QuanLyKhachSan.DTO
{
    public class PayForRoomDTO
    {
        public int ticketId { get; set; }
        public int invoiceId { get; set; }
        public PayForRoomDTO() { }
        public PayForRoomDTO(int ticketId, int invoiceId)
        {
            this.ticketId = ticketId;
            this.invoiceId = invoiceId;
        }
    }
}