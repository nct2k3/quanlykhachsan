namespace QuanLyKhachSan.DTO
{
    public class ProductDTO
    {
        public int productId { get; set; }
        public string productName { get; set; }
        public int unitId { get; set; }
        public double costPrice { get; set; }
        public double sellPrice { get; set; }
        public string note { get; set; }
        public ProductDTO() { }
        public ProductDTO(int productId, string productName, int unitId, double costPrice, double sellPrice, string note)
        {
            this.productId = productId;
            this.productName = productName;
            this.unitId = unitId;
            this.costPrice = costPrice;
            this.sellPrice = sellPrice;
            this.note = note;
        }
    }
}