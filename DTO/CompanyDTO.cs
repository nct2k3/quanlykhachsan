namespace QuanLyKhachSan.DTO
{
    public class CompanyDTO
    {
        public int companyId { get; set; }
        public int companyTaxId { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }

        public string note { set; get; }
        public int tourOperator { get; set; }
        public CompanyDTO() { }
        public CompanyDTO(int companyId, int companyTaxId, string email, string phone, string address, string note, int tourOperator)
        {
            this.companyId = companyId;
            this.companyTaxId = companyTaxId;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.note = note;
            this.tourOperator = tourOperator;
        }
    }
}