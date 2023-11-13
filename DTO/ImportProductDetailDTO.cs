namespace QuanLyKhachSan.DTO
{
    public class ImportProduct
    {
        public int importId { get; set; }
        public int providerId { get; set; }
        public DateTime importData { get; set; }
        public int total { get; set; }
        public int storeId { get; set; }
        public ImportProduct() { }
        public ImportProduct(int importId, int providerId, DateTime importData, int total, int storeId)
        {
            this.importId = importId;
            this.providerId = providerId;
            this.importData = importData;
            this.total = total;
            this.storeId = storeId;
        }
    }
}