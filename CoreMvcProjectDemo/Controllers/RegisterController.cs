using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProjectDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        [HttpGet] //Ekleme işlemi gerçekleştirirken http post kullan.
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost] //Http get sayfa yüklenince çalışır. Http post sayfada buton tetiklenince çalışır.
        public IActionResult Index(Writer p)
        {
            p.WriterStatus = true;
            p.WriterAbout = "Deneme Test";
            wm.WriterAdd(p);
            return RedirectToAction("Index", "Blog");
        }
    }
}
