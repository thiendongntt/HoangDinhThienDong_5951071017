using HoangDinhThienDong_5951071017.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HoangDinhThienDong_5951071017.Controllers
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IEnumerable<StudentsInfo> Get()
        {
            var studentsList = new List<StudentsInfo>();
            for (int i = 0; i < 10; i++)
            {
                var StudentsInfo = new StudentsInfo
                {
                    ID = i,
                    Name = $" Hoang Dinh Thien Dong {i}",
                    DayOfBirth = $"1{i}/{i+1}/200{i}"
                };
                studentsList.Add(StudentsInfo);
            }


            return studentsList;
        }

        // GET: api/Student/5
        public StudentsInfo Get(int id)
        {
            return new StudentsInfo
            {
                ID = id,
                Name = $" Hoang Dinh Thien Dong {id}",
                DayOfBirth = $"1{id}/{id + 1}/200{id}"
            }; ;
        }

        //// POST: api/Student
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Student/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Student/5
        //public void Delete(int id)
        //{
        //}
    }
}
