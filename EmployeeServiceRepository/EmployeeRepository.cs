using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmployeeServiceRepository
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeRepository" in both code and config file together.
  
    public class EmployeeRepository : IEmployeeRepository
    {

        public EmployeeContext db = new EmployeeContext();
        //public EmployeeContext db {get;set; } = new EmployeeContext();



        public EmployeeRepository()
        {
            db.Database.CreateIfNotExists();
        }


        public Employee DeleteEmployee(int id)
        {
            Employee emp = db.Employees.Find(id);

            if (emp != null)
            {
                db.Employees.Remove(emp);
                db.SaveChanges();

            }
            return emp;

        }

        public List<Employee> GetAllEmployee()
        {
            return db.Employees.ToList();
        }

        public Employee GetEmployeeById(int id)
        {
            return db.Employees.Find(id);
        }

        public Employee SaveEmployee(Employee emp)
        {
            try
            {
                db.Employees.Add(emp);
                db.SaveChanges();
            }
            catch (Exception)
            {

            }
            return emp;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            try
            {
                db.Entry(emp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            catch (Exception)
            {
            }
            return emp;
        }
    }
}
