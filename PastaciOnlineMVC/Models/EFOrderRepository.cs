using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace PastaciOnlineMVC.Models
{
    public class EFOrderRepository : IOrderRepository
    {

        private PastaciDbContext _dbContext;
        public EFOrderRepository(PastaciDbContext pastaciDbContext)
        {
            _dbContext = pastaciDbContext;
        }
        public IQueryable<Order> Orders => _dbContext.Orders
            .Include(o => o.Lines)
            .ThenInclude(l => l.Product);

        public void AddOrder(Order order)
        {
            _dbContext.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID==0)
            {
                _dbContext.Orders.Add(order);
            }
            _dbContext.SaveChanges();
        }
    }
}
