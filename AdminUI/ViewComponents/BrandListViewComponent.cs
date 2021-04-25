using AdminUI.Models;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminUI.ViewComponents
{
    public class BrandListViewComponent : ViewComponent
    {
        private IBrandService _brandService;

        public BrandListViewComponent(IBrandService brandService)
        {
            _brandService = brandService;
        }
        public ViewViewComponentResult Invoke()
        {
            var brands = _brandService.GetAll();
            BrandListViewModel model = new BrandListViewModel
            {
                Brands = brands
            };
            return View(model);
        }
    }
}
