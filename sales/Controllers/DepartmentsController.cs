using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sales.Models;

namespace sales.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { name = "alexandre", id = 1 });
            list.Add(new Department { name = "Marcela", id = 2 });
            list.Add(new Department { name = "Marta", id = 3 });
            list.Add(new Department { name = "Maria", id = 4 });

            return View(list);
        }
    }
}