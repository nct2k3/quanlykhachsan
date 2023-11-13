using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    internal class AccountDTO
    {
        public int accountId { get; set; }
        public string accountName { get; set; }
        public string password { get; set; }
        public int authId { get; set; }

        public AccountDTO() { }
        public AccountDTO(int accountId, string accountName, string password, int authId)
        {
            this.accountId = accountId;     
            this.accountName = accountName;
            this.password = password;
            this.authId = authId;
        }
    }
}
