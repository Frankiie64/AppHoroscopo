using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dataLayer.Service;
namespace Horoscopo.Controllers
{
    public class HoroscopoController : Controller
    {
        public ServiceSignoZodiacos service;

        public HoroscopoController()
        {
            service = new();
        }
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetMySing(DateTime bDay)
        {
            var sign = service.findSignoZodiaco(bDay);
           
            return View(sign);
        }
        public IActionResult SeeSings()
        {
            return View(service.getAll());
        }
       
    }
}
