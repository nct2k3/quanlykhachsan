namespace QuanLyKhachSan.DTO
{
    public class BookingCustomerDTO
    {
        public int ticketId { get; set; }
        public int customerId { get; set; }
        public BookingCustomerDTO() { }
        public BookingCustomerDTO(int ticketId, int customerId)
        {
            this.ticketId = ticketId;
            this.customerId = customerId;
        }
    }
}