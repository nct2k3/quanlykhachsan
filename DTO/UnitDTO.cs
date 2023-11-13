namespace QuanLyKhachSan.DTO
{
    public class UnitDTO
    {
        public int unitId { get; set; }
        public string unitName { get; set; }
        public UnitDTO() { }
        public UnitDTO(int unitId, string unitName)
        {
            this.unitId = unitId;
                this.unitName = unitName;
        }
    }
}