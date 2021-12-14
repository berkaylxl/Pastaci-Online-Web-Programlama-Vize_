using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public interface IOrderRepository
    {
        IQueryable<Order> Orders { get; }
        void AddOrder(Order order);
        
    }
}
