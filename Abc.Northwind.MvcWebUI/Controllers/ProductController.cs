using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Northwind.Business.Abstract;
using Abc.Northwind.MvcWebUI.Models;

namespace Abc.Northwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public ActionResult Index(int page=1,int category =0)
        {
            int pageSize = 10;
            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Products = products.Skip((page - 1) * pageSize).Take(pageSize).ToList(),
                PageCount =(int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize =pageSize,
                Currentcategory=category,
                CurrentPage=page
            };
            //Html görüntüsü
            return View(model);
        }
        //public ActionResult AddToCart()
        //{
           
        //}

        //public string Session()
        //{
        //    HttpContext.Session.SetString("city","Ankara");
        //    HttpContext.Session.setInt32("age",32);

        //    HttpContext.Session.GetH
        //}
    }
}
