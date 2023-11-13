namespace QuanLyKhachSan.DTO
{
    public class TowerDTO
    {
        public int towerId { get; set; }
        public string towerName { get; set; }

        public int status { get; set; }
        public string note { get; set; }
        public TowerDTO() { }
        public TowerDTO(int towerId, string towerName, int status, string note)
        {
            this.towerId = towerId;
            this.towerName = towerName;
            this.status = status;
            this.note = note;
        }
    }
}