using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
    }
}
