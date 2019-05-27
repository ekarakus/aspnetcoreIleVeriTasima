using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using aspnetcoreIleVeriTasima.Models;

namespace aspnetcoreIleVeriTasima.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public IActionResult form(string ad,int yas) {
            ViewData["ad"] = ad;
            ViewData["yas"] = yas;
            ViewData["mesaj"] = "Gönderdiğiniz veriler elimize ulaştı eline koluna sağlık";
            return View();
        }

        [HttpGet]
        public IActionResult form()
        {
            return View();
        }

        public IActionResult al()
        {
            return View();
        }

        public IActionResult gonder()
        {
            return View();
        }

        public IActionResult Index()
        {
            
            personel enes = new personel()
            {
                ad = "enes",
                yas = 17
            };

            return View(enes);
        }

        public IActionResult About()
        {
            ViewData["ad"] = "Ali";
            ViewData["yas"] = 18;
            ViewData["iyiBiriMi"] = true;

            return View();
        }

        public IActionResult Contact()
        {
            ViewBag.ad = "Ali";
            ViewBag.yas = 18;

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
