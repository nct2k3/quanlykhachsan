namespace QuanLyKhachSan.DTO
{
    public class ProductGroupDTO
    {
        public int productGroupId { get; set; }
        public string productGroupName { get; set; }
        public int status { get; set; }
        public ProductGroupDTO() { }
        public ProductGroupDTO(int productGroupId, string productGroupName, int status)
        {
            this.productGroupId = productGroupId;
            this.productGroupName = productGroupName;
            this.status = status;
        }
    }
}