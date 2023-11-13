namespace QuanLyKhachSan.DTO
{
    public class OnHours
    {
        public int priceForHoursId { get; set; }
        public int priceRoomId { get; set; }
        public OnHours() { }
        public OnHours(int priceForHoursId, int priceRoomId)
        {
            this.priceForHoursId = priceForHoursId;
            this.priceRoomId = priceRoomId;
        }
    }
}