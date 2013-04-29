using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmsData
{
    public class AttendanceInfo
    {
        public string id { get; set; }
        public DateTime atnddate { get; set; }
        public string stuname { get; set; }
        public string tchrname { get; set; }
        public string stuclass { get; set; }
        public string present { get; set; }
    }
}
