using Microsoft.AspNetCore.Mvc;
using PastaciOnlineMVC.Models;
using System.Collections.Generic;
using System.Linq;

namespace PastaciOnlineMVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        private IOrderRepository _orderRepository;
        private Cart _cart;
        public OrderController(IOrderRepository orderRepository, Cart cart)
        {
            _orderRepository = orderRepository;
            _cart = cart;
        }
        public ViewResult Checkout()
        {
            ViewBag.isComplete = false;
           return View(new Order());
        }
        [HttpPost]
        public ViewResult Checkout(Order order)
        {
            if (_cart.Lines.Count() == 0)
            {
                ModelState.AddModelError("", "Sepetiniz Boş");
            }
            if (ModelState.IsValid)
            {
                order.Lines = _cart.Lines.ToArray();
                _orderRepository.AddOrder(order);
                _cart.Clear();
                ViewBag.isComplete = true;
                return View();
            }
            return View();

        }


    }
}
