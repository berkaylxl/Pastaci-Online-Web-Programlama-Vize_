using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PastaciOnlineMVC.Extensions;
using PastaciOnlineMVC.Models;
using System.Linq;

namespace PastaciOnlineMVC.Pages
{
    public class CartModel : PageModel
    {
        private IProductRepository _repository;
        public Cart Cart { get; set; }
        public CartModel(IProductRepository repo,Cart Service)
        {
            _repository = repo;
            Cart = Service;
        }
        public void OnGet()
        {
            
        }
        public IActionResult OnPost(int productId)
        {
            Product product = _repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            Cart.AddItem(product, 1);
            return RedirectToPage();
        }
        public IActionResult OnPostRemove(int productId)
        {
            Cart.RemoveLine(Cart.Lines.First(
                cl => cl.Product.ProductID == productId).Product);
            return RedirectToPage();
        }


    }
}
