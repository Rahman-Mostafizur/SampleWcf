﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceRepository
{
   //[Serializable]
   [DataContract]
    public class Employee //: IEmployee
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string FullName => $"{FirstName} {LastName}";
        [DataMember]
        public decimal Salary { get; set; }


    }
}
