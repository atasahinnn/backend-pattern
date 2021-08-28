using BackEnd.Business.Abstract;
using BackEnd.WEBUI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackEnd.WEBUI.Controllers
{
    public class ProductController:Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int category, int page = 1)
        {
            int pageSize = 5;
            var totalProduct = _productService.GetAll();
            var totalItems = totalProduct.Count();

            var productViewModel = new ProductListViewModel()
            {
                PageInfo = new PageInfo()
                {
                    TotalItems = totalItems,
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    CurrentCategory = category
                },

                Products = _productService.GetAll()
            };

            return View(productViewModel);
        }

    }
}
