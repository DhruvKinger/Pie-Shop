using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EnterpriseApplication.Models;
using EnterpriseApplication.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EnterpriseApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepositry _pieRepositry;

        public HomeController(IPieRepositry pieRepositry)
        {
            _pieRepositry = pieRepositry;
        }
        public IActionResult Index()
        {

            var pies = _pieRepositry.GetAllPies().OrderBy(p => p.Name);
            var homeviewmodel = new HomeViewModel()
            {
                Title = "Welcome to Our Pie Shop",
                Pies = pies.ToList()
            };


            return View(homeviewmodel);
        }
        public IActionResult Details(int id)
        {
            var pie = _pieRepositry.GetPieById(id);
            if(pie==null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}