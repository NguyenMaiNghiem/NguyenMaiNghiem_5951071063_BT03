using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace NguyenMaiNghiem_5951071063.Controllers
{
    [DataContract]
    public class StudentInfo
    {
        [DataMember(Name = "MaSV")]
        public string StudentCode { get; set; }
        [DataMember(Name = "HoTen")]
        public string Name { get; set; }
        [DataMember(Name = "GioiTinh")]
        public string Sex { get; set; }
        [DataMember(Name = "NgaySinh")]
        public DateTime DateTime { get; set; }
    }
}