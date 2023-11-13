using System.ComponentModel.DataAnnotations;

namespace QuanLyKhachSan.DTO
{
    public class StaffDTO
    {
        public int staffId { get; set; }
        public int name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string accountId { get; set; }

        public StaffDTO() { }
        public StaffDTO(int staffId, int name, string email, string phone, string address, string accountId)
        {
            this.staffId = staffId;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.accountId = accountId;
        }
    }
}
