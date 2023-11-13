using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    internal class AuthGroupDTO
    {
        public int authId { get; set; }
        public string authName { get; set; }
        public string status { get; set; }
        public string description { get; set; }
        public AuthGroupDTO() { }
        public AuthGroupDTO(int authId, string authName, string status, string description)
        {
            this.authId = authId;
            this.authName = authName;
            this.status = status;
            this.description = description;
        }
    }
}
