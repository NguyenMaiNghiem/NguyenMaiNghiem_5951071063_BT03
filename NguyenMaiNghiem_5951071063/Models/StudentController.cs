using NguyenMaiNghiem_5951071063.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenMaiNghiem_5951071063.Models
{
    public class StudentController : ApiController
    {
        // GET: api/Weather
               public IEnumerable<StudentInfo> Get()
               {
                   var studentInfList = new List<StudentInfo>();
                   for (int i = 0; i < 10; i++)
                   {
                       var StudentInfo = new StudentInfo
                       {
                           StudentCode = $"SV00{i}",
                           Name ="Nguyen Mai Nghiem",
                           Sex = "Nam",
                           DateTime = DateTime.Now.ToUniversalTime()
                       };
                       studentInfList.Add(StudentInfo);
                   }
                   return studentInfList;
               }
       
        // GET: api/Weather/5
        public StudentInfo Get(int id)
        {
            return new StudentInfo
            {
                StudentCode = $"SV00{id}",
                Name ="Nguyen Mai Nghiem",
                Sex = "Nam",
                DateTime = DateTime.Now.ToUniversalTime()
            }; ;
        }

    }
}
