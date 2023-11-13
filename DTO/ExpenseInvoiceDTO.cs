namespace QuanLyKhachSan.DTO
{
    public class ExpenseInvoiceDTO
    {
        public int invoiceId { get; set; }
        public int target { get; set; }
        public int paymentAmount { get; set; }
        public int staffId { get; set; }
        public int fundId { get; set; }
        public DateTime collectionDate { get; set; }
        public string note { get; set; }
        public ExpenseInvoiceDTO() { }
        public ExpenseInvoiceDTO(int invoiceId, int target, int paymentAmount, int staffId, int fundId, DateTime collectionDate, string note)
        {
            this.invoiceId = invoiceId;
            this.target = target;
            this.paymentAmount = paymentAmount;
            this.staffId = staffId;
            this.fundId = fundId;
            this.collectionDate = collectionDate;
            this.note = note;
        }
    }
}
