using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public IActionResult Index(Employee emp){
            string strResult = "Hello " + emp.EmployeeID + " - " + emp.FullName + " - " + emp.Position;
            ViewBag.noti = strResult;
            return View();
        }
    }
}