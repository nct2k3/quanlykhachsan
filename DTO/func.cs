using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.DTO
{
    internal class func
    {
        public int FUNC_ID { get; set; }
        public string FUNC_CODE { get; set; }
        public int SORT { get; set; }
        public string DESCRIPTION { get; set; }
        public bool ISGROUP { get; set; }
        public string PARENT { get; set; }
        public bool MENU { get; set; }
        public string TIPS { get; set; }
        public func() { }
    }
}
