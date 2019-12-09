using EmployeeServiceClient.EmployeeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmployeeServiceClient.Controllers
{
    public class EmployeeController : Controller
    {

        public ActionResult Index()
        {
            var data = new List<Employee>();

            try
            {


                EmployeeRepositoryClient client = new EmployeeRepositoryClient();

                data = client.GetAllEmployee().ToList();
            }
            catch (Exception exc)
            {

                Console.WriteLine(exc.Message);
            }

            return View(data.ToList());


        }


    }
}