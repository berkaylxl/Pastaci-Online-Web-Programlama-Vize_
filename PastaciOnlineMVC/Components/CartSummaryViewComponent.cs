using Microsoft.AspNetCore.Mvc;
using PastaciOnlineMVC.Models;

namespace PastaciOnlineMVC.Components
{
    public class CartSummaryViewComponent:ViewComponent
    {
        private Cart _cart;
        public CartSummaryViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
