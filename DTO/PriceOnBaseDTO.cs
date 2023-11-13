namespace QuanLyKhachSan.DTO
{
    public class PriceOnBase
    {
        public int priceRoomId { get; set; }
        public int roomTypeId { get; set; }
        public int priceTypeId { get; set; }
        public int dayOfWeek { get; set; }
        public DateTime dayBegin { get; set; }
        public DateTime dayEnd { get; set; }
        public double priceForDay { get; set; }
        public double priceForNight { get; set; }
        public double priceAddChild { get; set; }
        public double priceAddAdult { get; set; }
        public int status { get; set; }
        public PriceOnBase() { }
        public PriceOnBase(
            int priceRoomId, int roomTypeId, int priceTypeId, int dayOfWeek, DateTime dayBegin, DateTime dayEnd, double priceForDay, double priceForNight, double priceAddChild, double priceAddAdult, int status)
        {
            this.priceRoomId = priceRoomId;
            this.roomTypeId = roomTypeId;
            this.priceTypeId = priceTypeId;
            this.dayOfWeek = dayOfWeek;
            this.dayBegin = dayBegin;
            this.dayEnd = dayEnd;
            this.priceForDay = priceForDay;
            this.priceForNight = priceForNight;
            this.priceAddChild = priceAddChild;
            this.priceAddAdult = priceAddAdult;
            this.status = status;
        }
    }
}