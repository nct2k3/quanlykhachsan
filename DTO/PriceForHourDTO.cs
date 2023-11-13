namespace QuanLyKhachSan.DTO
{
    public class PriceForHourDTO
    {
        public int priceForHourId { get; set; }
        public int priceType { get; set; }
        public double price { get; set; }
        public int pricePercent { get; set; }
        public PriceForHourDTO() { }
        public PriceForHourDTO(int priceForHourId, int priceType, double price, int pricePercent)
        {
            this.priceForHourId = priceForHourId;
            this.priceType = priceType;
            this.price = price;
            this.pricePercent = pricePercent;
        }
    }
}
