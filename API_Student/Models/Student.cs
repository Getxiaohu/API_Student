using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API_Student.Models
{
    /// <summary>
    /// 学生
    /// </summary>
    public class Student
    {
        public int SId { get; set; }
        public string StuId { get; set; }
        public string SName { get; set; }
        public bool SSex { get; set; }
        public DateTime STiem { get; set; }
        public DateTime SEndTime { get; set; }
        public int SAge { get; set; }
        public int SAddress { get; set; }
        public string image { get; set; }
        public int SStart { get; set; }
        public string SHobby { get; set; }
        public string SResume { get; set; }

        public string time { get; set; }

        public string endtime { get; set; }
        public int ClId { get; set; }

    }
}