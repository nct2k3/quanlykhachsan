namespace QuanLyKhachSan.DTO
{
    public class AuthorizationDTO
    {
        public int authId { get; set; }
        public string func { get; set; }
        public AuthorizationDTO() { }
        public AuthorizationDTO(int authId, string func)
        {
            this.authId = authId;
            this.func = func;
        }
    }
}
