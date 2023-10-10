using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers
{
    public class DemoController : Controller
    {
        //Khai bao cac phuong thuc
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(double heSoA, double heSoB){
            string phuongtrinh = "Phuong trinh da nhap la: " + heSoA + "x + " + heSoB + " = 0";
            string result;
            if(heSoA != 0 ){
                result =  "x = " + (-heSoB/heSoA);
            } else {
                if(heSoB == 0){
                    result = "Phuong trinh co vo so nghiem!";
                } else {
                    result = "Phuong trinh vo nghiem!";
                }
            }
            ViewBag.debai = phuongtrinh;
            ViewBag.noti = result;
            return View();
        }
    }
}