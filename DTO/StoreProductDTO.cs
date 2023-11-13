namespace QuanLyKhachSan.DTO
{
    public class StoreProductDTO
    {
        public int storeId {  get; set; }
        public string storeName { get; set; }
        public string managementName { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public StoreProductDTO() { }
        public StoreProductDTO(int storeId, string storeName, string managementName, string address, string note)
        {
            this.storeId = storeId;
            this.storeName = storeName;
            this.managementName = managementName;
            this.address = address;
            this.note = note;
        }
    }
}