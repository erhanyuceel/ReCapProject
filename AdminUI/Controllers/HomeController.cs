using AdminUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Microsoft.AspNetCore.Authorization;
using Business.BusinessAspects.Autofac;

namespace AdminUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IBrandService _brandService;

        public HomeController(ILogger<HomeController> logger, IBrandService brandService)
        {
            _logger = logger;
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            var brands= _brandService.GetAll();
            BrandListViewModel model = new BrandListViewModel
            {
                Brands = brands
            };
            return View(model);
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
