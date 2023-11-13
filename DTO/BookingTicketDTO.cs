namespace QuanLyKhachSan.DTO
{
    public class BookingTicketDTO
    {
        public int ticketId { get; set; }
        public DateTime checkinTime { get; set; }
        public DateTime checkoutTime { get; set; }
        public int type { get; set; }
        public int reduce { get; set; }
        public int discountRate { get; set; }
        public string note { get; set; }
        public int companyId { get; set; }
        public int deposiAmount { get; set; }
        public int paymentAmount { get; set; }
        public int status { get; set; }
        public int staffId { get; set; }

        public BookingTicketDTO() { }
        public BookingTicketDTO(int ticketId, DateTime checkinTime, DateTime checkoutTime, int type, int reduce, int discountRate, string note, int companyId, int deposiAmount, int paymentAmount, int status, int staffId)
        {
            this.ticketId = ticketId;
            this.checkinTime = checkinTime;
            this.checkoutTime = checkoutTime;
            this.type = type;
            this.reduce = reduce;
            this.discountRate = discountRate;
            this.note = note;
            this.companyId = companyId;
            this.deposiAmount = deposiAmount;
            this.paymentAmount = paymentAmount;
            this.status = status;
            this.staffId = staffId;
        }
    }
}
