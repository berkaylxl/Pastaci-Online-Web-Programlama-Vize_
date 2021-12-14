using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PastaciOnlineMVC.Models;
using PastaciOnlineMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PastaciOnlineMVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductRepository _productrepo;
        private readonly ICategoryRepository _category;

        public HomeController(IProductRepository productrepo, ICategoryRepository category)
        {
            _productrepo = productrepo;
            _category = category;
        }
        public IActionResult Index()
        {
            Random rnd = new Random();
            List<Product> randomProducts = new List<Product>();
            for (int i = 0; i < 6; i++)
            {
                int rnID=rnd.Next(1, 21);
                if (!randomProducts.Where(p=>p.ProductID==rnID).Any())
                {
                    randomProducts.Add(
                   _productrepo.Products.FirstOrDefault(p => p.ProductID == rnID));
                    
                }
                else
                {
                    i--;
                }
            }
            return View(new ProductListViewModel
            {
                Products = randomProducts,
                Categories = _category.Categories
            });
        }
        [Route("Home/ProductDetails/{productId}")]
        public ActionResult ProductDetails(int productId)
        {
            return View(
                new ProductDetailsViewModel
                {
                    Product = _productrepo.Products
                    .Where(p => p.ProductID == productId)
                    .FirstOrDefault()
                }) ; 
        }
        [Route("Home/Categories/{categoryId}")]
        public ActionResult Categories(int categoryId)
        {
            string currentCategory = _category.Categories
                .Where(c => c.CategoryID == categoryId).FirstOrDefault().CategoryName;

            return View(new ProductListViewModel
            {
                Products = _productrepo.Products
               .Where(p => p.Category == categoryId),
                CurrentCategory = currentCategory
            }) ;
               
        
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
