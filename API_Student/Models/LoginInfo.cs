using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Student.Models
{
    /// <summary>
    /// 登录
    /// </summary>
    public class LoginInfo
    {
        public int Lid { get; set; }
        public string LUser { get; set; }
        public string LPwd { get; set; }
    }
}