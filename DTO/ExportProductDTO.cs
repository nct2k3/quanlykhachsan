namespace QuanLyKhachSan.DTO
{
    public class ExportProductDTO
    {
        public int exportId { get; set; }
        public DateTime exportDate { get; set; }
        public int total { get; set; }
        public int storeId { get; set; }
        public int discountRate { get; set; }
        public int VATRate { get; set; }
        public int promotion { get; set; }
        public int settlement { get; set; }
        public int status { get; set; }
        public ExportProductDTO() { }
        public ExportProductDTO(int exportId, DateTime exportDate, int total, int storeId, int discountRate, int vATRate, int promotion, int settlement, int status)
        {
            this.exportId = exportId;
            this.exportDate = exportDate;
            this.total = total;
            this.storeId = storeId;
            this.discountRate = discountRate;
            VATRate = vATRate;
            this.promotion = promotion;
            this.settlement = settlement;
            this.status = status;
        }
    }
}
