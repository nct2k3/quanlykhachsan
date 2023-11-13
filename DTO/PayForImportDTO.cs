namespace QuanLyKhachSan.DTO
{
    public class PayForImportDTO
    {
        public int importId { get; set; }
        public int invoiceId { get; set; }
        public PayForImportDTO() { }
        public PayForImportDTO(int importId, int invoiceId)
        {
            this.importId = importId;
            this.invoiceId = invoiceId;
        }
    }
}