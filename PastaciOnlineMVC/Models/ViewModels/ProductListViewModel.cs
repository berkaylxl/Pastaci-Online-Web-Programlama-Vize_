using System.Collections;
using System.Collections.Generic;

namespace PastaciOnlineMVC.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string CurrentCategory { get; set; }
        

    }
}
