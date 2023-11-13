namespace QuanLyKhachSan.DTO
{
    public class ExportProductDetailDTO
    {
        public int exportId { get; set; }
        public int productId { get; set; }
        public int quantity { get; set; }
        public ExportProductDetailDTO() { }
        public ExportProductDetailDTO(int exportId, int productId, int quantity)
        {
            this.exportId = exportId;
            this.productId = productId;
            this.quantity = quantity;
        }
    }
}