using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PastaciOnlineMVC.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }

        [BindNever]
        public ICollection <CartLine> Lines { get; set; }

        [Required(ErrorMessage ="Adınızı ve soyadınızı giriniz!!")]
        public string  Name { get; set; }

        [Required(ErrorMessage = "Mailinizi giriniz")]
        public string Email { get; set; }

        [Required(ErrorMessage ="Adresinizi giriniz!!")]
        public string Adress { get; set; }

        [Required(ErrorMessage ="Telefon numaranızı giriniz")]
        public string PhoneNumber { get; set; }

       

    }
}
