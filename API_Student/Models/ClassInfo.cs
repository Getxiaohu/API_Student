using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Student.Models
{
    /// <summary>
    /// 班级
    /// </summary>
    public class ClassInfo
    {
        public int CId { get; set; }
        public string CName { get; set; }
        public int ScId { get; set; }
    }
}