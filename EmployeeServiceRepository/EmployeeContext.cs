﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceRepository
{
    [Serializable]
    public class EmployeeContext:DbContext
    {

        public DbSet<Employee> Employees { get; set; }

        public EmployeeContext():base("EmpServiceDb")
        {

        }

    }
}
