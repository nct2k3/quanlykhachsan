namespace QuanLyKhachSan.DTO
{
    public class ImportProductDetail
    {
        public int importId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public ImportProductDetail() { }
        public ImportProductDetail(int importId, int productId, int quantity)
        {
            this.importId = importId;
            this.productId = productId;
            this.quantity = quantity;
        }
    }
}