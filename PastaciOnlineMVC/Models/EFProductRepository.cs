using System.Linq;

namespace PastaciOnlineMVC.Models
{

    public class EFProductRepository : IProductRepository
    {
        private readonly PastaciDbContext _dbContext;
        public EFProductRepository(PastaciDbContext pastaciDbContext)
        {
            _dbContext = pastaciDbContext;
        }


        public IQueryable<Product> Products => _dbContext.Products;
    }
}
