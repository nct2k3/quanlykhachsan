namespace QuanLyKhachSan.DTO
{
    public class PayForExportDTO
    {
        public int exportId { get; set; }
        public int invoiceId { get; set; }
        public PayForExportDTO() { }
        public PayForExportDTO(int exportId, int invoiceId)
        {
            this.exportId = exportId;
            this.invoiceId = invoiceId;
        }
    }

}