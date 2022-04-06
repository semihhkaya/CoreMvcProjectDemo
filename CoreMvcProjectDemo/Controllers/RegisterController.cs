using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProjectDemo.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet] //Ekleme işlemi gerçekleştirirken http post kullan.
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //Http get sayfa yüklenince çalışır. Http post sayfada buton tetiklenince çalışır.
        public IActionResult Index()
        {
            return View();
        }
    }
}
