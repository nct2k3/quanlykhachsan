using System.Runtime.CompilerServices;

namespace QuanLyKhachSan.DTO
{
    public class ProviderDTO
    {
        public int providerId { get; set; }
        public string providerName { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string note { get; set; }
        public ProviderDTO() { }
        public ProviderDTO(int providerId, string providerName, string phone, string email, string address, string note)
        {
            this.providerId = providerId;
            this.providerName = providerName;
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.note = note;
        }
    }
}
