using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HoangDinhThienDong_5951071017.Models
{
    [DataContract]
    public class StudentsInfo
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "ID: ")]
        public int ID { get; set; }

        [DataMember(Name = "DayOfBirth: ")]
        

        public String DayOfBirth { get; set; }
    }
}